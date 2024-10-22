using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Polindrom
    {
        public static void isPolindrom(string str)
        {
            if (str == null) { Console.WriteLine("Invalid imput"); return; }

            var tempstr = str.ToLower().ToArray();

            if (tempstr.Reverse().SequenceEqual(str.ToLower())) { Console.WriteLine("true"); return; }

            Console.WriteLine("False");     
            
        }
    }
}
