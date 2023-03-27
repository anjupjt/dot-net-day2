using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bitwiseoperator();
           logicaloperater();
            Console.ReadKey();
        }
        static void logicaloperater()//example of logical operator
        {
            Console.WriteLine("enter your college name");
            string collegeName=Console.ReadLine();
            Console.WriteLine("enter your program");
            string programName=Console.ReadLine();
            if (string.IsNullOrEmpty(collegeName))
            {
                Console.WriteLine("please enter the college name");
            }
            else if (collegeName.ToUpper()=="BMC"&& programName.ToUpper()=="CSIT")
            {
                Console.WriteLine("You are welcome in lab");
            }
            else
            {
                Console.WriteLine("you maynot enter");

            }
        }

        static void Bitwiseoperator() //example of bitwise operator
        {

        }

        
    }
}
