using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project3.Comon;
using Project3.Models;
using Project3.Repository;


namespace Project3.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public  class BaseController<T> : ControllerBase where T : Base
    {
        private IBaseRepository<T> _repository;
        public  BaseController(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult<List<T>>> GetAll()
        {
            //var result = await _repository.SortAndPagination(colName, isAsc, index, size);
            var result = await _repository.GetAllNoPagAndFilter();
            return Ok(result);

        }
        //[Authorize(Roles = "ADMIN , SUBADMIN , CUSTOMER")]
        [HttpPost]
        [Route("FullFilter")]
        public async Task<ActionResult<List<T>>> FullFilter([FromBody] GetRequestDTO requestDTO)
        {
            var result = await _repository.FullFilter(requestDTO);
            return Ok(result);
        }
        [Authorize(Roles = "ADMIN , SUBADMIN , CUSTOMER")]
        [HttpGet("GetById/{id}")]
        public async Task<ActionResult<AuthController>> GetById(int id)
        {
            var result = await (_repository.GetById(id));
            return Ok(result);
        }
        //[Authorize(Roles = "ADMIN , SUBADMIN")]
        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<AuthController>> Create(T entity)
        {
            var result = await _repository.Create(entity);
            return Ok(result);
        }
        [Authorize(Roles = "ADMIN , SUBADMIN")]
        [HttpPut]
        [Route("Update")]
        public async Task<ActionResult<AuthController>> Update(T entity)
        {
            var result = await (_repository.Update(entity));
            return Ok(result);
        }
        //[Authorize(Roles = "ADMIN , SUBADMIN")]
        [HttpDelete]
        [Route("Delete")]
        public async Task<ActionResult> Delete([FromBody] DeleteRequest request)
        {
            var result = await _repository.Delete(request.Id);
            return Ok(result);
        }



    }
}
