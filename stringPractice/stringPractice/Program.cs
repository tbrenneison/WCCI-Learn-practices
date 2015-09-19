using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = The "use" of quotations causes difficultlies.); //why are we coding something that doesn't work? This makes me itchy.

            string two = "The "use" of quotations causes difficulties."); //still wrong, still itchy.

            string three = "The \"use"\ "of quotations causes difficulties."); //I had to try and fix it. 
        }
    }
}
