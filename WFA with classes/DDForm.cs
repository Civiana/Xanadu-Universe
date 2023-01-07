using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_with_classes
{

    public partial class DDForm : Form
    {
        DD dD = new DD();

        private SoundPlayer _soundplayer;
        public DDForm()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"DDPic.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SoundPlayer _soundplayer = new SoundPlayer();
            if (checkBox1.Checked)
            {
                dD.snore(_soundplayer);
                checkBox1.Text = "Wake up";
                pictureBox1.Image = Image.FromFile(@"NNSleep.jpg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                checkBox1.Text = "Snore";
                pictureBox1.Image = Image.FromFile(@"DDPic.png");
                _soundplayer.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var Mainwin = new Form1();
            Mainwin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DD humanoids are sub species of NN’s \nand they snore loudly", "About DD");
        }
    }
}
