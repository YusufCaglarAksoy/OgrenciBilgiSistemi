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
    public class OgrencilerController : ControllerBase
    {
        IOgrenciService _ogrenciService;

        public OgrencilerController(IOgrenciService ogrenciService)
        {
            _ogrenciService = ogrenciService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _ogrenciService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getogrenciDetaylari")]
        public IActionResult GetOgrenciDetay()
        {
            var result = _ogrenciService.GetAllByOgrenciDto();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyogrencino")]
        public IActionResult GetByOgrenciNo(int ogrenciNo)
        {
            var result = _ogrenciService.GetByOgrenciNo(ogrenciNo);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbybolumid")]
        public IActionResult GetByBolumId(int Id)
        {
            var result = _ogrenciService.GetByBolumId(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbydanismanid")]
        public IActionResult GetByDanismanId(int Id)
        {
            var result = _ogrenciService.GetByDanismanId(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyemail")]
        public IActionResult GetByEMail(string email)
        {
            var result = _ogrenciService.GetByEMail(email);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(Ogrenci ogrenci)
        {
            var result = _ogrenciService.Add(ogrenci);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Ogrenci ogrenci)
        {
            var result = _ogrenciService.Delete(ogrenci);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Ogrenci ogrenci)
        {
            var result = _ogrenciService.Update(ogrenci);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
