using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_with_classes
{
    public partial class NNForm : Form
    {
        NN nN = new NN();
        public NNForm()
        {
            InitializeComponent();
            pictureBox1.Image = Image.FromFile(@"NNPic.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nN.writecode(pictureBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NN humanoids are sub species of ZZ and they can’t eat but they are technologically advanced " +
                "\nand can develop software and they like to sing when they socialize.", "About NN");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            var Mainwin = new Form1();
            Mainwin.Show();
        }
    }
}
