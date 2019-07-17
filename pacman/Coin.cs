using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace pacman
{
    public class Coin
    {

        public delegate void OnPickedUp(Coin c);
        public delegate void OnDelete(Coin c);

        private PictureBox el;
        private Form1 main;
        private bool isStillExists = true;
        private int state = 0;

        public Coin(PictureBox pb, Form1 m)
        {
            this.main = m;
            this.el = pb;
            this.el.Visible = true;
            this.state = 0;
            this.el.Image = global::pacman.Properties.Resources.coin1;
        }

        public Coin(Point pos, string name, Form1 m)
        {
            this.main = m;
            this.el = new PictureBox();
            this.main.area.Controls.Add(this.el);
            this.el.Image = global::pacman.Properties.Resources.coin1;
            this.el.Location = pos;
            this.el.Name = name;
            this.el.Size = new Size(16, 16);
            this.el.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        public void PickUp(OnPickedUp callback)
        {
            if (!isStillExists)
            {
                return;
            }
            callback(this);
        }

        public void Delete(OnDelete c, bool removePictureBox)
        {
            if (!isStillExists)
            {
                return;
            }
            if (removePictureBox)
            {
                this.main.area.Controls.Remove(this.el);
                this.el.Dispose();
            }
            else
            {
                this.el.Visible = false;
            }
            this.isStillExists = false;
        }

        public void Animation()
        {
            if (state == 0)
            {
                this.el.Image = global::pacman.Properties.Resources.coin2;
                state = 1;
            }
            else
            {
                this.el.Image = global::pacman.Properties.Resources.coin1;
                state = 0;
            }
        }

        public bool IsExists()
        {
            return isStillExists;
        }

        public PictureBox GetElement()
        {
            return this.el;
        }
    }
}
