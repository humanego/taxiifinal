using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxiifinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            taxigas taxi = new taxigas();

            taxi.DriveName = "Ilham";
            taxi.OnDuty = true;
            taxi.NumPassenger = 84785478;

            taxi.info();
            taxi.up();
            taxi.down();

            Console.ReadLine();
        }
    }
}
