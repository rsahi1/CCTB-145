using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Tell me your name: ");
            // Create some local variables
            string name;
            name = Console.ReadLine();

            Console.WriteLine("Hello " + name);

            int five = 5;
            int seven = 7;
            int total;
            total = five + seven;
            Console.WriteLine("Five + Seven is " + total);


            double price = 10.95;
            int quantity = 3;
            totalPrice = price * quantity;



            Console.Write(price);
            Console.Write(" times ");
            Console.Write(quantity);
            Console.Write(" equals ");
            Console.WriteLine(totalPrice);
            Console.WriteLine(" Computers do Math....");
        }
    }
}
