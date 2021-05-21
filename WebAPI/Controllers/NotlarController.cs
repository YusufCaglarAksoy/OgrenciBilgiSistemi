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
    public class NotlarController : ControllerBase
    {
        INotService _notService;

        public NotlarController(INotService notService)
        {
            _notService = notService;
        }

        [HttpPost("add")]
        public IActionResult Add(Not not)
        {
            var result = _notService.Add(not);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("delete")]
        public IActionResult Delete(int Id)
        {
            var result = _notService.Delete(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Not not)
        {
            var result = _notService.Update(not);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _notService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int Id)
        {
            var result = _notService.GetById(Id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


        [HttpGet("getbyogrenciid")]
        public IActionResult GetByOgrenciId(int ogrenciId)
        {
            var result = _notService.GetByOgrenciId(ogrenciId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getbysinavid")]
        public IActionResult GetBySinavId(int sinavId)
        {
            var result = _notService.GetBySinavId(sinavId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpGet("getnotlardetaylari")]
        public IActionResult GetNotDetay()
        {
            var result = _notService.GetAllByNotDto();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}