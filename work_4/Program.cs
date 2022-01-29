using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> AdYas = new MyDictionary<string, int>();
            AdYas.Add("Ahmet", 32);
            AdYas.Add("Ceren", 28);
            AdYas.Add("Fatih", 30);
            AdYas.Add("Merve", 24);


            AdYas.Print();
            Console.WriteLine(AdYas.length);
        }
    }
}
