using System.ComponentModel.DataAnnotations;

namespace WebApiTrainingDetail.Models
{
    public class TrainingCourse
    {
        [Key]
        public int CId { get; set; }
        public string ?CName { get; set; }
        public string? TrainerName { get; set; } 
        public int ?TrainingDuration { get; set; }   
        public DateTime ?CourseStart { get; set; }
        public DateTime ?CourseEnd { get; set; }
        public ICollection<Student>? Student { get; set; }

    }
}
