using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayCalculator
{
    class Program
    {
        private bool thing;
        static void Main(string[] args)
        {
            double PayRate;
            double HoursWorked;
            double Result;
            double StandardWorkWeek = 50;
            double OverTimeMultiplier = 1.5;

            Console.WriteLine("Please enter your Pay Rate");
            PayRate = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your Hours Worked");
            HoursWorked = double.Parse(Console.ReadLine());

            if(HoursWorked > StandardWorkWeek)
            {
                double OverTimeHours = HoursWorked - StandardWorkWeek;
                double OverTimePayRate = PayRate * OverTimeMultiplier;
                double OverTimeTotalPay = OverTimeHours * OverTimePayRate;
                double TotalRegPay = StandardWorkWeek * PayRate;
                Result = TotalRegPay + OverTimeTotalPay;
            }
            else
            {
                Result = PayRate * HoursWorked;
            }
            Console.WriteLine("Your total pay was: " + Result);
            Console.ReadLine();
        }
    }
}
