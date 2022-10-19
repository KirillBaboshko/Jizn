using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Jizn
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int resolition;
        private void StartGame()
        {
            if (timer1.Enabled)
            {
                return;
            }
            numDensity.Enabled = false;
            numResolution.Enabled = false;
            resolition = (int)numResolution.Value;
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(pictureBox1.Image);
            //graphics.FillRectangle(Brushes.Crimson, 0, 0, resolition, resolition);
            
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void bStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void bStop_Click(object sender, EventArgs e)
        {

        }
    }
}
