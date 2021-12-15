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

        private void calculate_Click(object sender, EventArgs e)
        {
            decimal amountBalance = 0;
            decimal amountProduct = 0;
            decimal amountReceived = 0;
            decimal[] currencyCounter;
            decimal result;
            ArrayList values = new ArrayList();
            if (textBoxProduct.Text == string.Empty || textBoxAmountReceived.Text == string.Empty)
            {
                MessageBox.Show("Product price & Amount received is mandatory!");
                return;
            }           
            else if (!Decimal.TryParse(textBoxProduct.Text, out result)|| !Decimal.TryParse(textBoxAmountReceived.Text, out result))
            {
                MessageBox.Show("Only numeric values are allowed");
                return;
            }
            amountProduct = Convert.ToDecimal(textBoxProduct.Text);
            amountReceived = Convert.ToDecimal(textBoxAmountReceived.Text);
            amountBalance = amountReceived - amountProduct;
            labelBalance.Text = amountBalance.ToString();
            labelDenominations.Text = "";
            if (amountBalance > 0)
            {
                labelBalance.ForeColor = Color.White;
                values = CurrencyCalculation.countCurrency(amountBalance, out currencyCounter);
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
