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
    public class BolumlerlerController : Controller
    {
        IBolumService _bolumService;

        public BolumlerlerController(IBolumService bolumService)
        {
            _bolumService = bolumService;
        }

        [HttpPost("add")]
        public IActionResult Add(Bolum bolum)
        {
            var result = _bolumService.Add(bolum);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Bolum bolum)
        {
            var result = _bolumService.Delete(bolum);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Bolum bolum)
        {
            var result = _bolumService.Update(bolum);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _bolumService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _bolumService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyfakulteId")]
        public IActionResult GetByFakulteId(int Id)
        {
            var result = _bolumService.GetByFakulteId(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbolumDetaylari")]
        public IActionResult GetBolumDetay()
        {
            var result = _bolumService.GetAllByBolumDto();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
