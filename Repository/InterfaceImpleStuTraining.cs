using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiTrainingDetail.Models;

namespace WebApiTrainingDetail.Repository
{
    public class InterfaceImpleStuTraining:ITrainingDetail
    {
        private readonly StudentTrainingDbContext stDb;
        public InterfaceImpleStuTraining(StudentTrainingDbContext s)
        {
            this.stDb = s;  
        }
        public  IEnumerable<TrainingCourse> GetCourses()
        {
            var stuCor =   stDb.Trainings.Include(p => p.Student).ToList();
            return (stuCor);
        }
        public IEnumerable<TrainingCourse> GetStuCourses()
        {
            var stuCor = stDb.Trainings.ToList();
            return (stuCor);
        }
        public TrainingCourse AddCoourse(TrainingCourse tc)
        {
            var course = new TrainingCourse()
            {
                CName = tc.CName,
                CourseEnd = tc.CourseEnd,
                CourseStart = tc.CourseStart,
                TrainingDuration = tc.TrainingDuration,
                TrainerName = tc.TrainerName,

            };
            stDb.Trainings.Add(course);
            stDb.SaveChanges();
            return course;

        }
        public TrainingCourse UpdateCoourse(TrainingCourse tc, int id)
        {
            var Course =  stDb.Trainings.Find(id);
           
                Course.CName = tc.CName;
                Course.CourseEnd = tc.CourseEnd;
                Course.CourseStart = tc.CourseStart;
                Course.TrainingDuration = tc.TrainingDuration;
                Course.TrainerName = tc.TrainerName;
                stDb.Trainings.Update(Course);
                stDb.SaveChanges();
            return (Course);  
        }
        public TrainingCourse DeleteCourese(int id)
        {
            var cour=stDb.Trainings.Find(id);
            stDb.Remove(cour);
            stDb.SaveChanges();
            return cour;
        }
        public TrainingCourse GetCourse(int id)
        {
            var course= stDb.Trainings.Find(id);
            return course;
        }
        public  IEnumerable<Student> Getstudents()
        {
            var student =  stDb.Students.ToList();

          
            return student;
        }
        public IEnumerable<Student> GetCourseStu()
        {
            return stDb.Students.Include(s => s.Courses).ToList();
        }
        public Student AddStudent(Student s)
        {
            stDb.Students.Add(s);
            stDb.SaveChanges ();    
            return (s);
        }
        public Student UpdateStudent(Student s, int id)
        {
            var stud=stDb.Students.Find(id);
            if (stud!= null)
            {
               stDb.Update(stud);
               stDb.SaveChanges();
            }
            return (s); 
        }
        public Student DeleteStudent(int id)
        {
            var stud= stDb.Students.Find(id);   
            stDb.Students.Remove(stud);
            stDb.SaveChanges();
            return stud;
        }
        public Student GetStudent(int id)
        {
            var stud = stDb.Students.Find(id);
            return stud;
        }




    }
}
