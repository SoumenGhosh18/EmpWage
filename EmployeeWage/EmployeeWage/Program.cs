using System;
using System.Net.Http.Headers;

namespace EmployeeWage
{
    class Program
    {
        const int IS_Full_TIME = 1;
        const int IS_PART_TIME = 2;
        static void Main(string[] args)
        {
            int EMP_RATE_PER_HOUR = 20;
            int empwage = 0;
            int emphrs = 8;

            Random r = new Random();
            int number = r.Next(3);
            if (number == IS_Full_TIME)
            {
                Console.WriteLine("The employee is present");
                empwage = emphrs* EMP_RATE_PER_HOUR;
                Console.WriteLine("DAily fulltime empwage.......=" + empwage);
            }
            else if (number == IS_PART_TIME)
            {
                emphrs = 4;
                empwage = emphrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("Daily parttime empwage.......=" + empwage);

            }
            else
                Console.WriteLine("The employee is absent");
        }
    }
}