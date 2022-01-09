using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthSalary
{
    class Program
    {
        private static bool salary;

        static void Main(string[] args)
        {
            int hours = 8;

            int days = 25;

            double payment = 89.4;

            double total = days * hours * payment;

            Console.WriteLine("salary :"+total);
        }
    }
}

