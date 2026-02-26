using Microsoft.AspNetCore.Mvc;
using TeachersAPI.Models;
 
 namespace TeachersAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeachersController : ControllerBase
    {
        public static List<Teachers> Teachers = new List<Teachers>
        {
            new Teachers{age= 20, name="Wishenga Natal", email="wishenganatal@gmail.com" } ,
            new Teachers {age= 26, name = "Anita Leila", email= "anitaleila@gmail.com"}
        };
        [HttpGet]
        public IActionResult GetTeachers()
        {
            return Ok(Teachers);
        }

        [HttpPost]
        public IActionResult AddTeachers(Teachers newTeachers)
        {
            Teachers.Add(newTeachers);
            return Ok(newTeachers);
        }


    }

}