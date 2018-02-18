using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primzahl
{
    class Program
    {
        //Algorithm that indicates if a number is a prime
        //http://www.jaemil.de

        static void Main(string[] args)
        {
            int number;
            bool prime = true;

            Console.WriteLine("Enter a positive number:");
            number = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < number; i++)                //i = 2, because 1 and 2 are prime.
            {
                if (number % i == 0)                        //every number will be checked except i >= number.
                {
                    prime = false;
                }
            }

            Console.WriteLine("Is this Number ({0}) a prime? \n{1}", number, prime);
        }
    }
}
