using Microsoft.EntityFrameworkCore;

namespace WebApiTrainingDetail.Models
{
    public class StudentTrainingDbContext:DbContext
    {
        public StudentTrainingDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Student> Students { get; set; }    
        public DbSet<TrainingCourse> Trainings { get; set; }    
    }
}
