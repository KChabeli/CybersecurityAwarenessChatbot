using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ChatBotData
    {
        /// Manages the main conversation loop between the bot and the user.
        public static void StartConversation()
        {
            // Ask for the user's name
            Console.Write("🤖 What's your name? ");
            string name = Console.ReadLine();

            // Validate name input (cannot be empty or whitespace)
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Please enter a valid name: ");
                Console.ResetColor();
                name = Console.ReadLine();
            }

            // Greet the user by name
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nNice to meet you, {name}! Let's talk about cybersecurity.\n");
            Console.ResetColor();

            string input = "";
            while (true)
            {
                // Prompt the user for a question or topic
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\nAsk me something (or type 'exit' to quit): ");
                Console.ResetColor();
                input = Console.ReadLine()?.ToLower();

                // Handle empty input
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("⚠️  I didn't catch that. Try asking something else.");
                    Console.ResetColor();
                    continue;
                }

                // Handle exit command
                if (input == "exit")
                {
                    Console.WriteLine("\n👋 Goodbye! Stay safe online.");
                    break;
                }

                // Process valid input
                RespondToUser(input);
            }
        }

        /// Provides predefined responses based on user input.
       public static void RespondToUser(string input)
        {
            if (input.Contains("how are you"))
            {
                Console.WriteLine("🤖 I'm just a bot, but I'm always ready to help!");
            }
            else if (input.Contains("purpose"))
            {
                Console.WriteLine("🔐 My purpose is to teach you about cybersecurity and help you stay safe online.");
            }
            else if (input.Contains("password"))
            {
                Console.WriteLine("💡 Tip: Use long, complex passwords and avoid using the same password for multiple sites.");
            }
            else if (input.Contains("phishing"))
            {
                Console.WriteLine("🚨 The fraudulent practice of sending emails or other messages purporting to be from reputable companies in order to induce individuals to reveal personal information, such as passwords and credit card numbers. " +
                    "Tip: Be cautious of emails asking for personal info. Always verify the sender!");
            }
            else if (input.Contains("safe browsing"))
            {
                Console.WriteLine("🌐 Stick to secure sites (https) and avoid clicking suspicious links.");
            }
            else
            {
                // Handle unrecognized questions
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("🤔 I didn't quite understand that. Try asking about passwords, phishing, or safe browsing.");
                Console.ResetColor();
            }
        }
    }
}
