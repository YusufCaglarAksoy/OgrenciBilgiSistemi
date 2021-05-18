using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AkademisyenlerController : Controller
    {
        IAkademisyenService _akademisyenService;

        public AkademisyenlerController(IAkademisyenService akademisyenService)
        {
            _akademisyenService = akademisyenService;
        }

        [HttpPost("add")]
        public IActionResult Add(AkademisyenForRegisterDto akademisyen)
        {
            var result = _akademisyenService.Add(akademisyen);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(int Id)
        {
            var result = _akademisyenService.Delete(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(AkademisyenForRegisterDto akademisyen)
        {
            var result = _akademisyenService.Update(akademisyen);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("login")]
        public IActionResult Login(LoginDto loginDto)
        {
            var result = _akademisyenService.Login(loginDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _akademisyenService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbybolumid")]
        public IActionResult GetByBolumId(int Id)
        {
            var result = _akademisyenService.GetByBolumId(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbysicilno")]
        public IActionResult GetBySicilNo(int sicilNo)
        {
            var result = _akademisyenService.GetBySicilNo(sicilNo);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyemail")]
        public IActionResult GetByEMail(string email)
        {
            var result = _akademisyenService.GetByEMail(email);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyunvanid")]
        public IActionResult GetByUnvanId(int unvanId)
        {
            var result = _akademisyenService.GetByUnvanId(unvanId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _akademisyenService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getakademisyenDetaylari")]
        public IActionResult GetAkademisyenDetay()
        {
            var result = _akademisyenService.GetAllByAkademisyenDto();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

