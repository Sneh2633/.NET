using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphism
{
    interface MediaPlayer
    {
        public void Play();
        public void Stop();
        
    }
    class AudioPlayer : MediaPlayer
    {
        public string Filename {  get; set; }
        public void Play()
        {
            Console.WriteLine($"{Filename} is playing...");
        }

        public void Stop()
        {
            Console.WriteLine($"{Filename} is stopped...");
        }
    }
    class VideoPlayer : MediaPlayer
    {
        public string Filename { get; set; }
        public void Play()
        {
            Console.WriteLine($"{Filename} is playing...");
        }

        public void Stop()
        {
            Console.WriteLine($"{Filename} is stopped...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AudioPlayer a = new AudioPlayer();
            a.Filename= "Suno na Sang";

            a.Play();

            VideoPlayer video = new VideoPlayer();
            video.Filename= "Munjya";
            video.Play();

            video.Stop();

            a.Stop();
            
        }
    }
}
