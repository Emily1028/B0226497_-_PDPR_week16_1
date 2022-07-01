using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B0226497_段昱如_PDPR_week16_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int index = 0;
        List<Bitmap> b = new List<Bitmap>();
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i=0;i<4;i++)
            {
                b.Add(new Bitmap($"RUNNER{i + 1}.gif"));
            }
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox5.Left + pictureBox5.Width <= 0)
            {
                pictureBox5.Left = this.Width;
            }
            else
            {
                pictureBox5.Left -= 10;
            }
            if(index<b.Count-1)
            {
                index++;
            }
            else
            {
                index = 0;
            }
            pictureBox5.Image = b[index];
        }
    }
}
