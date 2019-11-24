using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this system will calculate salary of employee!");
            Console.ReadLine();
            var Employee1=new SalaryCalculator( 1, "james", "section");
            Console.ReadLine();
            Console.WriteLine("your net salary: " + SalaryCalculator.CalculateSalary(500000));
            Console.WriteLine("your Hourly salary:"+SalaryCalculator.CalculateHourly(12, 34));
            Console.WriteLine("your Hourly salary:"+ SalaryCalculator.CalculateDaily(12));
        }
    }
}