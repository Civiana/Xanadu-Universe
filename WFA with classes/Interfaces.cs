using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WFA_with_classes
{
    public interface ISpeakFrench
    {
        void sing(SoundPlayer sound);
        void speak(PictureBox pic, SoundPlayer sound);
    }

    public interface ICanEat { 
    
    void eat(PictureBox pic); 
    
    }

    public interface ICanDance
    {
        void dance(PictureBox picture);
    }

    public interface ISnore
    {
        void snore(SoundPlayer _soundplayer);
    }

    public interface ICodeCSharp
    {
        void writecode(PictureBox picture);
    }
}