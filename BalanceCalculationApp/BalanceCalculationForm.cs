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
            int returnValue=  ValidateInputs(textBoxProduct.Text, textBoxAmountReceived.Text);
            if (returnValue == 1)
                return;
            
            decimal amountBalance = CalculateBalance(Convert.ToDecimal(textBoxProduct.Text), Convert.ToDecimal(textBoxAmountReceived.Text));
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
        /// <summary>
        /// Method to handle Validations 
        /// </summary>
        /// <param name="product"></param>
        /// <param name="amountreceived"></param>
        /// <returns></returns>
        public int ValidateInputs(string product,string amountreceived)
        {
            decimal result;
            if (textBoxProduct.Text == string.Empty || textBoxAmountReceived.Text == string.Empty)
            {
                MessageBox.Show("Product price & Amount received is mandatory!");
                return 1;
            }
            else if (!Decimal.TryParse(textBoxProduct.Text, out result) || !Decimal.TryParse(textBoxAmountReceived.Text, out result))
            {
                MessageBox.Show("Only numeric values are allowed");
                return 1;
            }

            return 0;

        }
        /// <summary>
        /// method to calculateBalance amount
        /// </summary>
        /// <param name="amountProduct"></param>
        /// <param name="amountReceived"></param>
        /// <returns></returns>
        public decimal CalculateBalance(decimal amountProduct = 0, decimal amountReceived = 0)
        {
            decimal amountBalance = 0;           
            amountProduct = Convert.ToDecimal(textBoxProduct.Text);
            amountReceived = Convert.ToDecimal(textBoxAmountReceived.Text);
            amountBalance = amountReceived - amountProduct;
            return amountBalance;

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
