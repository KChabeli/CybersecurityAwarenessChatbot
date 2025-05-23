using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Handles overall conversation and manages memory
    // Handles conversation loop and user interaction
    // Handles overall conversation and manages memory
    public class ConversationManager
    {
        private readonly Memory memory = new Memory();
        private readonly ResponseEngine engine = new ResponseEngine();

        public void Start()
        {
            Console.WriteLine("Welcome to the Cybersecurity Awareness Bot!");
            Console.WriteLine("You can ask about phishing, passwords, privacy, or safe browsing.");
            Console.WriteLine("Say 'exit' to quit the conversation.\n");

            while (true)
            {
                Console.Write("You: ");
                var input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) continue;

                if (input.ToLower() == "exit") break;

                if (input.ToLower().StartsWith("my name is"))
                {
                    memory.UserName = input.Substring(11).Trim();
                    Console.WriteLine($"Bot: Nice to meet you, {memory.UserName}!");
                    continue;
                }

                if (input.ToLower().StartsWith("what is my name"))
                {
                    memory.UserName = input.Substring(11).Trim();
                    Console.WriteLine($"Bot: Your name is, {memory.UserName} of course!");
                    continue;
                }

                if (input.ToLower().StartsWith("what is your name"))
                {
                    memory.UserName = input.Substring(11).Trim();
                    Console.WriteLine($"Bot: I am your friendly Cybersecurity Awareness Chatbot! Pleasure to meet you");
                    continue;
                }

                var response = engine.GetResponse(input, memory);
                Console.WriteLine("Bot: " + response);
            }
        }
    }

}