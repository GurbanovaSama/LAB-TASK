using HospitalManagement.Models;
using HospitalManagement.Services.Concretes;
using HospitalManagement.Services.Interfaces;

namespace HospitalManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
           IAppointmentService appointmentService = new AppointmentService();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Appointment yarat:");
                Console.WriteLine("2. Appointmenti bitir:");
                Console.WriteLine("3. Butun appointmentlere bax:");
                Console.WriteLine("4. Bu hefteki appointmentlere bax:");
                Console.WriteLine("5. Bugunki appointmentlere bax:");
                Console.WriteLine("6. Bitmemis appointmenlere bax:");
                Console.WriteLine("7. Menudan cix:");
                Console.Write("Seciminizi daxil edin:");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Id daxil et");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Patient name daxil et");
                        string patientName = Console.ReadLine();
                        Console.Write("Doctor name daxil et");
                        string doctorName = Console.ReadLine();
                        Console.Write("Start date daxil et ");
                        DateTime startDate = DateTime.Parse(Console.ReadLine());

                        var appointment = new Appointment
                        {
                            Id = id,
                            PatientName = patientName,
                            DoctorName = doctorName,
                            StartDate = startDate,
                        };
                        appointmentService.AddAppointment(appointment); 
                        break;

                    case "2":
                        Console.Write("Id daxil et");
                        int endId = int.Parse(Console.ReadLine());  
                        appointmentService.EndAppointment(endId);
                        break;

                    case "3":
                        var allAppointments = appointmentService.GetAllAppointments();  
                        foreach(var item  in allAppointments)
                        {
                            Console.WriteLine($" {item.Id}, {item.PatientName}, {item.DoctorName}, {item.StartDate}, {item.EndDate}");                           
                        }
                        break;

                    case "4":
                        var weeklyAppointments = appointmentService.GetWeeklyAppointments();    
                        foreach ( var item in weeklyAppointments)
                        {
                            Console.WriteLine($"{item.Id} , {item.PatientName}, {item.DoctorName}, {item.StartDate}");
                        }
                        break;

                    case "5":
                        var todayAppointments = appointmentService.GetTodayAppointments();
                        foreach ( var item in todayAppointments)
                        {
                            Console.WriteLine($"{item.Id} , {item.PatientName}, {item.DoctorName}, {item.StartDate}");
                        }
                        break;

                    case "6":
                        var continuingAppointments = appointmentService.GetAllContinuingAppointments();
                        foreach (var item in continuingAppointments)
                        {
                            Console.WriteLine($"{ item.Id} , { item.PatientName}, { item.DoctorName}, { item.StartDate}");
                        }
                        break;

                    case "7":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Secim yanlisdir");
                        break;
                }




            }
        }
    }
}
