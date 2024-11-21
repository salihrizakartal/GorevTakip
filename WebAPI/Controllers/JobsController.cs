using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        //Loosely coupled
        //IoC Container -- Inversion of Control

        IJobService _jobService;

        public JobsController(IJobService jobService)
        {
            _jobService = jobService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //Dependency chain
            Thread.Sleep(5000);

            var result = _jobService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("add")]

        public IActionResult Add(Job job)
        {
            var result = _jobService.Add(job);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _jobService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


      

        [HttpGet("getbyname")]
        public IActionResult GetByName(string emplyoeeName) 
        {
            var result = _jobService.GetAllByEmplyoeeName(emplyoeeName);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]

        public IActionResult Update(Job job)
        {
            var result = _jobService.Update(job);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
