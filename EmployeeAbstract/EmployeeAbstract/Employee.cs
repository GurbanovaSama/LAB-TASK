using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAbstract
{
    internal abstract class Employee
    {
        private static int counter;
        public int Id { get; init; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }


        public Employee()
        {
            Id = counter;
            counter++;
        }

        public abstract double CalculateSalary();
        public abstract void DisplayDetails();
    }
}
