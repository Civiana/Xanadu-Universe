using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_with_classes
{
    public class YY : ISpeakFrench, ICanEat
    {
        public void speak(PictureBox myPictureBox, SoundPlayer _speakplayer) {
                _speakplayer = new SoundPlayer("French.wav");
                myPictureBox.Image = Image.FromFile(@"6bsiu.gif");
            _speakplayer.Play();
        }

        public void sing(SoundPlayer _singplayer) {

            _singplayer = new SoundPlayer("");
        
        }

        public void eat(PictureBox myPictureBox)
        {

            myPictureBox.Image = Image.FromFile(@"YYEat.gif");

            
        }

    }
    

    public class ZZ : ISpeakFrench , ICanDance
    {
        public void speak(PictureBox picBox, SoundPlayer _soundplayer) { 
        }
        public void sing(SoundPlayer _soundplayer) {
            _soundplayer = new SoundPlayer("ZZSing.wav");
            _soundplayer.Play();
        }
        public void dance(PictureBox myPicturebox) {
            myPicturebox.Image = Image.FromFile(@"ZZDance.gif");
        }
    }

    public class NN : ZZ, ICodeCSharp {

        public void writecode(PictureBox myPicturebox)
        {
            myPicturebox.Image = Image.FromFile(@"NNCode.gif");
            myPicturebox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
    public class DD : NN , ISnore { 
    
        public void snore(SoundPlayer _soundplayer)
        {
            _soundplayer = new SoundPlayer("DDSnore.wav");
            _soundplayer.Play();
        }
        public void sing() { }

    }
}
