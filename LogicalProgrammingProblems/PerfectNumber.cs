using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingProblems
{
     class PerfectNumber
    {
        //Feilds
        int number;
        int sum = 0;

        //Constructor
        public PerfectNumber(int NUMBER)
        {
            this.number = NUMBER;
        }

        //Method
        public int PerfectNumberMethod()
        {

            for (int i = 1; i < number; i++) // find out Proper Divisor
            {
                if (number % i == 0)
                {
                    sum += i; //do Addition 
                }
            }
            if (sum == number)
            {
                Console.WriteLine($"{ number } is a perfect number ");
            }
            else
            {
                Console.WriteLine($"{ number } is not a perfect number ");
            }
            return number;
        }
    }

}
