using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxiifinal
{
    internal class taxigas
    {

        public string DriveName { get; set; }
        public Boolean OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void info()
        {
            Console.WriteLine("\n Taxi Info \n");
            Console.WriteLine("Nama Driver : {0}", DriveName);

            if (OnDuty == true)
            {
                Console.WriteLine("Kerja : Iya ", OnDuty);

            }
            else
            {
                Console.WriteLine("Kerja : Tidak", OnDuty);
            }
            Console.WriteLine("Nomor Pelanggan : {0}", NumPassenger);

        }
        public void up()
        {
            Console.WriteLine("\n {0} Sedang Menaikkan Penumpang", DriveName);
        }
        public void down()
        {
            Console.WriteLine("\n {0} Sedang Menurunkan Penumpang", DriveName);
        }
    }
}
