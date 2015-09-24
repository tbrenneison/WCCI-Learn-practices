using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //input and assign all the things
            Console.WriteLine("Enter a number.");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Add, subtract, multiply or divide?");
            string operation = Console.ReadLine().ToUpper();  //UPPERCASE SO THAT YOU CAN USE IT LATER NO PROBZ LOL
            Console.WriteLine("Enter a second number.");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(); //just for an empty space 

            //okay it's time to get real 
            if (operation == "ADD")
            {
                Console.WriteLine(Add(x, y));
            }
            else if (operation == "SUBTRACT")
            {
                Console.WriteLine(Subtract(x, y));
            }
            else if (operation == "MULTIPLY")
            {
                Console.WriteLine(Multiply(x, y));
            }
            else if (operation == "DIVIDE")
            {
                Console.WriteLine(Divide(x, y));
            }
            else
            {
                Console.WriteLine("ERROR: Invalid operation selected, please try again.");
            }
        } //END OF MAIN METHOD   do freaking not lose this stupid jerk bracket

        static int Add(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        static int Subtract(int x, int y)
        {
            int difference = x - y;
            return difference;
        }

        static int Multiply(int x, int y)
        {
            int product = x * y;
            return product;
        }

        static double Divide(double x, double y) //DOUBLES BECAUSE DECIMAL POINTS, WHOA NELLY. 
        {
            double dividend = x / y;
            return dividend;
        }
    }
}
