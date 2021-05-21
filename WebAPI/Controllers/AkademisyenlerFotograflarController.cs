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
    public class AkademisyenlerFotograflarController : ControllerBase
    {
        IAkademisyenFotografService _akademisyenfotografService;

        public AkademisyenlerFotograflarController(IAkademisyenFotografService akademisyenFotografService)
        {
            _akademisyenfotografService = akademisyenFotografService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] AkademisyenFotograf akademisyenFotograf)
        {
            var result = _akademisyenfotografService.Add(file, akademisyenFotograf);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("delete")]
        public IActionResult Delete([FromForm(Name = ("Id"))] int Id)
        {
            var kullaniciFotograf = _akademisyenfotografService.GetById(Id).Data;
            var result = _akademisyenfotografService.Delete(kullaniciFotograf);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm] AkademisyenFotograf akademisyenFotograf)
        {
            var result = _akademisyenfotografService.Delete(akademisyenFotograf);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _akademisyenfotografService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _akademisyenfotografService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyakademisyenid")]
        public IActionResult GetByAkademisyenId(int akademisyenId)
        {
            var result = _akademisyenfotografService.GetByAkademisyenId(akademisyenId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}