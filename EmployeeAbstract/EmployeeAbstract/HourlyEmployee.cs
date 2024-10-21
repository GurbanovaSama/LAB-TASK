using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAbstract
{
    internal class HourlyEmployee : Employee
    {
       public double HourlyRate { get; set; }
       public double HoursWorked { get; set; }


        public override double CalculateSalary()
        {
           return HoursWorked * HourlyRate;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Id: {Id}, Name:{Name}, surname: {Surname}, age: {Age} ");
            Console.WriteLine($"Hours Worked: {HoursWorked}, Hourly Rate: {HourlyRate}");
            Console.WriteLine($"Slary: {CalculateSalary()}");
        }

        
         
        

        public HourlyEmployee(string? name, string? surname, int age, double hourlyRate, double hoursWorked)
        {
            Name = name;
            Surname = surname;
            Age = age;
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
        }
    }
}
