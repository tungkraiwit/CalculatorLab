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
        float num1 = 0, num2 = 0, num3 = 0, num4 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnX_Click(object sender, EventArgs e)
        {            
            Button btn = (Button)sender;
            if (lblDisplay.Text == "0")
            {
                lblDisplay.Text = "";
            }
            if (lblDisplay.Text.Length < 8)
            {
                lblDisplay.Text = lblDisplay.Text + btn.Text ;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "";
            num1 = 0;
            num2 = 0; 
        }

        private void btnY_Click(object sender, EventArgs e)
        {
           Button btn = (Button)sender;
            if (btn.Text == "=")
            {
                num2 = float.Parse(lblDisplay.Text);
                if (num4 == 1)
                {
                    num3 = num1 + num2;
                }
                if (num4 == 2)
                {
                    num3 = num1 - num2;
                }
                if (num4 == 3)
                {
                    num3 = num1 * num2;
                }
                if (num4 == 4)
                {
                    num3 = num1 / num2;
                }
                lblDisplay.Text = Convert.ToString(num3);
                num1 = 0;
                num2 = 0;
                num3 = 0;
                num4 = 0;
            }
            if(btn.Text =="+")
            {
                num1 = float.Parse(lblDisplay.Text);
                if(num1 != 0)
                {
                    num2 = float.Parse(lblDisplay.Text);
                    num3 = num1 + num2;
                }
                lblDisplay.Text = "";
                num4 = 1;
            }
            if (btn.Text == "-")
            {
                num1 = float.Parse(lblDisplay.Text);
                if (num1 != 0)
                {
                    num2 = float.Parse(lblDisplay.Text);
                    num3 = num1 - num2;
                }
                lblDisplay.Text = "";
                num4 = 2;
            }
            if (btn.Text == "X")
            {
                num1 = float.Parse(lblDisplay.Text);
                if (num1 != 0)
                {
                    num2 = float.Parse(lblDisplay.Text);
                    num3 = num1 * num2;
                }
                lblDisplay.Text = "";
                num4 = 3;
            }
            if (btn.Text == "÷")
            {
                num1 = float.Parse(lblDisplay.Text);
                if (num1 != 0)
                {
                    num2 = float.Parse(lblDisplay.Text);
                    num3 = num1 / num2;
                }
                lblDisplay.Text = "";
                num4 = 4;
            }
        }
    }
}
