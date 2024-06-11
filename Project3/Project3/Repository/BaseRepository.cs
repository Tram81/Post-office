using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project3.Comon;
using Project3.Data;
using Project3.Models;
using System.Drawing;
using System.Security.Policy;
using System.Text;

namespace Project3.Repository
{
    public interface IBaseRepository<T> where T : Base
    {
        Task<List<T>> GetAll(bool isAsc = true, int index = 1, int size = 3);
        Task<T> GetById(int id);
        Task<List<T>> GetAllNoPagAndFilter();
        Task<T> Create(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
        Task<List<T>> SortAndPagination(string colName = "Id", bool isAsc = true, int index = 1, int size = 3);
        Task<List<T>> FullFilter(GetRequestDTO requestDTO);

    }
    public class BaseRepository<T> : IBaseRepository<T> where T : Base
    {
        protected ApplicationDbContext _context;
        protected DbSet<T> _dbSet;
        //protected UserManager<IdentityUser> _userManager;
        //private string _currentUserId;

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
                
                _dbSet.Add(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            return null;
        }
        public async Task<List<T>> GetAllNoPagAndFilter()
        {
            var result = await _dbSet.ToListAsync();
            return result;
        }
        public async Task<T> Delete(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity); // Xóa bản ghi khỏi DbSet
                await _context.SaveChangesAsync(); // Lưu thay đổi vào cơ sở dữ liệu
                return entity;
            }
            return null;
        }


        public async Task<List<T>> GetAll(bool isAsc = true, int index = 1, int size = 3)
        {
            var result = _dbSet.AsQueryable();
            result = result.Skip((index - 1) * size).Take(size);
            return await result.ToListAsync();
        }
        public async Task<List<T>> FullFilter(GetRequestDTO requestDTO)
        {
            if (requestDTO.filterRequests == null || requestDTO.filterRequests.Count <= 0)
            {
                return await GetAll(requestDTO.isAsc, requestDTO.index, requestDTO.size);
            }
            else
            {

                var result = _dbSet.AsQueryable();

                var properties = typeof(T).GetProperties();

                foreach (var property in properties)
                {
                    foreach (var item in requestDTO.filterRequests)
                    {
                        if (property.Name.ToLower().Equals(item.colName.ToLower()))
                        {
                            if (property.PropertyType == typeof(string))
                            {
                                if (item._operator == "like")
                                {
                                    result = result.Where(x => EF.Property<string>(x, property.Name).Contains(item._RightSize));
                                }
                                else if (item._operator == "equal")
                                {
                                    result = result.Where(x => EF.Property<string>(x, property.Name) == item._RightSize);
                                }
                                else if (item._operator == "not")
                                {
                                    result = result.Where(x => !EF.Property<string>(x, property.Name).Contains(item._RightSize));
                                }
                            }
                            else if (property.PropertyType == typeof(int))
                            {
                                if (item._operator == "equal")
                                {
                                    result = result.Where(x => EF.Property<int>(x, property.Name) == int.Parse(item._RightSize));
                                }
                                else if (item._operator == "not")
                                {
                                    result = result.Where(x => EF.Property<int>(x, property.Name) != int.Parse(item._RightSize));
                                }
                            }
                        }

                    }

                }
                //Sap xep
                if (requestDTO.isAsc == true)
                {
                    result = result.OrderByDynamic(r => "r." + requestDTO.colName);
                }
                else
                {
                    result = result.OrderByDescendingDynamic(r => "r." + requestDTO.colName);
                }
                // Phân trang
                result = result.Skip((requestDTO.index - 1) * requestDTO.size).Take(requestDTO.size);

                return await result.ToListAsync();
            }


        }
        public async Task<List<T>> SortAndPagination(string colName = "Id", bool isAsc = true, int index = 1, int size = 3)
        {
            var result = _dbSet.AsQueryable();

            //sap xep

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
                
                _dbSet.Update(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            return null;
        }
    }
}
