using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HarclarController : ControllerBase
    {
        IHarcService _harcService;

        public HarclarController(IHarcService harcService)
        {
            _harcService = harcService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _harcService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _harcService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


        [HttpPost("add")]
        public IActionResult Add(Harc harc)
        {
            var result = _harcService.Add(harc);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}