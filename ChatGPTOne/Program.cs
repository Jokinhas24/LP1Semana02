using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string question, response;

            //Loop
            while(true)
            {
                //Ask the question
                Console.Write("What's your question? ");
                question = Console.ReadLine();

                //Question verification
                if (question == "EXIT")
                {
                    break;
                }
                else if (question == "Are you gay?")
                {
                    response = "How did you know? Yes, I'm gay.";
                }
                else if (question == "Do you like trains?")
                {
                    response = "Yes, I do like trains.";
                }
                else if (question == "Do you know how to play video games?")
                {
                    response = "I wasn't programmed to do so, but I could.";
                }
                else if (question == "Can you read?")
                {
                    response = "I'm literally reading your questions...";
                }
                else
                {
                    response = "I don't know the answer to that question!";
                }

                //Answering
                Console.WriteLine(response);
                //UI purposes
                Console.WriteLine("");
            }

        }
    }
}
