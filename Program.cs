using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true) //loop to restart program 
            {
                Math();//call for math function
                run = Continue();// call for the recuring continue method
            }
        }

        public static void Math()
        {
           int Usernumber, Answer1, Answer2;
           Console.WriteLine("Enter a integer");
           Usernumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Number   Squared   Cubed");
            Console.WriteLine("======   =======   ======");
            for (int i = 1; i <= Usernumber; i++) // for loop that runs the squared and cubed equation
            {
             Answer1 = i * i;
             Answer2 = i * i * i;

             
             Console.WriteLine("{0}{1}{2}{3}{4}", i, "\t   ", Answer1, "\t     ", Answer2);//printing the answers and tabing them to lineup

           }             
        }

        public static bool Continue()//
        {
            Console.WriteLine("Would you like to run this program agian?(y/n)");
            string input = Console.ReadLine().ToLower();
            bool stuff;
                if(input == "y")
                {
                    stuff = true;//y makes the bool method true which causes the program to rerun
                }
                else if(input == "n")
                {
                    stuff = false; //n makes bool method false and causes the program to end
                }
                else
                {
                    Console.WriteLine("Sorry I didn't catch that. Please try agian (y/n)");
                    stuff = Continue();//anything other then y or n will cause the method to recure
                }

            return stuff;

        }
    }
}
