using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTrainingDetail.Models
{
    public class Student
    {
        [Key]
        public int Sid { get; set; }    
        public string? SName { get; set; }
        public string? SBatchName { get; set; }  
        public string? JoiningDate { get; set; } 
        public int? Marks { get; set; }  
        public int CourseId { get; set; }
        [ForeignKey("CourseId")]
        public TrainingCourse ?Courses { get; set; }

    }
}
