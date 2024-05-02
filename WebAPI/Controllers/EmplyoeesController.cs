using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Abstract;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmplyoeesController : ControllerBase
    {
        //Loosely coupled
        //IoC Container -- Inversion of Control
        
        IEmplyoeeService _emplyoeeService;

        public EmplyoeesController(IEmplyoeeService emplyoeeService)
        {
            _emplyoeeService = emplyoeeService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Dependency chain

            var result = _emplyoeeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]

        public IActionResult Add(Emplyoee emplyoee)
        {
            var result = _emplyoeeService.Add(emplyoee);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _emplyoeeService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("delete")]

        public IActionResult Delete(Emplyoee emplyoee)
        {
            var result = _emplyoeeService.Delete(emplyoee);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("update")]

        public IActionResult Update(Emplyoee emplyoee)
        {
            var result = _emplyoeeService.Update(emplyoee);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
