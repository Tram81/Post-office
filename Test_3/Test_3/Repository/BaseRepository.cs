using Test_3.Common;
using Test_3.Data;
using Test_3.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Text;
using Test_3.Data;
using Test_3.Models;
using Z.EntityFramework.Plus;

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
        protected ApplicationDbContext _context;
        protected DbSet<T> _dbSet;

        protected readonly IHttpContextAccessor _httpContextAccessor;


        public BaseRepository(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _dbSet = _context.Set<T>();

        }

        private string GetCurrentUserId()
        {
            return "";
        }
        public async Task<T> Create(T entity)
        {
            if (entity != null)
            {
                entity.CreatedDate = DateTime.Now;
                entity.CreatedBy = GetCurrentUserId();

                _dbSet.Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            return null;
        }

        public async Task<T> Delete(int id)
        {
            var result = await _dbSet.FindAsync(id);
            if (result != null)
            {
                result.IsDeleted = true;
                result.DeletedAt = DateTime.Now;
                result.DeletedBy = GetCurrentUserId();
                _dbSet.Update(result);
                await _context.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<List<T>> GetAll(int index = 1, int size = 1)
        {
            var result = _dbSet.AsQueryable();
            result = result.Skip((index - 1) * size).Take(size);
            return await result.ToListAsync();
        }
        public async Task<List<T>> FullFilter(GetRequestDTO requestDTO)
        {
            var result = _dbSet.AsQueryable();

            if (requestDTO != null)
            {
                //Tim kiem  
                foreach (var filter in requestDTO.filters)
                {
                    var query = "";

                    if (filter._operator == "=")
                    {
                        query = string.Format("r.{0} == {1}", filter.colName, filter.rightSize);
                    }
                    if (filter._operator == ">")
                    {
                        query = string.Format("r.{0} > {1}", filter.colName, filter.rightSize);
                    }
                    if (filter._operator == "<")
                    {
                        query = string.Format("r.{0} < {1}", filter.colName, filter.rightSize);
                    }
                    if (filter._operator == "!")
                    {
                        query = string.Format("r.{0} != {1}", filter.colName, filter.rightSize);
                    }
                    result = result.WhereDynamic(r => query);
                }
                //Sap xep
                // Lay ra duoc cot co colName => orderby / orderByDesc
                if (requestDTO.isAsc == true)
                {
                    result = result.OrderByDynamic(r => "r." + requestDTO.colName);
                }
                else
                {
                    result = result.OrderByDescendingDynamic(r => "r." + requestDTO.colName);
                }

                // Phan trang 
                result = result.Skip((requestDTO.index - 1) * requestDTO.size).Take(requestDTO.size);
                return await result.ToListAsync();

            }
            return null;

        }
        public async Task<List<T>> SortAndPagination(string colName = "Id", bool isAsc = true, int index = 1, int size = 10)
        {
            var result = _dbSet.AsQueryable();
            //Sap xep
            // Lay ra duoc cot co colName => orderby / orderByDesc
            if (isAsc == true)
            {
                result = result.OrderByDynamic(r => "r." + colName);
            }
            else
            {
                result = result.OrderByDescendingDynamic(r => "r." + colName);
            }

            // Phan trang 
            result = result.Skip((index - 1) * size).Take(size);
            return await result.ToListAsync();

        }
        public async Task<T> GetById(int id)
        {
            var result = await _dbSet.FindAsync(id);
            return result;
        }

        public async Task<T> Update(T entity)
        {
            if (entity != null)
            {
                entity.UpdatedAt = DateTime.Now;
                entity.UpdatedBy = GetCurrentUserId();
                _dbSet.Update(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            return null;
        }
    }
}
