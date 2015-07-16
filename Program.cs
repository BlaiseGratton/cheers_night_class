using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cheers
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("\n\n********************************\n");
            Console.WriteLine("*       Welcome to Cheers!     *\n");
            Console.WriteLine("********************************\n\n\n");

            Console.WriteLine("What is your name?");
            string nameInput = System.Console.ReadLine();
            System.Console.WriteLine("\n");
            
            string halfNorseMix = "halfnorsemix";
            string loweredName = nameInput.ToLower().Trim();
            
            foreach (var letter in loweredName)
            {
                if (halfNorseMix.IndexOf(letter) == -1)
                {
                    Console.WriteLine(String.Format("Give me a {0}!\n...", char.ToUpper(letter)));
                }
                else 
                {
                    Console.WriteLine(String.Format("Give me an {0}!\n...", char.ToUpper(letter)));
                }
            }
            System.Console.WriteLine(String.Format("\n{0} is grand!!!", nameInput));
            
            Console.ReadLine();
        }

    }
}
