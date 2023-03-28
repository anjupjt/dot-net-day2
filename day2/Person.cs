using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day21
{
    internal class Person
    {
        int numberofEyes;
       public int noofEyes { get { return numberofEyes; } set { numberofEyes = value; } }
        public string haircolor { get; set; }
        public void EatingHabit() //take
        {
            Console.WriteLine("I usually have momos in lunch");
        }
        public void EatingHabit( string myLunch)//this function only give
        {
            Console.WriteLine("I usually have "+myLunch+" in lunch");
        }
        public string EatinngHabit(string myLunch)//return and take
        {
           return("I usually have "+myLunch+" in lunch");
        }

    }

}
