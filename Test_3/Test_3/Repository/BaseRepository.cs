using Test_3.Common;
using Test_3.Models;
using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;
using Z.EntityFramework.Plus;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;


namespace Test_3.Repository
{
    public interface IBaseRepository<T> where T : Base
    {
        Task<List<T>> GetAll(int index = 1, int size = 1);
        Task<T> GetById(int id);
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
        Task<List<T>> SortAndPagination(string colName = "Id", bool isAsc = true, int index = 1, int size = 10);
        Task<List<T>> FullFilter(GetRequestDTO requestDTO);
    }

    public class BaseRepository<T> : IBaseRepository<T> where T : Base
    {
        private readonly DataContext _context;
        private readonly DbSet<T> _dbSet;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public BaseRepository(DataContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbSet = _context.Set<T>();
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        private string GetCurrentUserId()
        {
            // Do implement your logic here to get current user ID
            // Example: return _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return null;
        }

        public async Task<T> Create(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            entity.CreatedDate = DateTime.Now;
            //entity.CreatedBy = GetCurrentUserId();

            _dbSet.Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<T> Delete(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                entity.DeletedAt = DateTime.Now;
                //entity.DeletedBy = GetCurrentUserId();

                _dbSet.Update(entity);
                await _context.SaveChangesAsync();
            }

            return entity;
        }

        public async Task<List<T>> GetAll(int index = 1, int size = 1)
        {
            return await _dbSet.Skip((index - 1) * size).Take(size).ToListAsync();
        }

        public async Task<List<T>> FullFilter(GetRequestDTO requestDTO)
        {
            if (requestDTO == null)
                throw new ArgumentNullException(nameof(requestDTO));

            var query = _dbSet.AsQueryable();

            foreach (var filter in requestDTO.filters)
            {
                if (string.IsNullOrEmpty(filter.colName))
                    throw new ArgumentException("Column name cannot be null or empty", nameof(filter.colName));

                query = query.WhereDynamic($"{filter.colName} {filter._operator} {filter.rightSize}");
            }

            if (!string.IsNullOrEmpty(requestDTO.colName))
            {
                query = requestDTO.isAsc
                    ? query.OrderByDynamic(requestDTO.colName)
                    : query.OrderByDescendingDynamic(requestDTO.colName);
            }

            query = query.Skip((requestDTO.index - 1) * requestDTO.size).Take(requestDTO.size);

            return await query.ToListAsync();
        }

        public async Task<List<T>> SortAndPagination(string colName = "Id", bool isAsc = true, int index = 1, int size = 10)
        {
            var query = _dbSet.AsQueryable();

            if (isAsc)
            {
                query = query.OrderBy(x => EF.Property<object>(x, colName));
            }
            else
            {
                query = query.OrderByDescending(x => EF.Property<object>(x, colName));
            }

            query = query.Skip((index - 1) * size).Take(size);

            return await query.ToListAsync();
        }


        public async Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<T> Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            entity.UpdatedAt = DateTime.Now;
            //entity.UpdatedBy = GetCurrentUserId();

            _dbSet.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
