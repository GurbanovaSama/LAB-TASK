using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagement.Models
{
    public class Student
    {
        public int Id;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public double GPA { get; set; }
        public string Status { get; set; }
        public string Major {  get; set; }
        public int counter;


        public Student(string firstName, string lastName, string email, string phoneNumber, double gpa, string status, string major )
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            GPA = gpa;
            Status = status;
            Major = major;
            Id = counter;
            counter++;
            
        }
    }
    
}
