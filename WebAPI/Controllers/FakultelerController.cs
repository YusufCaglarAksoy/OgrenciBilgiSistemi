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
    public class FakultelerController : Controller
    {
        IFakulteService _fakulteService;

        public FakultelerController(IFakulteService fakulteService)
        {
            _fakulteService = fakulteService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _fakulteService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _fakulteService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(Fakulte fakulte)
        {
            var result = _fakulteService.Add(fakulte);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Fakulte fakulte)
        {
            var result = _fakulteService.Delete(fakulte);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Fakulte fakulte)
        {
            var result = _fakulteService.Update(fakulte);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


    }
}
