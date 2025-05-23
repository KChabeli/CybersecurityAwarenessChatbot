using System;
using System.Media;  // For playing sound files
using System.Threading;
using ConsoleApp1;  // For potential future use with delays or threading

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Play a voice greeting when the application starts
            VoiceGreeting.PlayVoiceGreeting();

            // Display ASCII art and a welcome message
            ImageDisplay.DisplayAsciiArt();

            var manager = new ConversationManager();
            manager.Start();
        }
    }
}