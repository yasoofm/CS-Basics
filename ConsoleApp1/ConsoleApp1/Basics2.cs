using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApp1
{
    internal class Basics2
    {
        private static void main(String[] args)
        {
            DateTime currentHour = DateTime.Now;
            WriteLine(currentHour);

            /*if(currentHour > 11 && currentHour < 14)
            {
                WriteLine("Time for lunch");
            }*/
        }
    }
}
