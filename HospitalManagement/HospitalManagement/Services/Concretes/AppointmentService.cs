using HospitalManagement.Models;
using HospitalManagement.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Services.Concretes
{
    public class AppointmentService : IAppointmentService
    {
        private List<Appointment> _appointments = new List<Appointment>();
     
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
                Console.WriteLine("Bitdi");
            } 
            else
            {
                Console.WriteLine("Appointment tapilmadi");
            }
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
           DateTime today = DateTime.Now;
           DateTime startOfWeek = today.AddDays(-(int)today.DayOfWeek);
           return _appointments.Where(x => x.StartDate >= startOfWeek && x.StartDate < startOfWeek.AddDays(7)).ToList();
        }
    }
}
