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
            if (TryParseFromTextBox(tbxHours, out double hours) &&
                TryParseFromTextBox(tbxPay, out double pay))
            {
                double result = hours * pay;
                //MessageBox.Show($" total amount is {result} ", "Click Event",
                //   MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                lblOutput.Text = $"Your gross is {result}";

            }
        }

        public bool TryParseFromTextBox(TextBox control, out double value)
        {
            if (!double.TryParse(control.Text, out value))
            {
                MessageBox.Show($"You must enter a number in {control.Name}", "Input Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);

                control.Clear();
                return false;
            }
            return true;
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
