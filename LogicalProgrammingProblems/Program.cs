namespace LogicalProgrammingProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci series

            Console.WriteLine("Enter number to print fibonacci series");
            int number = Convert.ToInt32(Console.ReadLine());
            FibonacciSeries p1 = new FibonacciSeries(number);
            p1.FibonacciMethod();

            //Perfect Number

            /*Console.Write("Enter the Number to check prfect number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            PerfectNumber p2 = new PerfectNumber(number);
            p2.PerfectNumberMethod();*/

            //prime numbers

            /*Console.Write("Enter the Number to check Prime: ");
            int number = Convert.ToInt32(Console.ReadLine());
            PrimeNumber p3 = new PrimeNumber(number);
            p3.PrimeNumberMethod();*/

            //reverse a number

            /*Console.Write("Enter the Number to reverse ");
            int number = Convert.ToInt32(Console.ReadLine());
            ReverseNumber p4 = new ReverseNumber(number);
            p4.ReverseANumber();*/

            //Stopwatch


        }
    }
}