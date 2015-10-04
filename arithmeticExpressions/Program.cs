using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace arithmeticExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //CONVERT FROM INFIX TO POSTFIX EXPRESSION
            //pretty convinced this would work if I could figure out how to set priority in the stack

            Console.WriteLine("Write your expression. \r\nNOTE: All tokens must be separated with a space, for example: 56 + 7 + 9 * 54 \r\n");
            string exp = Console.ReadLine();
            string[] tokens = exp.Split(' ');

            StringBuilder nums = new StringBuilder(); 
            Stack<string> ops = new Stack<string>(); 

            foreach (string token in tokens) //for each token 
            {
                int x;
                if (int.TryParse(token, out x)) //if token is an integer, parse it and append to StringBuilder
                {
                    nums.Append(token + " "); 
                }
                //if token is an operator 
                else if (token == "+" || token == "-" || token == "*" || token == "/" || token == "(" || token == ")")
                {
                    if (ops.Count == 0)
                    {
                        ops.Push(token);
                    }
                    else if (token == "(")
                    {
                        ops.Push(token); 
                    }
                    else if (token == ")")
                    {
                        //pop entries off the stack until you meet "("
                    }
                    else
                    { //this is where I would pop stuff off the stack until
                      //  reaching a token with higher or equal priority if
                      //  I had any blasted idea how to do that
                    }
                }    
            }
            foreach(string op in ops) //append the operators to the stringbuilder
            {
                nums.Append(op + " ");
            }

            Console.WriteLine(nums.ToString().Trim()); //write the postfix expression to the console
            
            */





            //EVALUATING A POSTFIX METHOD
            /*
           - We read the tokens in one at a time.
           - If it is an integer, push it on the stack
           - If it is a binary operator, pop the top two elements from the stack, 
           apply the operator, and push the result back on the stack.
            */

            Console.WriteLine("Write your expression. \r\nNOTE: All tokens must be separated with a space, for example: 56 7 2 - 4 2 * \r\n");
            string expression = Console.ReadLine().Trim(); //because an extra space will ruin everything (empty stack) 
            string[] tokens2 = expression.Split(' ');

            Stack<int> tokenz = new Stack<int>();
            
            foreach (string token in tokens2) //for each token 
            {
                int x;
                if (int.TryParse(token, out x)) //push value to tokenz 
                {
                    tokenz.Push(x);
                }
                else
                {
                    int z = tokenz.Pop(); //most recent token onto stack
                    int y = tokenz.Pop(); //second to most recent token onto stack
                    int result;
                    if (token == "+")
                    {
                        result = y + z;
                        tokenz.Push(result);
                    }
                    else if (token == "-")
                    {
                        result = y - z;
                        tokenz.Push(result);
                    }
                    else if (token == "*")
                    {
                        result = y * z;
                        tokenz.Push(result);
                    }
                    else if (token == "/")
                    {
                        result = y / z;
                        tokenz.Push(result);
                    }
                }
            }
            Console.WriteLine(tokenz.Peek()); //returns the result (should be only thing left on stack at end)

        }//end of main method 
    }
}
