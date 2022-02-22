using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeoQuiz geo = new GeoQuiz();
            
            string input = "nada";

            while (input != "X")
            {
                Console.WriteLine("Welcome. Press 't' to start the test or 'X' to exit");
                input = Console.ReadLine();

                if (input == "t")
                {
                    input = geo.askQuestion();
                    Console.WriteLine(" With this we finish the game! ");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
            
        }

     

       






    }
}
