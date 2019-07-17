using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace pacman
{
    public partial class Form0 : Form
    {
        string[] args;

        public Form0(string[] a)
        {
            args = a;
            InitializeComponent();
        }

        Label ul;

        private string t1 = "SHARAGA GAMES ПРЕДСТАВЛЯЕТ...";
        private string t21 = "PACWOMA";
        private string t22 = "PACME";
        private string t23 = "PACMAN.EXE";
        private string t3 = "START GAME";
        private int tt1 = 0;
        private int tt2 = 0;
        private int tt3 = 0;

        private bool a = false, b = false;
        private bool ulforceinvisible = false;

        private int sleep = 0;
        private int step = 1;
        private int r1, g1, b1, r2, g2, b2;

        private long runAfter;

        private Form1 mainWindow;

        private void Form0_Load(object sender, EventArgs e)
        {
            ul = underline1;
            r1 = g1 = b1 = r2 = g2 = b2 = 0;
            runAfter = Form1.GetTime() + 2000;
            title1.Text = "";
            title2.Text = "";
            title3.Text = "";
            this.Show();
        }

        private void Sleep(int a)
        {
            sleep += a;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (sleep > 0)
            {
                sleep--;
                return;
            }
            if (args.Contains("--novid") && step != 6)
            {
                // Skipping
                Sleep(5);
                step = 6;
                return;
            }

            if (step == 1)
            {
                if (runAfter > Form1.GetTime())
                {
                    return;
                }

                tt1++;
                title1.Text = t1.Substring(0, tt1);

                if (tt1 >= t1.Length)
                {
                    step = 2;
                    is2.Visible = true;
                    ul = underline2;
                    underline1.Visible = false;
                    runAfter = Form1.GetTime() + 1000;
                    a = false;
                    return;
                }

                Sleep(5);
            }

            if (step == 2)
            {
                if (runAfter > Form1.GetTime())
                {
                    return;
                }

                if (tt2 >= t21.Length && a != true)
                {
                    ul = underline5;
                    underline2.Visible = false;
                    Sleep(50);
                    a = true;
                    return;
                }

                if (a == false)
                {
                    tt2++;
                    title2.Text = t21.Substring(0, tt2);
                }

                if (a)
                {
                    tt2--;
                    title2.Text = t21.Substring(0, tt2);
                    Sleep(5);
                    ulforceinvisible = true;
                    ul.Visible = false;
                    if (tt2 == 0)
                    {
                        ulforceinvisible = false;
                        //ul.Visible = true;
                        ul = underline2;
                        underline5.Visible = false;
                        step = 3;
                        runAfter = Form1.GetTime() + 1000;
                        a = false;
                        return;
                    }
                    return;
                }

                Sleep(5);
            }

            if (step == 3)
            {
                if (runAfter > Form1.GetTime())
                {
                    return;
                }

                ul.Visible = false;

                /*if (tt2 >= t22.Length && a != true)
                {
                    ul = underline6;
                    underline2.Visible = false;
                    Sleep(50);
                    b = true;
                    a = true;
                    return;
                }*/

                if (a == false && b == false)
                {
                    tt2++;
                    title2.Text = t22.Substring(0, tt2);
                    if (tt2 >= t22.Length)
                    {
                        ul = underline7;
                        underline2.Visible = false;
                        Sleep(100);
                        b = true;
                        a = true;
                        return;
                    }
                }

                if (a)
                {
                    tt2--;
                    title2.Text = t22.Substring(0, tt2);
                    Sleep(5);
                    if (tt2 == 3)
                    {
                        ul = underline6;
                        underline7.Visible = false;
                        Sleep(20);
                        step = 4;
                        runAfter = Form1.GetTime() + 2000;
                        a = false;
                        return;
                    }
                    return;
                }

                Sleep(10);
            }

            if (step == 4)
            {
                if (runAfter > Form1.GetTime())
                {
                    return;
                }
                tt2++;
                title2.Text = t23.Substring(0, tt2);
                underline6.Visible = false;
                if (tt2 >= t23.Length)
                {
                    ulforceinvisible = false;
                    step = 5;
                    runAfter = Form1.GetTime() + 2000;
                    ul = underline8;
                    Sleep(20);
                    return;
                }
                else
                {
                    ulforceinvisible = true;
                }

                Sleep(10);
            }

            if (step == 5)
            {
                if (runAfter > Form1.GetTime())
                {
                    return;
                }
                if (ul != underline3)
                {
                    ul = underline3;
                    Sleep(40);
                    is3.Visible = true;
                    return;
                }
                underline6.Visible = false;
                underline8.Visible = false;
                tt3++;
                title3.Text = t3.Substring(0, tt3);
                if (tt3 >= t3.Length)
                {
                    ul = underline9;
                    underline3.Visible = false;
                    Sleep(50);
                    step = 6;
                    return;
                } 

                Sleep(10);
            }

            if (step == 6)
            {
                if (!loading.Visible)
                {
                    loading.Visible = true;
                    Sleep(10);
                    return;
                }
                mainWindow = new Form1(this, args);
                mainWindow.Show();
                mainWindow.__INTRO__();
                this.Visible = false;
                timer.Enabled = false;
                timer1.Enabled = false;
            }
        }

        private void Form0_FormClosing(object sender, FormClosingEventArgs e)
        {
            //throw new NullReferenceException();
        }

        private void Form0_KeyDown(object sender, KeyEventArgs e)
        {
            // Skipping
            loading.Visible = true;
            step = 6;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!ulforceinvisible)
            {
                ul.Visible = !ul.Visible;
            }
            else
            {
                ul.Visible = false;
            }
        }
    }
}
