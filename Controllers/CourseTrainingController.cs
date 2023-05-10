using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiTrainingDetail.Models;
using WebApiTrainingDetail.Repository;

namespace WebApiTrainingDetail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseTrainingController : ControllerBase
    {
        private readonly ITrainingDetail iTer;
        public CourseTrainingController(ITrainingDetail s)
        {
            this.iTer = s;  
        }
        [HttpGet]
        [Route("courseStudent")]
        public async Task<IActionResult> Get()
        {
           
              return Ok(iTer.GetCourses());
           
        }
        [HttpGet]
        [Route("Course")]
        public async Task<IActionResult> GetC()
        {

            return Ok(iTer.GetStuCourses());

        }
        [HttpPost, Authorize(Roles = "Teacher,teacher")]
        [AllowAnonymous]
        public async Task<IActionResult> AddCoourse(TrainingCourse tc)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized("You are Not authorized");
            }

            return Ok(iTer.AddCoourse(tc));

        }
        [HttpPut("{id}"), Authorize(Roles = "Teacher,teacher")]
        [AllowAnonymous]

        public async Task<IActionResult> UpdateCoourse(TrainingCourse tc,int id)
        {
            return Ok(iTer.UpdateCoourse(tc, id));
        }
        [HttpDelete("{id}"), Authorize(Roles = "Teacher,teacher")]
        [AllowAnonymous]
        public async Task<IActionResult> Delete(int id)
        {
            if (!User.Identity.IsAuthenticated)
            {
                return Unauthorized("You are Not authorized");
            }
            return Ok(iTer.DeleteCourese(id));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetC(int id)
        {
            return Ok(iTer.GetCourse(id));
        }

        
    }
}
