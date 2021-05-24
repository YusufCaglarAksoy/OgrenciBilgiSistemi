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
    public class SinavlarController : ControllerBase
    {
        ISinavService _sinavService;
        public SinavlarController(ISinavService sinavService)
        {
            _sinavService = sinavService;
        }

        [HttpPost("add")]
        public IActionResult Add(Sinav sinav)
        {
            var result = _sinavService.Add(sinav);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("delete")]
        public IActionResult Delete(int Id)
        {
            var result = _sinavService.Delete(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Sinav sinav)
        {
            var result = _sinavService.Update(sinav);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _sinavService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _sinavService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyakademisyenid")]
        public IActionResult GetByAkademisyenId(int Id)
        {
            var result = _sinavService.GetByAkademisyenId(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getsinavDetaylari")]
        public IActionResult GetAllBySinavDto()
        {
            var result = _sinavService.GetAllBySinavDto();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}