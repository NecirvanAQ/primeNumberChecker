using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* Write a program that when the user enters a number and it will tell them if it’s prime or not.
The program will check whether any number between 2 and the square root of the number divides exactly into the number entered. 
If none of these numbers do then the number is prime.
To get the square root of a number use Math.sqrt()
To know whether a number divides exactly use MOD which is the % operator.The MOD operator returns the remainder from division. 
If the remainder is 0 then the number divides exactly.
e.g. (if x % y==0) { then Y divides exactly into X}
*/



namespace primeNumberChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool prime = true;
            int number = 0;
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number > 2)
            {
                for (int i = 2; i < Math.Sqrt(number); i++)
                {

                    if (number % i == 0)
                    {
                        prime = false;
                    }
                }
            }

            Console.WriteLine("Number is prime: " + prime);
            Console.ReadKey();
        }
    }
}
