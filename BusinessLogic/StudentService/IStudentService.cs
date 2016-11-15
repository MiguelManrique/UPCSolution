using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.StudentService
{
    public interface IStudentService
    {
        void InsertStudent(Student student);
        void UpdateStudent(Student student);
        Student GetStudent(int studentId);
        List<Student> GetAllStudents();
    }
}
