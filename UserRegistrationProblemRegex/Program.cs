using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblemRegex
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Please Enter your Email");
                var lastName = Console.ReadLine();
                var regexDt = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

                if (regexDt.IsMatch(lastName))
                    Console.WriteLine("Valid Email Name");
                else
                    Console.WriteLine("Not Valid Email Name");

            
            
        }
    }
}
