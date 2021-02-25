using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less then 9" : $"{answer} is greater then or equal to nine";
            Console.WriteLine(response);
        }
    }
}
