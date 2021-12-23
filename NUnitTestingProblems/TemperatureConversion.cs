using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingProblems
{
    class TemperatureConversion
    {
        public int input;
        public int option;
        public int result;

        public void SolutionForConversion(int option, int input)
        {
            switch (option)
            {
                case 1:
                    result = (input * 9 / 5) + 32;
                    Console.WriteLine(input + "Celsius to fahrenheit is " + result);
                    break;
                case 2:
                    result = (input - 32) * 5 / 9;
                    Console.WriteLine(input + " fahrenheit to celsius is " + result);
                    break;
                default:
                    Console.WriteLine("wrong option");
                    break;
            }

        }
    }


}
