using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_with_classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var YForm  = new YYForm();
            YForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var NForm = new NNForm();
            NForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            var DForm = new DDForm();
            DForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ZForm = new ZZForm();
            ZForm.Show();
        }
    }
}
