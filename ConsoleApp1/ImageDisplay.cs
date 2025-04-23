using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class ImageDisplay
    {

        /// Prints a cybersecurity-themed ASCII art lock and welcome banner.
        public static void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
    ______
   /      \
  /   /\   \
 /___/  \___\
 |   ____   |
 |  |LOCK|  |
 |  |____|  |
 |__________|
            ");
            Console.ResetColor();
            Console.WriteLine("╔════════════════════════════════════════════╗");
            Console.WriteLine("║     Welcome to the Cybersecurity Bot!      ║");
            Console.WriteLine("╚════════════════════════════════════════════╝\n");
        }

    }
}
