using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTrainingDetail.Models;
using WebApiTrainingDetail.Repository;

namespace WebApiTrainingDetail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly ITrainingDetail iTor;
        public StudentController(ITrainingDetail it)
        {
            iTor = it;
        }

        [HttpGet]
        [Route("Students")]
        public async Task<IActionResult> Get()
        {
            return Ok(iTor.Getstudents());
        }
        [HttpGet]
        [Route("StudentCourse")]
        public async Task<IActionResult> Getstucourse()
        {
            return Ok(iTor.GetCourseStu());
        }
        [HttpPost,Authorize(Roles ="Teacher,teacher")]
        [AllowAnonymous]

        public async Task<IActionResult> AddStud(Student s)
        {
            return Ok(iTor.AddStudent(s));
        }
        [HttpPut("{id}"), Authorize(Roles = "Teacher,teacher")]
        [AllowAnonymous]

        public async Task<IActionResult> UpdateStud(Student s, int id)
        {
            return Ok(iTor.UpdateStudent(s, id));
        }
        [HttpDelete, Authorize(Roles = "Teacher,teacher")]
        [AllowAnonymous]

        public async Task<IActionResult> Delete(int id)
        {
            return Ok(iTor.DeleteStudent(id));
        }
        [HttpGet("{id}")]
        public async  Task<IActionResult> Get(int id)
        {
            return Ok(iTor.GetStudent(id));
        }
    }
}



