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
    public class AkademisyenlerController : Controller
    {
        IAkademisyenService _akademisyenService;

        public AkademisyenlerController(IAkademisyenService akademisyenService)
        {
            _akademisyenService = akademisyenService;
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
        public IActionResult GetByUnvanaId(int Id)
        {
            var result = _akademisyenService.GetByUnvanId(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(Akademisyen akademisyen)
        {
            var result = _akademisyenService.Add(akademisyen);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Akademisyen akademisyen)
        {
            var result = _akademisyenService.Delete(akademisyen);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Akademisyen akademisyen)
        {
            var result = _akademisyenService.Update(akademisyen);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}

