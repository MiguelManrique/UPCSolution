using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.StudentRepository
{
    public interface IStudentRepository
    {
        void InsertStudent(Student student);
        void UpdateStudent(Student student);
        Student GetStudent(int studentId);
        List<Student> GetAllStudent();
    }
}
