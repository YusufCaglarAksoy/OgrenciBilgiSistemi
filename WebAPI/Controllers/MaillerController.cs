using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaillerController : ControllerBase
    {
        IMailService _mailService;

        public MaillerController(IMailService mailService)
        {
            _mailService = mailService;
        }

        [HttpPost("add")]
        public IActionResult Add(Mail mail)
        {
            var result = _mailService.Add(mail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Mail mail)
        {
            var result = _mailService.Delete(mail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Mail mail)
        {
            var result = _mailService.Update(mail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _mailService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _mailService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbygonderenmail")]
        public IActionResult GetByGonderenMail(string mail)
        {
            var result = _mailService.GetByGonderenMail(mail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyalicimail")]
        public IActionResult GetByAliciMail(string mail)
        {
            var result = _mailService.GetByAliciMail(mail);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        
    }
}