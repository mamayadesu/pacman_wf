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
    public partial class Form2 : Form
    {
        private Form1 main;
        private bool showed = false;
        private bool dcft = true;

        public Form2(Form1 m)
        {
            this.main = m;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            difficultyCb.SelectedIndex = 0;
        }

        private void difficultyCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (difficultyCb.SelectedIndex)
            {
                case 0:
                    difficultyInfo.Text = "Призраки передвигаются с такой же скоростью,\nкак и Пакман.";
                    this.main.SetDifficulty(0);
                    break;

                case 1:
                    difficultyInfo.Text = "Призраки передвигаются быстрее Пакмана.";
                    this.main.SetDifficulty(1);
                    break;

                case 2:
                    difficultyInfo.Text = "Призраки передвигаются с такой же скоростью,\nкак и Пакман, но время от времени на несколько\nсекунд становятся невидимыми.";
                    this.main.SetDifficulty(2);
                    break;
            }
            if (dcft)
            {
                main.wasDifficultyChanged = false;
            }
            dcft = false;
        }

        public bool IsShowed()
        {
            return showed;
        }

        public void ShowSettings()
        {
            if (showed)
            {
                return;
            }

            this.Show();
            showed = true;
        }

        public void HideSettings()
        {
            if (!showed)
            {
                return;
            }

            this.Hide();
            showed = false;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!main.__CLOSING__)
            {
                e.Cancel = true;
            }
        }

        private void continueGame_Click(object sender, EventArgs e)
        {
            this.main.playing = true;
        }

        private void closeGame_Click(object sender, EventArgs e)
        {
            if (this.main.intro1)
            {
                this.main.intro.Close();
                return;
            }
            this.main.Close();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.main.playing = true;
            }
        }

        private void sensor_CheckedChanged(object sender, EventArgs e)
        {
            this.main.sensorControlWindow.Visible = sensor.Checked;
        }
    }
}
