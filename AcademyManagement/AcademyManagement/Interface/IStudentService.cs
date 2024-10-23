using AcademyManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Interface
{
    public interface IStudentService
    {
        Student GetStudentById(int id);
        Student[] GetAllStudents();
        Student[] GetStudentsByName(string name);
        void AddStudent(Student student);
        void UpdateStudent(int id, Student student);
        void RemoveStudent(int id, bool isSoftDelete);
    }
}
