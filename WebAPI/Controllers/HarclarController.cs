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
    public class HarclarController : ControllerBase
    {
        IHarcService _harcService;

        public HarclarController(IHarcService harcService)
        {
            _harcService = harcService;
        }

        [HttpPost("add")]
        public IActionResult Add(Harc harc)
        {
            var result = _harcService.Add(harc);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Harc harc)
        {
            var result = _harcService.Delete(harc);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("uppdate")]
        public IActionResult Update(Harc harc)
        {
            var result = _harcService.Update(harc);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _harcService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _harcService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


        [HttpGet("getbyogrenciid")]
        public IActionResult GetByOgrenciId(int Id)
        {
            var result = _harcService.GetByOgrenciId(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getHarcDetaylari")]
        public IActionResult GetHarcDetay()
        {
            var result = _harcService.GetAllByHarcDto();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}