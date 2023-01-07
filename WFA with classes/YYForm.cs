using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WFA_with_classes
{
    public partial class YYForm : Form
    {
        public SoundPlayer _soundplayer;

        public YY yY;
        public YYForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 f1 = new Form1();
            f1.Show();
            f1.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            yY= new YY();
            yY.eat(pictureBox1);

        }

        private void YYForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"YYPic.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            _soundplayer= new SoundPlayer();
            yY = new YY();
            if (checkBox2.Checked)
            {
                yY.speak(pictureBox1, _soundplayer);
                checkBox2.Text = "Shut Up";
            }
            else { 
                checkBox2.Text = "Speak";
                _soundplayer.Stop();
                pictureBox1.Image = Image.FromFile(@"YYPic.jpg");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YY Humanoids can Eat and Speak French \nThey don't have any ancestors", "About YY");
        }
    }
}
