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
    public partial class ZZForm : Form
    {
        ZZ zZ = new ZZ();
        private SoundPlayer _soundplayer;
        public ZZForm()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"ZZPic.jpeg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ZZ humanoids dance and sing when they socialize.", "About ZZ");
        }

        private void ZZForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var mainwin = new Form1();
            mainwin.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
                zZ.dance(pictureBox1);
                zZ.sing(_soundplayer);
                checkBox1.Text = "Stop";
            }
            else
            {
                checkBox1.Text = "Socialize";
                pictureBox1.Image = Image.FromFile(@"ZZPic.jpeg");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                _soundplayer= new SoundPlayer();
                _soundplayer.Stop();
            }
        }
    }
}
