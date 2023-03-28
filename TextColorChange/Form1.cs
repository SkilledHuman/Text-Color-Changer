using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextColorChange
{
    public partial class Form1 : Form
    {
        string color = null;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            lblColor.Text = "Selected color: Red";
            color = "red";
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            lblColor.Text = "Selected color: Green";
            color = "green";
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            lblColor.Text = "Selected color: Blue";
            color = "blue";
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            lblColor.Text = "Selected color: Yellow";
            color = "yellow";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
              switch (color)
              {
                 case "red": label1.ForeColor = Color.Red;
                     break;
                 case "green": label1.ForeColor = Color.Green;
                     break;
                 case "blue": label1.ForeColor = Color.Blue;
                     break;
                 case "yellow": label1.ForeColor = Color.Yellow;
                     break;
              }

            if(color == null)
            {
                label1.ForeColor = colorDialog1.Color;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblColor.Text = "Selected color: None";
            color = null;
        }

        private void btnColorDiag_Click(object sender, EventArgs e)
        {
            color = null;
            colorDialog1.ShowDialog();
            string dialogColor = colorDialog1.Color.ToString();
            lblColor.Text = "Selected color: " + dialogColor;
        }
    }
}
