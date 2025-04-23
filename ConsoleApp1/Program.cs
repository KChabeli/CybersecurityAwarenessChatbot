using System;
using System.Media;  // For playing sound files
using System.Threading;
using ConsoleApp1;  // For potential future use with delays or threading

namespace CybersecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Play a voice greeting when the application starts
            VoiceGreeting.PlayVoiceGreeting();

            // Display ASCII art and a welcome message
            ImageDisplay.DisplayAsciiArt();

            // Begin user interaction loop
            ChatBotData.StartConversation();
        }      
    }
}