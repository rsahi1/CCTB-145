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
            myApp.WhileStatementSamples(); // Call (i.e.: execute) the method
            myApp.ForStatementSample(); // Call (i.e.: execute) the method
            myApp.ListDivisibleBy(3); // Call (i.e.: execute) the method
            int someNumber;
            Console.WriteLine("Enter a small number between 2 and 20:");
            someNumber = int.Parse(Console.ReadLine());
            myApp.ListDivisibleBy(someNumber);
            myApp.EnumSample(Color.Green); // pass in a literal value from my enum

            Console.WriteLine("Goodbye.");
            Console.WriteLine("Press [enter] to exit...");
            Console.ReadLine();
        }// end of the Main() method

        private void EnumSample(Color favoriteColor)
        {
            Console.WriteLine("Sample Enumeration...");

            switch (favoriteColor)
            {
                case Color.Red:
                    Console.WriteLine("Your color is red.");
                    break;
                case Color.Blue:
                    Console.WriteLine("Your color is blue.");
                    break;
                case Color.Green:
                    Console.WriteLine("Your color is green.");
                    break;
                default:
                    Console.WriteLine("You entered a different color:");
                    Console.WriteLine(favoriteColor);
                    break;
            }

        }

        private void ListDivisibleBy(int divisor)
        {
            Console.WriteLine("List all the numbers from 1 to 100 that are divisible by " + divisor);

            for (int counter = 1; counter <= 100; counter++)
            {
                if (counter % divisor == 0)
                {
                    Console.Write(counter);
                    Console.Write(", ");
                }
            }
            Console.WriteLine(); // write a line-feed
        } // end of ListDivisibleBy() method

        private void ForStatementSample()
        {
            Console.WriteLine("For Sample...");
            for (int counter = 1; counter <= 10; counter++)
            {
                Console.WriteLine(counter);
            }
        }

        private void WhileStatementSamples()
        {
            Console.WriteLine("While and Do-While Samples...");

            int counter = 10;
            while (counter > 0)
            {// we only enter the loop while the above condition is true
                Console.WriteLine(counter);
                counter = counter - 1;
            }


            int age;
            do
            {
                Console.WriteLine("Enter your age once more: ");
                age = int.Parse(Console.ReadLine());
            } while (age < 1 || age > 100);
            string message;
            message = string.Format("You are {0} years old!", age);
            
        }  

        public void IfStatementSample()
        {
            Console.WriteLine("If Statement Sample...");

            Console.Write("Enter your age: ");
            string stringAge = Console.ReadLine();// Get the text the user types in
            int age = int.Parse(stringAge); // Convert the typed number to an int

            if (age >= 65)
            {
                Console.WriteLine("You are a senior.");
            }
            else if (age >= 18)
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
