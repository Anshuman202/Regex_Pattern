using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RejexAssignment
{
    class Program
    {
        public static string Reg_pattern = "^[A-Z]{1}[A-Za-z]{2,}$";

        public static void Main(String[] args)
        {
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            Console.WriteLine();



            bool val = Regex.IsMatch(name, Reg_pattern);





            if (val)
            {
                Console.WriteLine("Pattern is correct for given user name: {0}", name);
            }
            else
                Console.WriteLine("pattern is wrong");

        }
    }
}