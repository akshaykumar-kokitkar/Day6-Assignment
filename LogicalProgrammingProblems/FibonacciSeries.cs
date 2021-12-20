using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgrammingProblems
{
    class FibonacciSeries
    {
        //fields

        int n1 = 0;
        int n2 = 1;
        int n3;
        int number;

        //constructor
        public FibonacciSeries(int NUMBER)
        {

            this.number = NUMBER;

        }
        public void FibonacciMethod()
        {
            Console.Write(n1 + " " + n2 + " ");
            for (int i = 2; i < number; ++i)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;


            }
        }
    }
}
