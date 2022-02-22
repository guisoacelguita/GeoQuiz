using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoQuiz
{
    internal class GeoQuiz
    {
        private String[] stringarr = new String[] { "Welches Land grenzt am Westen Spaniens? a.) Frankreich, b.) Marokko, c.) Portugal , d.) Andorra",
            "Wie heißt der höchste Berg Deutschlands? a.) Mattehorn, b.) Waxenstein, c.) Mont blanc, d.) Zugspitze",
            "Welcher Fluss fließt durch die Hauptstadt Österreichs? a.) Moldau, b.) Donau, c.) Rhein, d.) Mur",
            "Cardiff ist die Hauptstadt von... a.) Schottland, b.) Wales, c.) Gibraltar, d.) Nordirland",
            "Welches Land liegt zwischen Frankreich und Spanien? a.) Andorra, b.) San Marino, c.) Albanien, d.) Monaco"
        };

        public string askQuestion()
        {
            int score = 0;

            for (int i = 0; i < stringarr.Length; i++)

            {
                Console.WriteLine(stringarr[i]);
                string inputIn = Console.ReadLine();
                bool isRight = valueResponse(i, inputIn);


                if (isRight)
                {
                    score = score + 2;
                    Console.WriteLine("Great Job! You have added 2 more points to your score. Your score is : " + score);
                    
                }
                else
                {
                    Console.WriteLine("Sorry wrong answer. Your accumulated score is " + score);
                    return Console.ReadLine();
                }
            }
            return "X";
        } 

        private bool valueResponse (int question, string answer )
        {
            if (question == 0)
            {
                if (answer == "c")
                {
                    return true;
                }

            }
            if (question == 1)
            {
                if (answer == "d")
                {
                    return true;
                }

            }
            if (question == 2)
            {
                if (answer == "b")
                {
                    return true;
                }

            }
            if (question == 3)
            {
                if (answer == "b")
                {
                    return true;
                }

            }
            if (question == 4)
            {
                if (answer == "a")
                {
                    return true;
                }

            }

            return false;

        }

    }
    
    
    
    
    
    
}
