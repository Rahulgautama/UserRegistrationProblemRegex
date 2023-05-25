using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblemRegex
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Please Enter your Password min 8 digit upper,lower,number");
                var lastName = Console.ReadLine();
                var regexDt = new Regex(@"^\w{8,16}$");

                if (regexDt.IsMatch(lastName))
                    Console.WriteLine("Valid Password ");
                else
                    Console.WriteLine("Not Valid password ");

            
            
        }
    }
}
