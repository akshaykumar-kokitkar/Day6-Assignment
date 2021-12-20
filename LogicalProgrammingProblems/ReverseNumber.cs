using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingProblems
{
    class ReverseNumber
    {
        //fields
        int number;
        int reverse = 0;

        //constructr
        public ReverseNumber(int NUMBER)
        {
            this.number = NUMBER;
        }

        //metthod
        public void ReverseANumber()
        {
            while (number > 0)
            {
                int remainder = number % 10; //save remainder
                reverse = (reverse * 10) + remainder; // save next Number
                number = number / 10;
            }
            Console.WriteLine("Reverse number is {0}", reverse);
        }
    }
}
