using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            //day of week
            /*
            Console.WriteLine("Enter Year of birthday");
            int year = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter month of birthday");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Date of birthday Now");
            int day = Convert.ToInt32(Console.ReadLine());

            DayOfWeek p1 = new DayOfWeek(year, month, day);
            p1.DayOfWeekMethod();
            */


            //Temperature Conversation
            
            Console.WriteLine("Enter Option1: to convert celsious to fahrenheit\n Option2: to convert fahrenheit to celsious ");
            int option = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value to convert: ");
            int input = Convert.ToInt32(Console.ReadLine());
            TemperatureConversion p2 = new TemperatureConversion();
            p2.SolutionForConversion(option, input);
            


            //mothly payments
            /*
            Console.WriteLine("Enter amount of Loan");
            int LoanAmount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount Percentage Rate");
            double PercRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter No of year you want to pay");
            int year = Convert.ToInt32(Console.ReadLine());
            //MonthlyPayments p3 = new MonthlyPayments();
            MonthlyPayments.Solution(LoanAmount, PercRate, year);
            */
           
        }
    }
}
