using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hours, billingRate, grossPay, federalTax, stateTax, netPay;
            string name;
            string ssn;


            name = txtName.Text;
            ssn = txtSSN.Text;
            
           
            try
            {
                int ssnNumber = int.Parse(ssn);
                if (name.Length != 0 && ssn.Length != 0)
                {
                    hours = Convert.ToDouble(txtHrs.Text);
                    billingRate = Convert.ToDouble(txtBR.Text);

                    grossPay = hours * billingRate;
                    federalTax = grossPay * 0.15;
                    stateTax = grossPay * 0.0765;
                    netPay = grossPay - (federalTax + stateTax);

                    txtGross.Text = grossPay.ToString("c");
                    txtFed.Text = federalTax.ToString("c");
                    txtState.Text = stateTax.ToString("c");
                    txtNet.Text = netPay.ToString("c");
                }
                else
                {
                    MessageBox.Show("Name and SSN field should be a valid input");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ssn should be a numeric value");
            }
            
        }
    }
}
