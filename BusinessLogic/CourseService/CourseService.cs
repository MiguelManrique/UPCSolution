using DataAccess.CourseRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.CourseService
{
    public class CourseService : ICourseService
    {
        public void InsertCourse(Entities.Cours objCourse)
        {
            ICourseRepository repository = new CourseRepository();
            repository.InsertCourse(objCourse);
        }

        public void UpdateCourse(Entities.Cours objCourse)
        {
            ICourseRepository repository = new CourseRepository();
            repository.UpdateCourse(objCourse);
        }

        public void DeleteCourse(int courseId)
        {
            ICourseRepository repository = new CourseRepository();
            repository.DeleteCourse(courseId);
        }

        public Entities.Cours GetCourseById(int courseId)
        {
            ICourseRepository repository = new CourseRepository();
            return repository.GetCourseById(courseId);
        }

        public List<Entities.Cours> GetAllCourses()
        {
            ICourseRepository repository = new CourseRepository();
            return repository.GetAllCourses();
        }
    }
}
