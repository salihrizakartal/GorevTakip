using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Protocol;
using System.Linq;


namespace MVC.Controllers
{
	public class EmplyoeesController : Controller
	{
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
            

            if (result!=null)
			{
				;
                return View(result);
			}
			return View(null);

		}
		//[HttpPost("add")]

		//public IActionResult Add(Emplyoee emplyoee)
		//{
		//	var result = _emplyoeeService.Add(emplyoee);
		//	return View(result);
		//	//if (result.Success)
		//	//{
		//	//	return Ok(result);
		//	//}
		//	//return BadRequest(result);
		//}

		//[HttpGet("getbyid")]
		//public IActionResult GetById(int id)
		//{
		//	var result = _emplyoeeService.GetById(id);
		//	if (result.Success)
		//	{
		//		return Ok(result);
		//	}
		//	return BadRequest(result);
		//}
		//[HttpPost("delete")]

		//public IActionResult Delete(Emplyoee emplyoee)
		//{
		//	var result = _emplyoeeService.Delete(emplyoee);

		//	if (result.Success)
		//	{
		//		return Ok(result);
		//	}
		//	return BadRequest(result);
		//}
		//[HttpPost("update")]

		//public IActionResult Update(Emplyoee emplyoee)
		//{
		//	var result = _emplyoeeService.Update(emplyoee);

		//	if (result.Success)
		//	{
		//		return Ok(result);
		//	}
		//	return BadRequest(result);
		//}

	}
}
