﻿using Test_3.Data;
using Test_3.Models;
using Test_3.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Test_3.Controllers;
using prj3.Models;

namespace Test_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreasController : BaseController<Area>
    {
        public AreasController(IBaseRepository<Area> repository) : base(repository)
        {
        }
    }
}
