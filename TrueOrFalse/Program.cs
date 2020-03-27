using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrueOrFalse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            //Tools.SetUpInputStream(entry);

            // Type your code below
            string[] questions = { "Are you reach?", "Do I have a million dollar?", "Am I married?"};
            bool[] answers = { false, false, true };
            bool[] responses = new bool[questions.Length];

            if (questions.Length != responses.Length)
            {
                Console.WriteLine("WARNING: Each questions doens't have responeses.");
            }

            int askingIndex = 0;
            foreach (string question in questions)
            {
                bool inputBool;

                Console.WriteLine(question);
                Console.WriteLine("True or False?");
                string input = Console.ReadLine();

                bool isBool = Boolean.TryParse(input, out inputBool);
                while (!isBool)
                {
                    Console.WriteLine("Please response with 'true' or 'false'");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }

                responses[askingIndex] = inputBool;
                askingIndex++;
            }

            //Console.WriteLine("Your answers are: ");
            //foreach (bool response in responses)
            //{
            //    Console.Write(response + " ");
            //}

            int scoringIndex = 0;
            int score = 0;

            foreach (bool answer in answers)
            {
                bool inputResponses = responses[scoringIndex];
                Console.WriteLine($"Input : {inputResponses}  | Answer : {answers[scoringIndex]}");

                if (inputResponses == (answers[scoringIndex]))
                {
                    score++;
                }
                scoringIndex++;
            }
            Console.WriteLine($"You got {score} out of {questions.Length}");




        }



    }
}

