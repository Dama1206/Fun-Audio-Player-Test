using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomAudioPlayer player = new RandomAudioPlayer (true);
            for(int i = 0; i < 50; i++)
            {
                player.PlayRandom();
            }
            player.ClosePlayer ();

            Console.ReadKey();
        }
    }
}
