using Test_3.Common;
using Test_3.Models;
using Test_3.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.CodeDom;
using Test_3.Common;
using Test_3.Models;
using Test_3.Repository;
using prj3.Models;

namespace Test_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : Base
    {
        private IBaseRepository<T> _repository;
        public BaseController(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<T>>> GetAll(string colName, bool isAsc = true, int index = 1, int size = 1)
        {

            var result = await _repository.SortAndPagination(colName, isAsc, index, size);
            return Ok(result);
        }

        [HttpPost]
        [Route("FullFilter")]
        public async Task<ActionResult<List<T>>> FullFilter([FromBody] GetRequestDTO requestDTO)
        {
            var result = await _repository.FullFilter(requestDTO);
            return Ok(result);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            var result = await _repository.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<Product>> Create(T entity)
        {
            var result = await _repository.Create(entity);
            return Ok(result);
        }
        [HttpPut]
        public async Task<ActionResult<Product>> Update(T entity)
        {
            var resullt = await _repository.Update(entity);
            return Ok(resullt);
        }

        [HttpDelete]
        public async Task<ActionResult<Product>> Delete(int id)
        {
            var result = await _repository.Delete(id);
            return Ok(result);
        }
    }
}
