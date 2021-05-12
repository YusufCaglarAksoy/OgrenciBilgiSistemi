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
    public class SinifListeController : ControllerBase
    {
        ISinifListeService _sinifListeService;
        public SinifListeController(ISinifListeService sinifListeService)
        {
            _sinifListeService = sinifListeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _sinifListeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _sinifListeService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(SinifListe sinifListe)
        {
            var result = _sinifListeService.Add(sinifListe);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(SinifListe sinifListe)
        {
            var result = _sinifListeService.Delete(sinifListe);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(SinifListe sinifListe)
        {
            var result = _sinifListeService.Update(sinifListe);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}