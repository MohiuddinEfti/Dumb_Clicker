using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dumb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int a=0;
        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Random rnd2 = new Random();
           

            for (int i=0; i<36;i++)
            {
                for (int c = 0;c < 36; c++)
                {

                     rnd2.Next(100, 180);
                }
                button2.Location = new Point(rnd.Next(10, 180),   rnd2.Next(100, 180));
                
            }
            a = a + 1;
            if (a == 25)
            {
                label1.Text = "You Are Useless\nPlease Do Some\nWork";
                button1.Visible = button2.Visible = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = button2.Visible = false;
            label1.Text = "I knew it! :3";
            label1.Location = new Point(58, 76);
        }
    }
}
