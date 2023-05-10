using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiTrainingDetail.Models;

namespace WebApiTrainingDetail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataFetchController : ControllerBase
    {
        private readonly StudentTrainingDbContext stdb;
        public DataFetchController(StudentTrainingDbContext s)
        {
            stdb = s;
        }
        [HttpGet("maxMarks")]
        public async Task<ActionResult> Get()
        {
            var max = stdb.Students.Max(s => s.Marks);
            var student =from s in stdb.Students where s.Marks==max select s;
            return Ok(student);
        }
        
    }
}
