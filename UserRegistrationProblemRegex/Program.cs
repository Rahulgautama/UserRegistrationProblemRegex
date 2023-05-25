using System;
using System.Text.RegularExpressions;

namespace UserRegistrationProblemRegex
{
    class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Please Enter your Password min 8 digit upper,lower,number,special sym");
                var lastName = Console.ReadLine();
                var regexDt = new Regex(@"(?=^.{8,16}$)((?=.*\d)|(?=.*\W+))(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$");

                if (regexDt.IsMatch(lastName))
                    Console.WriteLine("Valid Password ");
                else
                    Console.WriteLine("Not Valid password ");

            
            
        }
    }
}
