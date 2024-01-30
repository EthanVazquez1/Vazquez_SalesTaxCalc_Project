using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vazquez_SalesTaxCalc_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cboWarranty.SelectedIndex = 0;
            cboState.SelectedIndex = 0;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal baseCost = decimal.Parse(txtBasePrice.Text);

            decimal Warranty = 0;

            if (cboWarranty.SelectedIndex == 0)
            {
                Warranty = 0;
            }
            else if (cboWarranty.SelectedIndex == 1)
            {
                Warranty = 1000;
            }
            else if (cboWarranty.SelectedIndex == 2)
            {
                Warranty = 2000;
            }
            else if (cboWarranty.SelectedIndex == 3)
            {
                Warranty = 3000;
            }

           decimal subtotal = baseCost + Warranty;

            decimal State = 0;

            if (cboState.SelectedIndex == 0)
            {
                State = 1.086m;
            }
            else if(cboState.SelectedIndex == 1)
            {
                State = 1.0m;
            }

            decimal total = subtotal * State;

            lblTotal.Text = ("Total Vehicle Cost is: " + total.ToString("c"));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBasePrice.Text = string.Empty;
            cboWarranty.SelectedIndex = 0;
            cboState.SelectedIndex = 0;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
