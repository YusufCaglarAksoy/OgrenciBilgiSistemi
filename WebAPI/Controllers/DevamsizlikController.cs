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
        public class DevamsizlikController : ControllerBase
        {
            IDevamsizlikService _devamsizlikService;

            public DevamsizlikController(IDevamsizlikService devamsizlikService)
            {
                _devamsizlikService = devamsizlikService;
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

            [HttpPost("delete")]
            public IActionResult Delete(Devamsizlik devamsizlik)
            {
                var result = _devamsizlikService.Delete(devamsizlik);
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


        }
    }
}
