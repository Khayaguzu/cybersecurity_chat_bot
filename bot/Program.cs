using System;
using System.Collections.Generic;
using System.Drawing;
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

            // Display logo using ASCII art from an image
            DisplayImage();
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
        static void DisplayImage()
        {
            // Get full location of the project and remove "bin\\Debug\\" from path
            string full_location = AppDomain.CurrentDomain.BaseDirectory;
            string new_location = full_location.Replace("bin\\Debug\\", "");

            // Construct the full path to the logo image
            string full_path = Path.Combine(new_location, "logo.png");

            try
            {
                // Load the image and resize it to a smaller size
                Bitmap image = new Bitmap(full_path);
                image = new Bitmap(image, new Size(150, 120));

                // Loop through image pixels and convert to ASCII characters based on grayscale values
                for (int height = 0; height < image.Height; height++)
                {
                    for (int width = 0; width < image.Width; width++)
                    {
                        Color pixelColor = image.GetPixel(width, height);
                        int gray = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;

                        // Choose ASCII character based on brightness of the pixel
                        char asciiChar = gray > 200 ? '*' : gray > 250 ? 'o' : gray > 200 ? '#' : '@';
                        Console.Write(asciiChar);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception error)
            {
                // Display an error message if the image fails to load
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Error loading logo: {error.Message}");
                Console.ResetColor();
            }
        }
    }
}
