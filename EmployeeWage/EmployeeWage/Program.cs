using System;
using System.Net.Http.Headers;

namespace EmployeeWage
{
    class Program
    {
        const int IS_Full_TIME = 1;
        static void Main(string[] args)
        {
            int EMP_RATE_PER_HOUR = 20;
            int empwage = 0;
            int emphrs = 8;

            Random r = new Random();
            int number = r.Next(2);
            if (number == IS_Full_TIME)
            {
                Console.WriteLine("The employee is present");
                empwage = emphrs* EMP_RATE_PER_HOUR;
                Console.WriteLine("DAily EMPWAGE.......=" + empwage);
            }
            else
                Console.WriteLine("The employee is absent");
        }
    }
}