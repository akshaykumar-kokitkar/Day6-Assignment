using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestingProblems
{

    class DayOfWeek
    {
        int year;
        int month;
        int day;

        //Constructor

        public DayOfWeek(int DAY, int MONTH, int YEAR)
        {
            this.day = DAY;
            this.month = MONTH;
            this.year = YEAR;
        }

        public void DayOfWeekMethod()
        {
            /*y0 = y − (14 − m) / 12
            x = y0 + y0/4 − y0/100 + y0/400
            m0 = m + 12 × ((14 − m) / 12) − 2
            d0 = (d + x + 31m0/ 12) mod 7 
             */

            int x = 0;
            int y0 = 0;
            int m0 = 0;
            int d0;
            y0 = year - (14 - month) / 12;

            x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);

            m0 = (month + 12) * ((14 - month) / 12) - 2;

            d0 = (day + x + 31 * m0 / 12) % 7;

            //d0 = d0 + 2; //Adjustment

            Console.WriteLine(d0);

            switch (d0)
            {
                case 0:
                    Console.WriteLine(" sunday");
                    break;
                case 1:
                    Console.WriteLine(" monday");
                    break;
                case 2:
                    Console.WriteLine(" Tuesday");
                    break;
                case 3:
                    Console.WriteLine(" Wednesday");
                    break;
                case 4:
                    Console.WriteLine(" Thrusday");
                    break;
                case 5:
                    Console.WriteLine(" Friday");
                    break;
                case 6:
                    Console.WriteLine(" Satarday");
                    break;
            }


        }

    }
}
