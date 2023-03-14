using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Myname = "Max";
            byte MyAge = 19;
            bool HaveIApet = true;
            double MyShoeSize = 38.5;

            Console.WriteLine("My name is " + Myname);
            Console.WriteLine("MyAge " + MyAge);
            Console.WriteLine("Do I have a pet? " + HaveIApet);
            Console.WriteLine("My shoe size is " + MyShoeSize);
            Console.ReadKey();
        }
    }
}
