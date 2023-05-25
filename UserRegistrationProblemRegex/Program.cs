using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblemRegex
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Please Enter your Mobile Number");
                var lastName = Console.ReadLine();
                var regexDt = new Regex(@"^(\+[0-9]{12,13})$");

                if (regexDt.IsMatch(lastName))
                    Console.WriteLine("Valid Mobile Number");
                else
                    Console.WriteLine("Not Valid Mobile number");

            
            
        }
    }
}
