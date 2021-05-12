using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullaniciFotograflarController : ControllerBase
    {
        IKullaniciFotografService _kullanicifotografService;

        public KullaniciFotograflarController(IKullaniciFotografService kullanicifotografService)
        {
            _kullanicifotografService = kullanicifotografService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _kullanicifotografService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _kullanicifotografService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] KullaniciFotograf kullanicifotograf)
        {
            var result = _kullanicifotografService.Add(file,kullanicifotograf);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete([FromForm(Name = ("Id"))] int Id)
        {
            var kullaniciFotograf = _kullanicifotografService.GetById(Id).Data;
            var result = _kullanicifotografService.Delete(kullaniciFotograf);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm(Name = ("Id"))] int Id)
        {
            var kullaniciFotograf = _kullanicifotografService.GetById(Id).Data;
            var result = _kullanicifotografService.Delete(kullaniciFotograf);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}