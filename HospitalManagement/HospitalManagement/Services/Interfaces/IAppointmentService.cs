﻿using HospitalManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Services.Interfaces
{
    public interface IAppointmentService
    {
        void AddAppointment (Appointment appointment);
        void EndAppointment(int id);
        Appointment GetAppointment (int id);
        List<Appointment> GetAllAppointments ();
        List<Appointment> GetWeeklyAppointments ();
        List<Appointment> GetTodayAppointments ();
        List<Appointment> GetAllContinuingAppointments();
    }
}