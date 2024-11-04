using HospitalManagement.Exceptions;
using HospitalManagement.Models;
using HospitalManagement.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HospitalManagement.Services.Concretes
{
    public class AppointmentService : IAppointmentService
    {
        private readonly List<Appointment> _appointments;
        public AppointmentService()
        {
            _appointments = [];  //new List<Appointment>()
        }

        public void AddAppointment(Appointment appointment)
        {
            _appointments.Add(appointment);
            Console.WriteLine("Ugurla elave edildi");
        }

        public void EndAppointment(int id)
        {
           var appointment = _appointments.FirstOrDefault(x => x.Id == id);
            if (appointment != null)
            {
                appointment.EndDate = DateTime.Now;
                Console.WriteLine($"Bu id-e {id} uygun appointment sonlandirildi");
                return;
            }

            throw new AppointmentException($"Bu id-e{id} uygun Appointment tapilmadi");
        }

        public List<Appointment> GetAllAppointments()
        {
           return _appointments;
        }

        public List<Appointment> GetAllContinuingAppointments()
        {
           return _appointments.Where(x => x.EndDate == null).ToList();
        }

        public Appointment GetAppointment(int id)
        {
           return _appointments.FirstOrDefault(x => x.Id == id);    
        }

        public List<Appointment> GetTodayAppointments()
        {
           DateTime today = DateTime.Now;   
           return _appointments.Where(x => x.StartDate == today).ToList();
        }

        public List<Appointment> GetWeeklyAppointments()
        {
            //DateTime startDate = new DateTime(2024, 11, 1);
            //List<Appointment> response = [];
            //DateTime date = DateTime.Now;
            //DateTime newDate = date.AddDays(-15);
            //if(newDate <= startDate && date >= startDate)
            //{
            //    Console.WriteLine("15 gunluk raporlar");
            //}
            //Console.WriteLine($"{date.Day} / {date.Month} / {date.Year}");



            List<Appointment> weeklyAppoinments = [];
            foreach (Appointment appointment in _appointments)
            {
                if (appointment.StartDate >= DateTime.Now.AddDays(-15) && DateTime.Now >= appointment.StartDate )
                {
                    weeklyAppoinments.Add( appointment );
                }
               
            }

          
            return weeklyAppoinments;
        }
    }
}
