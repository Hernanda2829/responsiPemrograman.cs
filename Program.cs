using System;

namespace ResponsiPemograman2761
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nama : hernanda giri");
            Console.WriteLine("NIM : 19.11.2761");
            Console.WriteLine("");

            Karyawan karyawan1 = new Karyawan();
            Karyawan karyawan2 = new Karyawan();
            Karyawan karyawan3 = new Karyawan();

            karyawan1.NO = 1;
            karyawan1.NIK = 19112761;
            karyawan1.NAMA = "hernanda";
            karyawan1.GAJI = 3000000;

            karyawan2.NO = 2;
            karyawan2.NIK = 19112762;
            karyawan2.NAMA = "giri";
            karyawan2.GAJI = 2000000;

            karyawan3.NO = 3;
            karyawan3.NIK = 19112763;
            karyawan3.NAMA = "pramudita";
            karyawan3.GAJI = -10;

            Console.WriteLine("No /     NIK/NAMA/GAJI");
            Console.WriteLine("-----------------------");
            karyawan1.InfoKaryawan();
            karyawan2.InfoKaryawan();
            karyawan3.InfoKaryawan();
            Console.WriteLine("");
            Console.WriteLine("Mantap dapat kenaikan gai 10%");
            Console.WriteLine("");
            Console.WriteLine("No /     NIK/NAMA/GAJI");
            Console.WriteLine("------------------------");
            karyawan1.BonusGaji();
            karyawan2.BonusGaji();
            karyawan3.BonusGaji();
        }
        public class Karyawan
        {
            public int NO { get; set; }
            public int NIK { get; set; }
            public string NAMA { get; set; }
            public int GAJI { get; set; }

            public void InfoKaryawan()
            {
                if (GAJI < 0)
                {
                    GAJI = 0;
                }

                Console.WriteLine("{0}  /{1}/{2}/{3}", NO, NIK, NAMA, GAJI);
            }
            public void BonusGaji()
            {
                if (GAJI < 0)
                {
                    GAJI = 0;
                }
                Console.WriteLine("{0}  /{1}/{2}/{3}", NO, NIK, NAMA, GAJI*0.1+GAJI);
            }
        }
    }
}
