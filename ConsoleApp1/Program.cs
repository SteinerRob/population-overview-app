using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = new DateTime(1995, 5, 25);
            Console.WriteLine(time.ToShortDateString());
        }
    }
}
