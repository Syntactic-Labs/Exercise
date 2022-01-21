using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Method
    {
        public static void Initials()
        {
            Console.WriteLine("What is your first name?: ");
            var FirstName = Console.ReadLine();
            if (FirstName == null)
            {
                Console.WriteLine("Please give your first name!");
                FirstName = Console.ReadLine();
            }
            var FirstInitial = FirstName?.Substring(0, 1);
            Console.WriteLine("What is your last name?: ");
            var LastName = Console.ReadLine();
            if (LastName ==  null)
            {
                Console.WriteLine("Please give your last name!");
                LastName = Console.ReadLine();
            }
            var LastInitial = LastName?.Substring(0, 1);
            var Initials = FirstInitial + LastInitial;
            Console.WriteLine($"Your initials are... {Initials}");
        }
        public static string CutFirst2(string a)
        {
           return a.Substring(0, 2);
        }
    }
}
