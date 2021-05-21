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
    public class OgrencilerFotograflarController : ControllerBase
    {
        IOgrenciFotografService _ogrencifotografService;

        public OgrencilerFotograflarController(IOgrenciFotografService ogrencifotografService)
        {
            _ogrencifotografService = ogrencifotografService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] OgrenciFotograf ogrenciFotograf)
        {
            var result = _ogrencifotografService.Add(file, ogrenciFotograf);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("delete")]
        public IActionResult Delete(int Id)
        {
            var ogrenciFotograf = _ogrencifotografService.GetById(Id).Data;
            var result = _ogrencifotografService.Delete(ogrenciFotograf);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm] OgrenciFotograf ogrenciFotograf)
        {
            var result = _ogrencifotografService.Delete(ogrenciFotograf);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _ogrencifotografService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _ogrencifotografService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyogrenciid")]
        public IActionResult GetByAkademisyenId(int ogrenciId)
        {
            var result = _ogrencifotografService.GetByOgrenciId(ogrenciId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}