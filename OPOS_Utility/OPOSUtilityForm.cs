using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OPOS_Utility
{
    public partial class OPOSUtilityForm : Form
    {
        PrinterForm printerForm = new PrinterForm();
        CashDrawerForm cashDrawerForm = new CashDrawerForm();


        public OPOSUtilityForm()
        {
            InitializeComponent();
        }

        private void OPOSUtilityForm_Load(object sender, EventArgs e)
        {
            printerForm.TopLevel = false;
            cashDrawerForm.TopLevel = false;

            this.Controls.Add(printerForm);
            this.Controls.Add(cashDrawerForm);

            printerForm.Parent = this.utilityPanel;
            printerForm.Dock = DockStyle.Fill;
            cashDrawerForm.Parent = this.utilityPanel;
            cashDrawerForm.Dock = DockStyle.Fill;

            printerForm.Show();
            cashDrawerForm.Hide();
        }

        private void ptr_btn_Click(object sender, EventArgs e)
        {
            printerForm.Show();
            cashDrawerForm.Hide();
        }

        private void cash_btn_Click(object sender, EventArgs e)
        {
            printerForm.Hide();
            cashDrawerForm.Show();
        }

        private void scan_btn_Click(object sender, EventArgs e)
        {
            printerForm.Hide();
            cashDrawerForm.Hide();
        }
    }
}
