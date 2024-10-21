namespace EmployeeAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hourly Employee details");
            Console.Write("Enter the name");
            string Name = Console.ReadLine();
            Console.Write("Enter the surname");
            string Surname = Console.ReadLine();
            Console.Write("Enter the age");
            int Age = int.Parse(Console.ReadLine());
            Console.Write("Enter the houtly rate");
            double hourlyRate = double.Parse(Console.ReadLine());
            Console.Write("Enter the hours worked");
            double hoursWorked = double.Parse(Console.ReadLine());

            HourlyEmployee hourlyEmployee = new(Name, Surname, Age, hourlyRate, hoursWorked);
            hourlyEmployee.DisplayDetails();
           

            Console.WriteLine("Salaried Employee details");
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Surname:");
            string surname = Console.ReadLine();
            Console.Write("Age:");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Mothly salary:");
            double monthlySalary = double.Parse(Console.ReadLine());

            SalariedEmployee salariedEmployee = new(name, surname, age, monthlySalary);
            salariedEmployee.DisplayDetails();
        }
    }
}
