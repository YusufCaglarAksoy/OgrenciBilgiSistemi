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
    public class DerslerController : ControllerBase
    {
        IDersService _dersService;

        public DerslerController(IDersService dersService)
        {
            _dersService = dersService;
        }

        [HttpPost("add")]
        public IActionResult Add(Ders ders)
        {
            var result = _dersService.Add(ders);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("delete")]
        public IActionResult Delete(int Id)
        {
            var result = _dersService.Delete(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Ders ders)
        {
            var result = _dersService.Update(ders);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _dersService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _dersService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbydersKodu")]
        public IActionResult GetByDersKodu(string dersKodu)
        {
            var result = _dersService.GetByDersKodu(dersKodu);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getdersDetaylari")]
        public IActionResult GetDersDetay()
        {
            var result = _dersService.GetAllByDersDto();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbydonemid")]
        public IActionResult GetByDonemId(int donemId)
        {
            var result = _dersService.GetByDonemId(donemId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbybolumid")]
        public IActionResult GetByBolumId(int bolumId)
        {
            var result = _dersService.GetByBolumId(bolumId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbysinif")]
        public IActionResult GetBySinif(int sinif)

        {
            var result = _dersService.GetBySinif(sinif);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}
