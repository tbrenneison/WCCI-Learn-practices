using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int five = 5;
            int ten = 10;

            int placeHolder = five;

            five = ten;
            ten = placeHolder;

            Console.WriteLine(five);
            Console.WriteLine(ten);

            
        }
    }
}
