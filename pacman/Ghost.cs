using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace pacman
{
    public class Ghost
    {
        public delegate void OnPlayedKilled(Ghost g);

        private Form1 main;
        private PictureBox el;

        private Bitmap skin1, skin2;

        private bool alive = true;
        private string name;
        private int direction = 0;
        private int DontCheckOtherWay = 0;
        private int speed = 3;
        private int k = 50;
        private int invisibleStep = 2;
        private int t = 0;
        public long time = 0;

        const int DONT_CHECK_OTHER_WAY = 100;

        public Ghost(Point pos, Bitmap s1, Bitmap s2, string n, Form1 m)
        {
            this.main = m;
            this.el = new PictureBox();
            this.main.area.Controls.Add(this.el);
            this.el.Image = s1;
            this.el.Location = pos;
            this.el.Name = n;
            this.name = n;
            this.el.Size = new Size(40, 40);
            this.el.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.el.BringToFront();
            this.skin1 = s1;
            this.skin2 = s2;

            this.SetDirection(1);
            this.SetDifficulty(main.difficulty);
            this.time = Form1.GetTime() + this.main.ghostRand.Next(3000, 6000);
        }

        public Point GetPosition()
        {
            return this.el.Location;
        }

        public string GetName()
        {
            return this.name;
        }

        public int[,] GetBordersOfGhost()
        {
            int thickness = 43;
            int[,] result;
            result = new int[2, 2] { { this.el.Location.X - thickness, this.el.Location.Y - thickness }, { this.el.Location.X + thickness, this.el.Location.Y + thickness } };
            return result;
        }

        private bool Move(PictureBox entity, Point newPosition)
        {
            bool isInsideOfArea = Form1.isInsideOf(newPosition, this.main.borders);
            if (!isInsideOfArea)
            {
                return false;
            }
            bool isNoWall = true;
            int[,] wallBorder;
            foreach (Panel wall in this.main.walls)
            {
                wallBorder = this.main.GetBordersOfObject(wall, true);

                if (Form1.isInsideOf(newPosition, wallBorder))
                {
                    isNoWall = false;
                    break;
                }
            }
            if (isNoWall)
            {
                foreach (Panel wall in this.main.ag_walls)
                {
                    wallBorder = this.main.GetBordersOfObject(wall, true);

                    if (Form1.isInsideOf(newPosition, wallBorder))
                    {
                        isNoWall = false;
                        break;
                    }
                }
            }
            return (isInsideOfArea && isNoWall);
        }

        private Point GetNewPositionByDirection(int dir, int a)
        {
            Point pos = this.el.Location;
            if (dir == 0)
            {
                return new Point(pos.X, pos.Y - a);
            }
            if (dir == 1)
            {
                return new Point(pos.X + a, pos.Y);
            }
            if (dir == 2)
            {
                return new Point(pos.X, pos.Y + a);
            }
            if (dir == 3)
            {
                return new Point(pos.X - a, pos.Y);
            }

            return new Point(pos.X, pos.Y);
        }

        public void SetDifficulty(int dif)
        {
            if (!this.alive)
            {
                return;
            }

            switch (dif)
            {
                case 0:
                    speed = 3;
                    this.el.Visible = true;
                    break;

                case 1:
                    speed = 4;
                    this.el.Visible = true;
                    break;

                case 2:
                    speed = 3;
                    this.time = Form1.GetTime() + 3000;
                    invisibleStep = 2;
                    break;
            }
        }

        public void SetVisible()
        {
            this.el.Visible = true;
        }

        public void AI()
        {
            if (!this.alive)
            {
                return;
            }
            if (main.difficulty == 2 && Form1.GetTime() >= this.time)
            {
                if (invisibleStep == 0)
                {
                    t = 1;
                    invisibleStep = 1;
                    this.el.Visible = false;
                    this.time = Form1.GetTime() + 250;
                }
                else if (invisibleStep == 1)
                {
                    this.el.Visible = !this.el.Visible;
                    t++;
                    if (t >= 10)
                    {
                        this.time = Form1.GetTime() + 75;
                    }
                    else
                    {
                        this.time = Form1.GetTime() + 250;
                    }

                    if (t == 30)
                    {
                        invisibleStep = 2;
                        this.el.Visible = false;
                        this.time = Form1.GetTime() + this.main.ghostRand.Next(3000, 6000);
                    }
                }
                else if (invisibleStep == 2)
                {
                    invisibleStep = 0;
                    this.time = Form1.GetTime() + this.main.ghostRand.Next(6000, 15000);
                    this.el.Visible = true;
                }
            }
            PictureBox entity = this.el;
            Point pos = entity.Location;
            Point newPosition, newPosition1, newPosition2;
            bool checkOtherWay = false;

            newPosition = GetNewPositionByDirection(direction, speed);
            newPosition2 = GetNewPositionByDirection(direction, 10);
            if (DontCheckOtherWay > 0)
            {
                DontCheckOtherWay--;
            }
            else
            {
                //DontCheckOtherWay = DONT_CHECK_OTHER_WAY;
            }
            if (Move(entity, newPosition2))
            {
                //DontCheckOtherWay--;
                if (DontCheckOtherWay == 0 && this.main.ghostRand.Next(1, 5) == 3)
                {
                    // Если повезёт, призрак свернёт
                    if (this.main.ghostRand.Next(1, 5) == 3)
                    {
                        // Призрак свернёт вправо, если в данный момент идёт вверх или вниз
                        if (direction == 0 || direction == 2)
                        {
                            newPosition1 = new Point(pos.X + speed, pos.Y); // dir 1
                            newPosition2 = new Point(pos.X + k, pos.Y);
                        }
                        // Призрак свернёт вниз, если в данный момент идёт вправо или влево
                        else
                        {
                            newPosition1 = new Point(pos.X, pos.Y + speed); // dir 2
                            newPosition2 = new Point(pos.X, pos.Y + k);
                        }
                        if (Move(entity, newPosition2))
                        {
                            checkOtherWay = false;
                            entity.Location = newPosition1;
                            DontCheckOtherWay = DONT_CHECK_OTHER_WAY;
                            if (direction == 0 || direction == 2)
                            {
                                SetDirection(1);
                            }
                            else
                            {
                                SetDirection(2);
                            }
                        }
                        else
                        {
                            checkOtherWay = true;
                        }
                    }
                    else
                    {
                        checkOtherWay = true;
                    }

                    if (checkOtherWay)
                    {
                        // Призрак свернёт влево, если в данный момент идёт вверх или вниз
                        if (direction == 0 || direction == 2)
                        {
                            newPosition1 = new Point(pos.X - speed, pos.Y);
                            newPosition2 = new Point(pos.X - k, pos.Y);
                        }
                        // Призрак свернёт вверх, если в данный момент идёт вправо или влево
                        else
                        {
                            newPosition1 = new Point(pos.X, pos.Y - speed);
                            newPosition2 = new Point(pos.X, pos.Y - k);
                        }
                        if (Move(entity, newPosition2))
                        {
                            checkOtherWay = false;
                            entity.Location = newPosition1;
                            DontCheckOtherWay = DONT_CHECK_OTHER_WAY;
                            if (direction == 0 || direction == 2)
                            {
                                SetDirection(3);
                            }
                            else
                            {
                                SetDirection(0);
                            }
                        }
                        else
                        {
                            entity.Location = newPosition;
                            checkOtherWay = true;
                        }
                    }
                }
                else
                {
                    //checkOtherWay = true;
                    entity.Location = newPosition;
                }
            }
            else
            {
                switch (direction)
                {
                    case 0:
                    case 2:
                        if (this.main.ghostRand.Next(1, 5) == 3)
                        {
                            SetDirection(1);
                        }
                        else
                        {
                            SetDirection(3);
                        }
                        break;

                    case 1:
                    case 3:
                        if (this.main.ghostRand.Next(1, 5) == 3)
                        {
                            SetDirection(0);
                        }
                        else
                        {
                            SetDirection(2);
                        }
                        break;
                }
            }

            /*if (direction == 0)
            {
                newPosition = new Point(pos.X, pos.Y - speed);

                if (Move(entity, newPosition))
                {
                    if (rand.Next(0, 100) > 49)
                    {
                        if (rand.Next(0, 100) > 49)
                        {
                            newPosition1 = new Point(pos.X + speed, pos.Y);
                            if (Move(entity, newPosition1))
                            {
                                checkOtherWay = false;
                                entity.Location = newPosition1;
                                direction = 1;
                            }
                            else
                            {
                                checkOtherWay = true;
                            }
                        }
                        else
                        {
                            checkOtherWay = true;
                        }

                        if (checkOtherWay)
                        {
                            newPosition1 = new Point(pos.X - speed, pos.Y);
                            if (Move(entity, newPosition1))
                            {
                                checkOtherWay = false;
                                entity.Location = newPosition1;
                                direction = 3;
                            }
                            else
                            {
                                checkOtherWay = true;
                            }
                        }
                    }
                    else
                    {
                        checkOtherWay = true;
                    }

                    if (checkOtherWay)
                    {
                        direction = 2;
                    }
                }
            }*/
        }

        private void SetDirection(int d)
        {
            switch (d)
            {
                case 0:
                    direction = 0;
                    break;

                case 1:
                    direction = 1;
                    this.el.Image = skin2;
                    break;

                case 2:
                    direction = 2;
                    break;

                case 3:
                    direction = 3;
                    this.el.Image = skin1;
                    break;
            }
        }

        public void Remove()
        {
            if (!this.alive)
            {
                return;
            }
            this.main.area.Controls.Remove(this.el);
            this.el.Dispose();
            this.alive = false;
        }

        public bool IsGhostAlive()
        {
            return this.alive;
        }
    }
}
