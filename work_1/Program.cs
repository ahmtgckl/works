using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir Sayı Giriniz.");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int i = 0;
            int toplam = 0;

            while (i <= sayi)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    toplam = toplam + i;
                }
                i++;
            }
            Console.WriteLine("Toplam : " + toplam);
        }
    }
}
