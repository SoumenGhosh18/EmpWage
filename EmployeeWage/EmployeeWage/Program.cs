using System;
using System.Net.Http.Headers;

namespace EmployeeWage
{
    class Program
    {
        const int IS_Full_TIME = 1;
        static void Main(string[] args)
        {
            Random r = new Random();
            int number = r.Next(2);
            if ( number == IS_Full_TIME)
                Console.WriteLine("The employee is present");
            else
                Console.WriteLine("The employee is absent");
        }
    }
}