using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car mercedes = new Car();
            mercedes.ShowInfo();
            mercedes.Drive();
        }
    }
}
