using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Drawing;
using System.Media;
namespace LoginAndRegistrationInterface
{
    class BabMusic
    {
        public void PlayMusic()
        {
            string music = @"D://VS项目//LoginAndRegistrationInterface 2//LoginAndRegistrationInterface//a.wav";
            SoundPlayer soundPlayer = new SoundPlayer(music);
            soundPlayer.Play();
        }
        
    }
}
