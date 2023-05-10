using Microsoft.AspNetCore.Mvc;
using WebApiTrainingDetail.Models;

namespace WebApiTrainingDetail.Repository
{
    public interface ITrainingDetail
    {
        IEnumerable<TrainingCourse> GetCourses();
        IEnumerable<TrainingCourse> GetStuCourses();
        TrainingCourse AddCoourse(TrainingCourse tc);
        TrainingCourse UpdateCoourse(TrainingCourse tc, int id);
        TrainingCourse DeleteCourese(int id);
        TrainingCourse GetCourse(int id);
        IEnumerable<Student> Getstudents();
        IEnumerable<Student> GetCourseStu();
        Student AddStudent(Student s);
        Student UpdateStudent(Student s, int id);
        Student DeleteStudent(int id);
        Student GetStudent(int id);

    }
}
