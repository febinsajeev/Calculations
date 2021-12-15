using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculations
{
    public partial class CalculationForm : Form
    {
        private object textBoxProduct;

        public CalculationForm()
        {
            InitializeComponent();
        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {

            decimal amountBalance = 0;
            decimal amountProduct = 0;
            decimal amountReceived = 0;
            decimal[] currencyCounter;
            amountProduct = Convert.ToDecimal(textBox1.Text);
            amountReceived = Convert.ToDecimal(textBox2.Text);
            amountBalance = amountReceived - amountProduct;
            Console.WriteLine("Balance Amount(\u00A3): " + amountBalance);
            if (amountBalance > 0)
            {

                CurrencyCalculation.countCurrency(amountBalance, out currencyCounter);

            }
            else
            {

                Console.ReadLine();
            }

        }

    }
}
