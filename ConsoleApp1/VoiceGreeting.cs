using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   public class VoiceGreeting
    {
        /// Plays a welcome sound from the Assets folder.

        public static void PlayVoiceGreeting()
        {
            try
            {
                // Initialize SoundPlayer with the path to the WAV file
                using (SoundPlayer player = new SoundPlayer("Assets/greeting.wav"))
                {
                    player.PlaySync();  // Play audio and wait for it to finish
                }
            }
            catch (Exception ex)
            {
                // Handle cases where the sound cannot be played (e.g., missing file)
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Could not play voice greeting: " + ex.Message);
                Console.ResetColor();
            }
        }
    }
}
