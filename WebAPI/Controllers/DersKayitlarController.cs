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
    public class DersKayitlarController:Controller
    {
        IDersKayitService _dersKayitService;

        public DersKayitlarController(IDersKayitService dersKayit)
        {
            _dersKayitService = dersKayit;
        }

        [HttpPost("add")]
        public IActionResult Add(DersKayit dersKayit)
        {
            var result = _dersKayitService.Add(dersKayit);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("delete")]
        public IActionResult Delete(int Id)
        {
            var result = _dersKayitService.Delete(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(DersKayit dersKayit)
        {
            var result = _dersKayitService.Update(dersKayit);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _dersKayitService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _dersKayitService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbyogrenciId")]
        public IActionResult GetByFakulteId(int ogrenciId)
        {
            var result = _dersKayitService.GetByOgrenciId(ogrenciId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbydanismanId")]
        public IActionResult GetBolumDetay(int danismanId)
        {
            var result = _dersKayitService.GetByDanismanId(danismanId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
