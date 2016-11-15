using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.CourseRepository
{
    public class CourseRepository : ICourseRepository
    {
        public void InsertCourse(Entities.Cours objCourse)
        {
            using (var model = new UPCModelEntities())
            {
                model.Courses.Add(objCourse);
                model.SaveChanges();
            }
        }

        public void UpdateCourse(Cours objCourse)
        {
            using (var model = new UPCModelEntities())
            {
                var original = model.Courses.Find(objCourse.Id);

                if (original != null)
                {
                    model.Entry(original).CurrentValues.SetValues(objCourse);
                    model.SaveChanges();
                }
            }
        }

        public void DeleteCourse(int courseId)
        {
            using (var model = new UPCModelEntities())
            {
                Cours objCourse = model.Courses.Find(courseId);
                if(objCourse != null)
                {
                    model.Courses.Remove(objCourse);
                    model.SaveChanges();
                }
            }
        }

        public Cours GetCourseById(int courseId)
        {
            using (var model = new UPCModelEntities())
            {
                var course = from c in model.Courses
                             where c.Id == courseId
                             select c;
                return course.FirstOrDefault();
            }
        }

        public List<Cours> GetAllCourses()
        {
            using (var model = new UPCModelEntities())
            {

                var courses = from c in model.Courses.Include("Career")
                              select c;
                return courses.ToList();
            }
        }
    }
}
