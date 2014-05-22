using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number;
            {
            Console.WriteLine("Enter a number between 1 and 100");
                Number = int.Parse(Console.ReadLine());
            }
            if (Number >1 || Number < 100)
            {
            Console.WriteLine ("Number is in between the allowed range of numbers");
            }

            else if (Number < 1 || Number > 100)
            {
                Console.WriteLine("Number is not between the allowed range of numbers");
            }
        } // End of step 2 method
           
            private void forStatementSample()
            {
                for( int currentNumber = 1; currentNumber <= 100; currentNumber++)
                {
                    Console.WriteLine (currentNumber);
                }

    }
            static public bool IsEvenNumber(int intNumber)
            {
                return intNumber % 2 == 0;
            }
    }
}
