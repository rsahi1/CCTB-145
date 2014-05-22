using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programFlow1
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Write the code that will run the samples...
            Program myApp = new Program(); // Create an object based on this class

            myApp.IfStatementSample(); // Call (i.e.: execute) the method

            Console.WriteLine("Goodbye.");
            Console.WriteLine("Press [enter] to exit...");
            Console.ReadLine();
        }  // end of the Main() method

        public void IfStatementSample()
        {
            Console.WriteLine("If Statement Sample...");

            Console.Write("Enter your age: ");
            string stringAge = Console.ReadLine();// Get the text the user types in
            int age = int.Parse(stringAge); // Convert the typed number to an int

            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are not an adult.");
            }
        }// end of the IfStatementSample() method

    }// end of the Program class
    }// end of the namespace for this file's code
