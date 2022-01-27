using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator {
    public partial class TipCalculator : Form {
        public TipCalculator() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void btnExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            decimal bill = Convert.ToDecimal(txtBill.Text);
            decimal tiprate = Convert.ToDecimal(txtTipRate.Text) / 100;
            decimal tip = bill * tiprate;
            decimal totalBill = tip + bill;
            txtTipAmount.Text = tip.ToString("c");
            txtTotalBill.Text = totalBill.ToString("c");
            Focus();
        }

        private void txtTipRate_TextChanged(object sender, EventArgs e) {

        }

        private void txtBill_TextChanged(object sender, EventArgs e) {
            
        }
    }
}
