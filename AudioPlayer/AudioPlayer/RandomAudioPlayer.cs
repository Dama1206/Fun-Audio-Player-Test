using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace AudioPlayer
{
    internal class RandomAudioPlayer
    {
        private int sounds;
        private SoundPlayer player;
        private bool showPlayedAudio;
        private int randomAudio;
        public RandomAudioPlayer(bool showPlayedAudio)
        {
            sounds = 28;
            //player = new SoundPlayer();
            this.showPlayedAudio = showPlayedAudio;
            
        }
        private string PathCreater(string wav)
        {
            return @"Da path goes here" + wav + ".wav";
        }
        private string RandomWav()
        {
            Random rnd = new Random();
            randomAudio = rnd.Next(sounds +1);
            return @"da path goes also here" + randomAudio +".wav";
        }
        public void PlayRandom()
        {
            player = new SoundPlayer(RandomWav());
            if (showPlayedAudio) Console.WriteLine(randomAudio);
            player.PlaySync();
            
        }
        public void ClosePlayer()
        {
            Task.Delay(1000).Wait();
            if (showPlayedAudio) Console.WriteLine("End");
            player.Stop();
        }

    }
}
