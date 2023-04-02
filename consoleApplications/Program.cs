using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace consoleApplications
{ 
    class Program
    {
        static void Main(string[] args)
        {
            //typing
            //Console.WriteLine() and Console.Write()
            
            //reading
            //Console.ReadLine(), Console.Read() and Console.ReadKey()
            
            //Console.WriteLine("Press a button:");
            //int pressedButton = Console.Read();
            //Console.WriteLine("Pressed buttons ASCII code: {0}",pressedButton);
            
            //Console.WriteLine("Enter your name: ");
            //String name = Console.ReadLine();
            //Console.WriteLine("Your name is {0}", name);
            
            //if else
            
            Console.WriteLine("Enter a number: ");
            int theNumber = int.Parse(Console.ReadLine());

            if (theNumber < 50)
            {
                Console.WriteLine("The number is lesser than 50.");
            }
            else if (theNumber >= 50 && theNumber <= 100)
            {
                Console.WriteLine("The number is between 50 and 100.");
            }
            else
            {
                Console.WriteLine("Number is greater than 100.");
            }
            
            
        }
    }
}