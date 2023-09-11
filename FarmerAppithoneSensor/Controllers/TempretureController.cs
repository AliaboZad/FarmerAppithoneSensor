using FarmerAppithoneSensor.Data;
using FarmerAppithoneSensor.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FarmerAppithoneSensor.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class TempretureController : ControllerBase
	{
		private readonly FarmerDbcontext _dbcontext;
        public TempretureController(FarmerDbcontext dbcontext)
        {
			_dbcontext = dbcontext;
        }

		[HttpGet]
		[Route("Get")]
		public IActionResult GetTemp()
		{
			IEnumerable<Tempreture> templist = _dbcontext.tempretures.ToList();
			return Ok(templist);
		}


		[HttpGet]
		[Route("Getone/{id:int}")]
		public IActionResult GetOneTemp([FromRoute]int? id)
		{
			Tempreture onetemp = _dbcontext.tempretures.Where(t => t.Id == id).FirstOrDefault();
			if (onetemp == null)
				return BadRequest();

			return Ok(onetemp);
		}



		//[HttpPost]
		////[Route("Post")]
		//public int PostTempbyval([FromBody]int val )
		//{
		//	Tempreture temp = new Tempreture();
		//	if (ModelState.IsValid == true)
		//	{
		//		temp.Value = val;
		//		_dbcontext.tempretures.Add(temp);
		//		_dbcontext.SaveChanges();
		//		//return Ok("saved");
		//		return val;	
		//	}
		//	//return BadRequest(temp);
		//	return -1;
		//}
		[HttpPost]
		[Route("Post")]
		public IActionResult PostTempbyobject( Tempreture temp)
		{
			if (ModelState.IsValid == true)
			{
				_dbcontext.tempretures.Add(temp);
				_dbcontext.SaveChanges();
				return Ok("saved");
			}
			return BadRequest(temp);
		}
	}
}
