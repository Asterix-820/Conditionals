using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace myNewProject.day1.examples
{
    internal class ExampleOne
    {
        static void Main()
        {
            int ans1, ans2, ans3, ans4;


            int A = 15;
            int B = 20;
            Console.WriteLine("Dear applicant, Welcome to this test!!");
            Console.WriteLine("What is your fullname?");

            string Fullname = Console.ReadLine();

            Console.WriteLine("Your name is: " + Fullname);
            Console.Write("Get ready to start the test, and follow all instruction.");
            Console.WriteLine("GOODLUCK");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine(" if A is 15 and B is 20; What is the Sum of  A and B? ");

            ans1 = Convert.ToInt32(Console.ReadLine());
            if (ans1 == 35)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorect!");
            }
            {

            }
            Console.WriteLine(" if A is 15 and B is 20; What is the value of B % A? ");
            ans2 = Convert.ToInt32(Console.ReadLine());
            if (ans2 == 5)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorect!");
            }
            {

            }
           /* Console.BackgroundColor = ConsoleColor.Gray;
            // Set the Foreground color to blue
            Console.ForegroundColor
                = ConsoleColor.Blue;

            // Display current Foreground color
            Console.WriteLine("Changed Foreground Color: {0}",
                                    Console.ForegroundColor);

            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Changed Foreground Color: {0}",
                                   Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Changed Foreground Color: {0}",
                                   Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Changed Foreground Color: {0}",
                                   Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Changed  to my fav Foreground Color: {0}",
                                   Console.ForegroundColor);
           */


            /*int X,Y ;
            int result;

            //output the modulo of two given numbers
            Console.WriteLine("Enter a number:");
            X = .ToInt(Console.ReadLine());
*/


        }
    }
}
