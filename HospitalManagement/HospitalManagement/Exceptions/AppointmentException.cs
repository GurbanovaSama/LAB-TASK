using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.Exceptions
{
    public class AppointmentException : Exception
    {
        public AppointmentException() : base("It is default exception message")
        {
            
        }
        public AppointmentException(string message) : base(message) 
        {
            
        }
    }
}
