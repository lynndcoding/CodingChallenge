using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and initialize variable sum to add multiples of 3 or 5
            int  sum = 0;
            //create a loop for multiples 0-1000
            for (int i = 1; i < 1000; i++)
            {
                //if statement to find multiples of 3 or 5 using modulus
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            //print answer
            Console.WriteLine("The sum of all the multiples of 3 or 5 below 1000 equals: " + sum);

            Console.WriteLine("--------------------------------------------");
            //declare and initialize variables x for input from user, sum to add multiples of 3 or 5
            int n, add = 0;

            //collect input from user 
            Console.Write("This program will print the sum of all multiples of 3 or 5.\n Please input the number of terms for which you wish to calculate multiples of 3 or 5: ");
            //convert string collected from user back to an integer
            n = Convert.ToInt32(Console.ReadLine());
            //create a loop for multiples 
            for (int c = 1; c < n; c++)
            {
                //if statement to find multiples of 3 or 5 using modulus
                if (c % 3 == 0 || c % 5 == 0)
                {
                    add += c;
                }
            }

            //print answer
            Console.WriteLine("The sum of all the multiples of 3 or 5 below the value you entered of " + n + " equals: " + add);

        }
    }
}
