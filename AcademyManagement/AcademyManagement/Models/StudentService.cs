using AcademyManagement.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Models
{
    public class StudentService : IStudentService
    {
        private Student[] _students;
        private int _nextId;
       

        public StudentService(Student[] students)
        {
            _students = students;
            _nextId = 1;
        }

        public StudentService()
        {
        }

        public Student GetStudentById(int id)
        {
            for ( int i = 0; i < _students.Length; i++)
            {
                if (_students[i].Id == id)
                {
                    return _students[i];
                } 
            }
            return default;
        }

        public Student[] GetAllStudents()
        {
            return _students;
        }

        public Student[] GetStudentsByName(string name)
        {
           int count = 0;
            for (int i = 0; i < _students.Length; i++ )
            {
                if (_students[i].FirstName == name || _students[i].LastName == name)
                {
                    count++;
                }

            }
            Student[] found = new Student[count];
            int index = 0;
            for(int i = 0; i < _students.Length;i++)
            {
                if (_students[i].FirstName == name || _students[i].LastName == name)
                {
                    found[index] = _students[i];
                    index++;
                }
            }
            return found;
        }

        public void AddStudent(Student student)
        {
            student.Id = _nextId++;
            Student[] newArray = new Student[_students.Length + 1];

            for (int i = 0;i < _students.Length;i++)
            {
                newArray[i] = _students[i];
            }
            newArray[_students.Length] = student;
            _students = newArray;
        }

        public void RemoveStudent(int id, bool isSoftDelete)
        {
           for (int i = 0; i < _students.Length;i++)
            {
                if (_students[i].Id == id)
                {
                    if (isSoftDelete)
                    {
                        _students[i].Status = "Removed";
                    }
                    else
                    {
                        for (int j= i;  j < _students.Length;j++)
                        {
                            _students[j] = _students[j+1];
                        }
                        Array.Resize(ref _students, _students.Length - 1);
                    }
                    break;
                }
            }

        }

        public void UpdateStudent(int id, Student student)
        {
            for ( int i = 0; i < _students.Length;i++)
            {
                if (_students[i].Id == id)
                {
                    _students[i].FirstName = student.FirstName;
                    _students[i].LastName = student.LastName;
                    _students[i].Email = student.Email;
                    _students[i].PhoneNumber = student.PhoneNumber;
                    _students[i].GPA = student.GPA;
                    _students[i].Status = student.Status;
                    _students[i].Major = student.Major;
                    break;


                }
            }
        }
    }
}
