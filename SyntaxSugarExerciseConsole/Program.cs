using System;

namespace SyntaxSugarExerciseConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Inferred Typing example

            var answer = 4;
            
            string response;

            if (answer < 9)
            {
                response = answer + "is less than nine";
            }
            else
            {
                response = answer + "greater than or equal to nine";
            }

            //String Interpolation example

            int answer = 4;

            string response;

            if (answer < 9)
            {
                response = ($"{answer} is less than nine");
            }
            else
            {
                response = ($"{answer} greater than or equal to");
            }

            //Ternary Operator example

            int answer = 4;
            string response;
             response = (answer) < 9 ? "answer + is less than nine" : answer + "greater than or equal to";
        
            




        }
    }
}
