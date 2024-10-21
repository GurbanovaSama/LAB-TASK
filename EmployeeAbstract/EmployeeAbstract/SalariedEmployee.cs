using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAbstract
{
    internal class SalariedEmployee : Employee
    {
        public SalariedEmployee(string? name, string? surname, int age, double monthlySalary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            MonthlySalary = monthlySalary;
        }

        public double MouthlySalary { get; set; }
        public double MonthlySalary { get; }

        public override double CalculateSalary()
        {
            return MouthlySalary;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine($"{Name}, {Surname}, age:{Age}, Id: {Id}");
            //Console.WriteLine($"Hours Worked:{HoursWorked}, Hourly Rate: {HourlyRate}");
            Console.WriteLine($"Salary: {CalculateSalary()}");
        }
    }
}
