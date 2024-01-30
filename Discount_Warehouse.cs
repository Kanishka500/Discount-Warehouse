using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_01
{
    public partial class Discount_Warehouse : Form
    {
        public Discount_Warehouse()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            // Declare variables
            int originalPrice = 0;
            double discountRates, discount, discountPrice = 0;

            // Read input and Store in variables
            originalPrice = int.Parse(original_priceTxt.Text);
            discountRates = double.Parse(discount_ratesTxt.Text);

            // Calculation
            discount = originalPrice * (discountRates / 100);
            discountPrice = originalPrice - discount;

            // Display Result
            discountTxt.Text = discount.ToString();
            discount_priceTxt.Text = discountPrice.ToString();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
