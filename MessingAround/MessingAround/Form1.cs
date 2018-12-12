using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessingAround
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double hours = Convert.ToDouble(txtHours.Text);
            double rate = Convert.ToDouble(txtRate.Text);
            double regularPay = 0;
            double otPay = 0;
            double otRate = 0;
            double otHours = 0;
            double totalPay = 0;

            if(hours <= 40)
            {
                regularPay = rate * hours;
                totalPay = regularPay;
            }

            if (hours > 40)
            {
                otHours = hours - 40;
                otRate = rate * 1.5;
                otPay = otRate * otHours;
                regularPay = rate * 40;
                totalPay = regularPay + otPay;
            }
            
            

            lblResult.Text = "Hours: " + hours + "\nRate: " + rate.ToString("C") + "\nRegular Pay: " + regularPay.ToString("C") + "\nOvertime Hours: " + otHours + "\nOvertime Rate: " + otRate.ToString("C") + "\nOvertime Pay: " + otPay.ToString("C") + "\nTotal Pay: " + totalPay.ToString("C");
        }
    }
}
