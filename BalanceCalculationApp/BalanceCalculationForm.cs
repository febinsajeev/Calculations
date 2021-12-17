using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculations;

namespace BalanceCalculationApp
{
    public partial class BalanceCalculationForm : Form
    {
        public BalanceCalculationForm()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {         
            int returnValue = CurrencyCalculation.ValidateInputs(textBoxProduct.Text, textBoxAmountReceived.Text);
            if (returnValue == 1)
            {
                MessageBox.Show("Product price & Amount received is mandatory!");
                return;
            }
            else if(returnValue == 2)
            {
                MessageBox.Show("Only numeric values are allowed");
                return ;
            }               
            
            decimal amountBalance = CurrencyCalculation.CalculateBalance(Convert.ToDecimal(textBoxProduct.Text), Convert.ToDecimal(textBoxAmountReceived.Text));

            ArrayList values = new ArrayList();
            labelBalance.Text = amountBalance.ToString();
            labelDenominations.Text = "";
            if (amountBalance > 0)
            {
                labelBalance.ForeColor = Color.White;
                values = CurrencyCalculation.CountCurrency(amountBalance);
                labelDenominations.TextAlign = ContentAlignment.MiddleCenter;
                labelDenominations.ForeColor= Color.White;
                foreach (string x in values)
                {
                    labelDenominations.Text += x + "\n" +"\n";
                }
            }
            else
            {
                labelBalance.ForeColor = Color.Red;
            }
        }
        
        private void Reset_Click(object sender, EventArgs e)
        {
            textBoxProduct.Text = "";
            textBoxAmountReceived.Text = "";
            labelBalance.Text = "";
            labelDenominations.Text = "";          
        }
    }
}
