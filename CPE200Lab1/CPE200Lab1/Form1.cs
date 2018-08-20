using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        float num1 = 999999999 , num2 = 999999999, num3 = 0 , num4 = 0 ,point = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void btnX_Click(object sender, EventArgs e)
        {            
            Button btn = (Button)sender;
            if (num3 == 0)
            {
                if (btn.Text == ".")
                {
                    if (point == 0)
                    {
                        lblDisplay.Text = lblDisplay.Text + btn.Text;
                        point = 1;
                    }
                }
                else
                {
                    if (lblDisplay.Text == "0")
                    {
                        lblDisplay.Text = "";
                    }
                    if (lblDisplay.Text.Length < 8)
                    {
                        lblDisplay.Text = lblDisplay.Text + btn.Text;

                    }
                }
            }
            else
            {
                lblDisplay.Text = btn.Text;
                num3 = 0;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
            num1 = 999999999;
            num2 = 999999999;
            num3 = 0;
            num4 = 0;
            point = 0;
        }
        private void btnY_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (num1 == 999999999)
            {
                num1 = float.Parse(lblDisplay.Text);
            }
            else
            {
                if (btn.Text == "%" && num4 != 3 && num4 != 4)
                {
                    num2 = (num1 / 100) * float.Parse(lblDisplay.Text);
                }
                else if(num4 == 3 || num4 == 4)
                {
                    num2 = float.Parse(lblDisplay.Text) / 100;
                }
                else
                {
                    num2 = float.Parse(lblDisplay.Text);
                }
            }
            if (num1 != 999999999 && num2 != 999999999 && btn.Text != "%")
            {
                if (num4 == 1)
                {
                    num1 = num1 + num2;
                }
                else if(num4 == 2)
                {
                    num1 = num1 - num2;
                }
                else if (num4 == 3)
                {
                    num1 = num1 * num2;
                }
                else if (num4 == 4)
                {
                    num1 = num1 / num2;
                }
            }
            if (btn.Text == "+")
            {
                num4 = 1;
                lblDisplay.Text = Convert.ToString(num1);
                num3 = 1;
                point = 0;
            }
            else if (btn.Text == "-")
            {
                num4 = 2;
                lblDisplay.Text = Convert.ToString(num1);
                num3 = 1;
                point = 0;
            }
            else if (btn.Text == "X")
            {
                num4 = 3;
                lblDisplay.Text = Convert.ToString(num1);
                num3 = 1;
                point = 0;
            }
            else if (btn.Text == "÷")
            {
                num4 = 4;
                lblDisplay.Text = Convert.ToString(num1);
                num3 = 1;
                point = 0;
            }
            else if (btn.Text == "%")
            {
                lblDisplay.Text = Convert.ToString(num2);
                num3 = 1;
                point = 0;
            }
            
        }
        private void btnZ_Click(object sender, EventArgs e)
        {
            if (num4 == 1)
            {
                lblDisplay.Text = Convert.ToString(num1 + float.Parse(lblDisplay.Text));
                num4 = 0;
            }
            if (num4 == 2)
            {
                lblDisplay.Text = Convert.ToString(num1 - float.Parse(lblDisplay.Text));
                num4 = 0;
            }
            if (num4 == 3)
            {
                lblDisplay.Text = Convert.ToString(num1 * float.Parse(lblDisplay.Text));
                num4 = 0;
            }
            if (num4 == 4)
            {
                lblDisplay.Text = Convert.ToString(num1 / float.Parse(lblDisplay.Text));
                num4 = 0;
            }
        }
    }
}
