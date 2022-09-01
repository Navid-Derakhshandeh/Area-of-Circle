//Navid-Derakhshandeh
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Circle
{
    class Program : Circle
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo conkey;
            do
            {
                Program prog = new Program();
                Console.WriteLine("Please Enter the Radius of Your Circle");
                double R = Double.Parse(Console.ReadLine());

                double circlearea = prog.Area(3.14159265359, R);
                Console.WriteLine("Area of Your Circle Equal by {0}.", circlearea);
                conkey = Console.ReadKey();
            } while (conkey.Key != ConsoleKey.Escape);
        }
    }
}
