using AcademyManagement.Interface;
using AcademyManagement.Models;
using System.ComponentModel.DataAnnotations;

namespace AcademyManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            StudentService studentService = new StudentService(new Student[] {});

            Student student1 = new Student("Xeyale", "Ismayilova", "xeyale@ismyilova", " 0701234567", 4.1, "Active", "Doctor");
            studentService.AddStudent(student1);
            Student student2 = new Student("Ferid", "Ismayilov", "ferid@ismyilov", " 055556422", 3.6, "Active", "Engineer");
            studentService.AddStudent(student2);

            DisplayAllStudents(studentService);

            Console.WriteLine("(Ferid");


            studentService.UpdateStudent(1, new Student("Ferid", "Ismayilov", "ferid@ismyilov", " 055556422", 3.6, "Active", "Engineer"));

            Console.WriteLine("yenilenmis melumatlar");
          

            studentService.RemoveStudent(2, true);
            Console.WriteLine("Telebenin son siyahisi");
            DisplayAllStudents(studentService);
       
        }

       

        private static void DisplayAllStudents(StudentService studentService)
        {
        } 
        void DisplayStudents(Student[] students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Id}, {student.FirstName}, {student.LastName}, {student.Major}, {student.Email}, {student.GPA}, {student.Status} ");
            }
        }

        void DisplayStudent(Student student)
        {
            if ( student == null)
            {
                Console.WriteLine($"{student.Id}, {student.FirstName}, {student.LastName}, {student.Major}, {student.Email}, {student.GPA}, {student.Status} ");
            }
            else
            {
                Console.WriteLine("telebe yoxdur");
            }
        }

    }

   
}
