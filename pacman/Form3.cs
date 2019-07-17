using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pacman
{
    public partial class Form3 : Form
    {
        private Form1 main;

        public Form3(Form1 m)
        {
            main = m;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_Resize(object sender, EventArgs e)
        {
            if (Size.Width > Size.Height)
            {
                Size = new Size(Size.Width, Size.Width);
            }
            else
            {
                Size = new Size(Size.Height, Size.Height);
            }
            up.Size = down.Size = left.Size = right.Size = new Size(Size.Width / 10 * 3, Size.Height / 10 * 3);
        }

        private void s_MouseDown(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            if (!main.pressedSensorButtons.Contains(b))
            {
                main.pressedSensorButtons.Add(b);
            }
        }

        private void s_MouseUp(object sender, MouseEventArgs e)
        {
            Button b = sender as Button;
            if (main.pressedSensorButtons.Contains(b))
            {
                main.pressedSensorButtons.Remove(b);
            }
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (main.started)
            {
                main.playing = !main.playing;
                main.moving = false;
            }
        }

        private void info_Click(object sender, EventArgs e)
        {
            if (!main.started)
            {
                return;
            }
            main.toggleInfo();
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            if (!main.started)
            {
                return;
            }
            main.reset();
        }
    }
}
