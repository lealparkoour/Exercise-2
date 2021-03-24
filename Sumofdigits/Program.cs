using System;

namespace Sumofdigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int n ;
            Console.Write("enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Sum(n));
          

           

            static int  Sum (int n)
            {
                if (n == 0)
                    return (0);
                else
                    return ((n % 10) + Sum(n / 10));

            }

        }
    }
}
