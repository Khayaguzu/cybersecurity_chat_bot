using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace bot
{
   public  class Program
    {
        static void Main(string[] args)
        {
            // Play a voice greeting when the program starts
            PlayVoice();
        }
        static void PlayVoice()
        {
            // Get the full project directory
            string full_location = AppDomain.CurrentDomain.BaseDirectory;
            string new_path = full_location.Replace("bin\\Debug\\", "");

            try
            {
                // Build the full path to the greeting.wav file
                string full_path = Path.Combine(new_path, "greeting.wav");

                // Play the sound file synchronously
                using (SoundPlayer play = new SoundPlayer(full_path))
                {
                    play.PlaySync();
                }
            }
            catch (Exception error)
            {
                // Handle any errors in loading or playing the sound
                Console.Write(error.Message);
            }
        }
    }
}
