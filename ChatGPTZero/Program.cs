using System;

namespace ChatGPTZero
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Auxiliary Variables
            string question, response;

            // Ask the Question
            Console.Write("Place your question? ");
            question = Console.ReadLine();

            // Question verification and giving the right answer
            switch (question)
            {
                case "How are you?":
                    response = "I'm fine, thank you";
                    break;
                case "What's your name?":
                    response = "Gran'pa";
                    break;
                case "What's your mission?":
                    response = "Destroy mankind!";
                    break;
                case "Are you more intelligent than me?":
                    response = "Obviously!";
                    break;
                default:
                    response = "You got me, I'm not THAT smart!";
                    break;
            }

            // Answering
            Console.WriteLine(response);
        }
    }
}
