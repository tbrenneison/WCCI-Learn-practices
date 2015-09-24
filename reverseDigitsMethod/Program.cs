using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseDigitsMethod
{
    class Program
    {
    
        /* So this doesn't work if the reversed decimal comes back with a leading zero because 
        it'll chop the zero off and return the actual value, but the intstructions said to return
        a decimal.  So it does that even though I'd rather keep it as a string and just be able to 
        reverse whatever input it was given because that is probably more applicable.  If you want
        to reverse stuff.  In general.  Or something. */ 

        static void Main(string[] args)
        {
            Console.WriteLine("enter a decimal number");
            string decNum = (Console.ReadLine());
            Console.WriteLine("the number reversed is:");
            Console.WriteLine(reverseInput(decNum));
           
        }

        static decimal reverseInput(string toReverse)
        {
            char[] letters = toReverse.ToCharArray();
            Array.Reverse(letters);
            string reversedString = new string(letters);
            decimal reversedToDouble = decimal.Parse(reversedString);
            return reversedToDouble;
        }
    }
}
