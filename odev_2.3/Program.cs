using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odev_2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name,message=null;


            for (int i = 1; i <= 10; i++) 
            {
                Console.Write("İsim giriniz: ");
                name = Console.ReadLine();
                name = i+". " + name + "\n";
                message = message + name;
            }
            Console.Clear();
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
