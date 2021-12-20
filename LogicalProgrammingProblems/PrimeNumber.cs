using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingProblems
{
    class PrimeNumber
    {
        //Fields
        int number;

        //Constructor
        public PrimeNumber(int NUMBER)
        {
            this.number = NUMBER;
        }

        //Method
        public int PrimeNumberMethod()
        {
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"{ number } is not a prime number ");
                    break;
                }
                else
                {
                    Console.WriteLine($"{ number } is a prime number ");
                    break;
                }
            }
            return number;
        }


    }

}
