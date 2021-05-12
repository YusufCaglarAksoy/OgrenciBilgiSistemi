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
    public class NotlarController : ControllerBase
    {
        INotService _notService;

        public NotlarController(INotService notService)
        {
            _notService = notService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _notService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _notService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(Not not)
        {
            var result = _notService.Add(not);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Not not)
        {
            var result = _notService.Delete(not);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Not not)
        {
            var result = _notService.Update(not);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}