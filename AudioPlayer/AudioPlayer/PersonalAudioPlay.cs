using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace AudioPlayer
{
    internal class PersonalAudioPlay
    {
        SoundPlayer soundPlayer;

        public PersonalAudioPlay(string dataName)
        {
            soundPlayer = new SoundPlayer(dataName);
            soundPlayer.Play();
        }
    }
}
