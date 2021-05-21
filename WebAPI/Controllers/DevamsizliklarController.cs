using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    namespace WebAPI.Controllers
    {
        [Route("api/[controller]")]
        [ApiController]
        public class DevamsizliklarController : ControllerBase
        {
            IDevamsizlikService _devamsizlikService;

            public DevamsizliklarController(IDevamsizlikService devamsizlikService)
            {
                _devamsizlikService = devamsizlikService;
            }

            [HttpPost("add")]
            public IActionResult Add(Devamsizlik ders)
            {
                var result = _devamsizlikService.Add(ders);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

            [HttpGet("delete")]
            public IActionResult Delete(int Id)
            {
                var result = _devamsizlikService.Delete(Id);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

            [HttpPost("update")]
            public IActionResult Update(Devamsizlik devamsizlik)
            {
                var result = _devamsizlikService.Update(devamsizlik);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

            [HttpGet("getall")]
            public IActionResult GetAll()
            {
                var result = _devamsizlikService.GetAll();
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }

            [HttpGet("getbyid")]
            public IActionResult GetById(int Id)
            {
                var result = _devamsizlikService.GetById(Id);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);

            }

            [HttpGet("getbydersid")]
            public IActionResult GetByDersId(int dersId)
            {
                var result = _devamsizlikService.GetByDersId(dersId);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);

            }

            [HttpGet("getbyogrenciid")]
            public IActionResult GetByOgrenciId(int ogrenciId)
            {
                var result = _devamsizlikService.GetByOgrenciId(ogrenciId);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);

            }

            [HttpGet("getbydevamsizlikdurumu")]
            public IActionResult GetByDevamsizlikDurumu(bool devamsizlikDurumu)
            {
                var result = _devamsizlikService.GetByDevamsizlikDurumu(devamsizlikDurumu);
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);

            }

            [HttpGet("getdevamsizlikDetaylari")]
            public IActionResult GetDevamsizlikDetay()
            {
                var result = _devamsizlikService.GetAllByDevamsizlikDto();
                if (result.Success)
                {
                    return Ok(result);
                }
                return BadRequest(result);
            }


        }
    }
}
