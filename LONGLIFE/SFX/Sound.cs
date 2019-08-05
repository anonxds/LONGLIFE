using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
namespace LONGLIFE.SFX
{
    class Sound
    {
        public void playsound(Stream file)
        {
            SoundPlayer player = new SoundPlayer(file);
            player.Play();
        }
    }
}
