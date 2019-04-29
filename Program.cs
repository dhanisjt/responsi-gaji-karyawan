using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace responsi
{
    class Program
    {
        static void Main(string[] args)
        {
            karyawan krywn = new karyawan();

            krywn.nama = "Dhani";
            krywn.nik = "2351";
            krywn.gaji = 1000000;

            krywn.nama2 = "Andyan";
            krywn.nik2 = "2323";
            krywn.gaji2 = 2000000;

            krywn.infoGaji();
            Console.WriteLine();
            krywn.kenaikanGaji();
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}

