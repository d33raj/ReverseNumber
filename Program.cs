using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number to Reverse it:");
            number = Convert.ToInt32(Console.ReadLine());

            int reverseNumber = 0;
            int temp = number;
            while (number > 0)
            {
                int digit = number % 10;
                reverseNumber = reverseNumber * 10 + digit;
                number /= 10;
            }

            Console.WriteLine("The Reversed number is: "+ reverseNumber);
        }
    }
}
