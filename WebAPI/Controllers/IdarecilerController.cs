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
    public class IdarecilerController : Controller
    {
        IIdareciService _idareciService;

        public IdarecilerController(IIdareciService idareciService)
        {
            _idareciService = idareciService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _idareciService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _idareciService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbysicilno")]
        public IActionResult GetBySicilNo(int sicilNo)
        {
            var result = _idareciService.GetBySicilNo(sicilNo);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyemail")]
        public IActionResult GetByEMail(string email)
        {
            var result = _idareciService.GetByEMail(email);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyunvanid")]
        public IActionResult GetByUnvanId(int unvanId)
        {
            var result = _idareciService.GetByUnvanId(unvanId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(Idareci akademisyen)
        {
            var result = _idareciService.Add(akademisyen);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Idareci akademisyen)
        {
            var result = _idareciService.Delete(akademisyen);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Idareci akademisyen)
        {
            var result = _idareciService.Update(akademisyen);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

