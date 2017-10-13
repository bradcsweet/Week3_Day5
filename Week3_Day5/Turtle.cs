using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day5
{
    class Turtle
    {
        //this static variable belongs to the CLASS
        //It is shared among all instances.
        //This also means you can use the variable without creating instances first.

        static int turtleCount;

        public Turtle()
        {
            turtleCount++;
        }

        //This static method belongs to the class.
        //It's shared among all instances.
        //It means we can use the method without creating
        //any instances first.
        public static void WarCry()
        {
            Console.WriteLine("We are an army of " + turtleCount + " turtles!");
        }



    }
}
