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
    public partial class DEVCONSOLE : Form
    {
        Form1 mf;

        public DEVCONSOLE(Form1 mainform)
        {
            mf = mainform;
            InitializeComponent();
        }

        private void DEVCONSOLE_Load(object sender, EventArgs e)
        {
            vsgType.SelectedIndex = 0;
            vsgBoolValue.Location = vsgValue.Location;
            vsgBoolValue.SelectedIndex = 0;
            vsgNull.Location = vsgValue.Location;
        }

        private void vsgValue_TextChanged(object sender, EventArgs e)
        {
            switch (vsgType.SelectedIndex)
            {
                case 4:
                case 1:
                    vsgValue.Visible = true;
                    vsgBoolValue.Visible = false;
                    vsgNull.Visible = false;
                    vsgValue.Text = Form1.StringOnlyNumericSymbols(vsgValue.Text, false, true);
                    break;

                case 2:
                    vsgValue.Visible = true;
                    vsgBoolValue.Visible = false;
                    vsgNull.Visible = false;
                    vsgValue.Text = Form1.StringOnlyNumericSymbols(vsgValue.Text, true, true);
                    break;

                case 3:
                    vsgValue.Visible = false;
                    vsgBoolValue.Visible = true;
                    vsgNull.Visible = false;
                    break;

                case 5:
                    vsgValue.Visible = false;
                    vsgNull.Visible = true;
                    vsgBoolValue.Visible = false;
                    break;
            }
            setDone.Visible = false;
        }

        private void vsgSet_Click(object sender, EventArgs e)
        {
            if (vsgVarName.Text == "")
            {
                MessageBox.Show("Input var name!");
                return;
            }

            if (vsgValue.Text == "" && (vsgType.SelectedIndex == 1 || vsgType.SelectedIndex == 2))
            {
                MessageBox.Show("Input value!");
                return;
            }

            switch (vsgType.SelectedIndex)
            {
                case 1:
                    try
                    {
                        mf.GetType().GetField(vsgVarName.Text).SetValue((object)mf, Convert.ToInt32(vsgValue.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Console Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 2:
                    try
                    {
                        mf.GetType().GetField(vsgVarName.Text).SetValue((object)mf, Convert.ToDouble(vsgValue.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Console Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 3:
                    try
                    {
                        mf.GetType().GetField(vsgVarName.Text).SetValue((object)mf, (vsgBoolValue.SelectedIndex == 0));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Console Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 4:
                    try
                    {
                        mf.GetType().GetField(vsgVarName.Text).SetValue((object)mf, Convert.ToInt64(vsgValue.Text));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Console Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 5:
                    try
                    {
                        mf.GetType().GetField(vsgVarName.Text).SetValue((object)mf, null);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Console Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

            }
            setDone.Visible = true;
        }

        private void DEVCONSOLE_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !mf.__CLOSING__;
        }

        private void vsgGet_Click(object sender, EventArgs e)
        {
            if (vsgVarName.Text == "")
            {
                MessageBox.Show("Input var name!");
                return;
            }
            string output;
            try
            {
                output = Convert.ToString(mf.GetType().GetField(vsgVarName.Text).GetValue((object)mf));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Console Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(output);
        }
    }
}
