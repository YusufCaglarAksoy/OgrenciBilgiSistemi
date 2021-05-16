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
    public class SubelerController : Controller
    {
        ISubeService _subeService;

        public SubelerController(ISubeService subeService)
        {
            _subeService = subeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _subeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _subeService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(Sube sube)
        {
            var result = _subeService.Add(sube);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Sube sube)
        {
            var result = _subeService.Delete(sube);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Sube sube)
        {
            var result = _subeService.Update(sube);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbydersid")]
        public IActionResult GetByDersId(int dersid)
        {
            var result = _subeService.GetByDersId(dersid);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyogretmenid")]
        public IActionResult GetByOgretmenId(int ogretmenid)
        {
            var result = _subeService.GetByOgretmenId(ogretmenid);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
