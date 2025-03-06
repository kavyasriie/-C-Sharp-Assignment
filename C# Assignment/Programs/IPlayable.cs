using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekly_Assesment2
{
// Interface declaration
public interface IPlayable
    {
        void Play(); // Method to be implemented by classes
    }

    // MusicPlayer class implementing IPlayable
    public class MusicPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing music");
        }
    }

    // VideoPlayer class implementing IPlayable
    public class VideoPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing video");
        }
    }
    //class Program
    //{
    //    static void Main()
    //    {
    //        // Using MusicPlayer
    //        IPlayable musicPlayer = new MusicPlayer();
    //        musicPlayer.Play(); // Output: Playing music... 🎶

    //        // Using VideoPlayer
    //        IPlayable videoPlayer = new VideoPlayer();
    //        videoPlayer.Play(); // Output: Playing video... 🎬

    //        // Array of IPlayable objects (Polymorphism)
    //        IPlayable[] players = { new MusicPlayer(), new VideoPlayer() };

    //        Console.WriteLine("\nUsing polymorphism:");
    //        foreach (var player in players)
    //        {
    //            player.Play(); // Calls the Play() method of each object
    //        }
    //    }
    //}
}