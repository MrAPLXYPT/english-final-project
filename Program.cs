using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int lingkaran, segitiga, persegi_panjang, panjang,lebar,tinggi;
            Console.WriteLine("1 = persegi panjang");
            Console.WriteLine("2 = segitiga ");
            Console.WriteLine("3 = lingkaran");
            Console.Write("pilih bangun datar : ");
            a = int.Parse(Console.ReadLine());
            if (a == 1 )
            {
                Console.Write("masukkan panjang : ");
                panjang = int.Parse(Console.ReadLine());                                                                                                                                                                                                                       
                Console.Write("masukkan lebar : ");
                lebar = int.Parse(Console.ReadLine());
                persegi_panjang = panjang * lebar;
                Console.WriteLine("Luas = " + persegi_panjang);
            }
            if(a == 2)
            {
                Console.Write("masukkan alas :");
                panjang = int.Parse(Console.ReadLine());
                Console.Write("masukkan tinggi : ");
                lebar = int.Parse(Console.ReadLine());
                segitiga = panjang * lebar /2;
                Console.Write("Luas = " + segitiga);
            }
            if(a == 3) {
                Console.Write("masukkan jari-jari :");
                panjang = int.Parse(Console.ReadLine());
                lingkaran =  panjang * panjang * 22 / 7 ;
                Console.WriteLine("Luas = " + lingkaran);
            }


            Console.ReadKey();
        }
    }
}
