using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aug30
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double hours = Double.Parse(tbxHours.Text);
            double pay = Double.Parse(tbxPay.Text);

            if (Double.TryParse(tbxPay.Text, out pay))
            {
                double result = hours * pay;
                MessageBox.Show($" total amount is {result} ", "Click Event",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show($"You must enter a number", "Input Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxPay.Clear();
                lblOutput.Text = $"Your gross is {result}";
            }


            if (Double.TryParse(tbxHours.Text, out hours))
            {
                double result = hours * pay;
            }
            else
            {
                MessageBox.Show($"You must enter a number", "Input Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbxHours.Clear();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxHours.Text = "";
            tbxPay.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {


            System.Windows.Forms.Application.Exit();


        }
    }
}
