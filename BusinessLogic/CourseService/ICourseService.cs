using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.CourseService
{
    public interface ICourseService
    {
        void InsertCourse(Cours objCourse);
        void UpdateCourse(Cours objCourse);
        void DeleteCourse(int courseId);
        Cours GetCourseById(int courseId);
        List<Cours> GetAllCourses();
    }
}
