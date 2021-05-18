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
    public class IdarecilerFotograflarController : ControllerBase
    {
        IIdareciFotografService _idarecifotografService;

        public IdarecilerFotograflarController(IIdareciFotografService idarecifotografService)
        {
            _idarecifotografService = idarecifotografService;
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm(Name = ("Image"))] IFormFile file, [FromForm] IdareciFotograf idareciFotograf)
        {
            var result = _idarecifotografService.Add(file, idareciFotograf);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete([FromForm(Name = ("Id"))] int Id)
        {
            var idareciFotograf = _idarecifotografService.GetById(Id).Data;
            var result = _idarecifotografService.Delete(idareciFotograf);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm(Name = ("Image"))] IFormFile file, [FromForm] IdareciFotograf idareciFotograf)
        {
            var result = _idarecifotografService.Delete(idareciFotograf);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _idarecifotografService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _idarecifotografService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyidareciid")]
        public IActionResult GetByAkademisyenId(int idareciId)
        {
            var result = _idarecifotografService.GetByIdareciId(idareciId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
    }
}