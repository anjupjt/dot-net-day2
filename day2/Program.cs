using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using day21;
namespace day21
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Bitwiseoperator();
           //logicaloperater();
           Person anju=new Person();
           // anju.numberofEyes = 2;
            anju.noofEyes = 2;
            anju.haircolor = "black";
            anju.EatingHabit();
            anju.EatingHabit("chowmein");
            string myLunch = anju.EatinngHabit("Biryani");
            Console.WriteLine(myLunch); 
            Console.WriteLine("you have " + anju.noofEyes + " eyes");
            Console.WriteLine("your hair color is "+anju.haircolor);

            Console.ReadKey();
       
        }
        //static void logicaloperater()//example of logical operator
        //{
        //    Console.WriteLine("enter your college name");
        //    string collegeName=Console.ReadLine();
        //    Console.WriteLine("enter your program");
        //    string programName=Console.ReadLine();
        //    if (string.IsNullOrEmpty(collegeName))
        //    {
        //        Console.WriteLine("please enter the college name");
        //    }
        //    else if (collegeName.ToUpper()=="BMC"&& programName.ToUpper()=="CSIT")
        //    {
        //        Console.WriteLine("You are welcome in lab");
        //    }
        //    else
        //    {
        //        Console.WriteLine("you maynot enter");

        //    }
        //}

        //static void Bitwiseoperator() //example of bitwise operator
        //{

        //}

        
    }
}
