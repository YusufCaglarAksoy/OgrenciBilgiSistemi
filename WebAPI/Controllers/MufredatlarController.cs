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
    public class MufredatlarController : Controller
    {
        IMufredatService _mufredatService;

        public MufredatlarController(IMufredatService mufredatService)
        {
            _mufredatService = mufredatService;
        }

        [HttpPost("add")]
        public IActionResult Add(Mufredat mufredat)
        {
            var result = _mufredatService.Add(mufredat);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Mufredat mufredat)
        {
            var result = _mufredatService.Delete(mufredat);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Mufredat mufredat)
        {
            var result = _mufredatService.Update(mufredat);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _mufredatService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _mufredatService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getmufredatDetaylari")]
        public IActionResult GetMufredatDetay()
        {
            var result = _mufredatService.GetAllByMufredatDto();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
