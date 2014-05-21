using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesValuesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
           // Order of operations - arithmetic operators..
            double result = 5 + 6 * 4 + 1;
            //              |   |   |   |
            //              |   \   /   |
            //              |    _24___ |
            //              |      |    |
            //              \      /    |
            //              \      /    |
            //                __29___    
            //                  |       |
            //                    \    /
            //                     \   /
            //                      _30__
            Console.WriteLine("The result of the math is " + result);
     
            // What does casting -really-  do??
            char singleDigit = '5';
            int simpleNumber = 25;
            // The result of casting...
            Console.WriteLine("Casting '5'...");
            Console.WriteLine((int)singleDigit;
            Console.WriteLine("Casting 25...");
            Console.WriteLine((double)simpleNumber;

            // The result of converting...
            Console.WriteLine("Converting '5'...");
            Console.WriteLine(Convert.ToInt32(singleDigit));
            Console.WriteLine("Converting 25...");
            Console.WriteLine(Convert.ToDouble(simpleNumber));
            // "alternate" way of converting using the Parse method
            Console.WriteLine("Converting '5' using int.Parse()");
        // Console.WriteLine(int.Parse(singleDigit));// can't "parse" a single char
     Console.WriteLine(int.Parse(singleDigit.ToString())); // can parse a string...
           Console.WriteLine("The value in the variable singleDigit is" + singleDigit.ToString());
           Console.WriteLine("Converting '5' after calling  . ToString() ..."); 
            Console.WriteLine(Convert.ToInt32(singleDigit.ToString()));


            // Variables of various data types, with values
            string sentence = "A string can hold many characters.";
            string empty = " "; // A string can be "empty"  (zero characters)
          string nothing  + null; // A string can be null (not the same as "empty")

     bool booleanVariable = true; // Booleans can only hold values of true or false
      //  Please note that true is not the same as "true"
     //                    \bool/                  \string/
   
    // Variable names are decided upon by you when you declare the variable.
    // Like everything else in C#, variable names are case sensitive...  
    int number = 25;
    int Number; 
    int NUMbER;
    // all the above are DIFFERENT variables....

   // Play with boolean expressions and the logical operators
    int highNumber  = 100;  
    int lowNumber  = 2;

    bool highIsBiggerThanLow  = highNumber > lowNumber;
     //                        \relational  expression/
     //                         \   true  or false?   /
    bool highIsBiggerThan50  = highNumber  . 50;
    bool highIs100 =  highNumber  ==  100;
 
    bool highIsBiggerThanLowAndBiggerThan50;  
    highIsBiggerThanLowAndBiggerThan50 = 
        highIsBiggerThanLow && highIsBiggerThanLow highIsBiggerThan50;

        }
    }
}
