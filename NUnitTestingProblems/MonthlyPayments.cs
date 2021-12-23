using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace NUnitTestingProblems
{
    class MonthlyPayments
    {
        public static int LoanAmount;
        public static double PercRate;
        public  int year;
        public double Pays;

        public static void Solution(int LoanAmount, double PercRate, int year)
        {
            int r = Convert.ToInt32(PercRate / (12 * 100));
            double Power = Convert.ToInt32(1 - Math.Pow((1 + r), -12));
            double Pays = LoanAmount * r / Power;
            Console.WriteLine("Monthly Payment of {0}", +Pays);
        }
    }
}
