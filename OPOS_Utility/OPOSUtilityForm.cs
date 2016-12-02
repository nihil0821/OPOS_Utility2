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
        ScannerForm scannerForm = new ScannerForm();
        MSRForm msrForm = new MSRForm();
        LineDisplayForm dispFrom = new LineDisplayForm();


        public OPOSUtilityForm()
        {
            InitializeComponent();
        }

        private void OPOSUtilityForm_Load(object sender, EventArgs e)
        {
            printerForm.TopLevel = false;
            scannerForm.TopLevel = false;
            msrForm.TopLevel = false;
            dispFrom.TopLevel = false;
            cashDrawerForm.TopLevel = false;

            this.Controls.Add(printerForm);
            this.Controls.Add(scannerForm);
            this.Controls.Add(msrForm);
            this.Controls.Add(dispFrom);
            this.Controls.Add(cashDrawerForm);        


            printerForm.Parent = this.utilityPanel;
            printerForm.Dock = DockStyle.Fill;

            scannerForm.Parent = this.utilityPanel;
            scannerForm.Dock = DockStyle.Fill;

            msrForm.Parent = this.utilityPanel;
            msrForm.Dock = DockStyle.Fill;

            dispFrom.Parent = this.utilityPanel;
            dispFrom.Dock = DockStyle.Fill;

            cashDrawerForm.Parent = this.utilityPanel;
            cashDrawerForm.Dock = DockStyle.Fill;


            printerForm.Show();
            scannerForm.Hide();
            msrForm.Hide();
            dispFrom.Hide();
            cashDrawerForm.Hide();
        }

        private void ptr_btn_Click(object sender, EventArgs e)
        {
            printerForm.Show();
            scannerForm.Hide();
            msrForm.Hide();
            dispFrom.Hide();
            cashDrawerForm.Hide();
        }

        private void scan_btn_Click(object sender, EventArgs e)
        {
            printerForm.Hide();
            scannerForm.Show();
            msrForm.Hide();
            dispFrom.Hide();
            cashDrawerForm.Hide();
        }

        private void msr_btn_Click(object sender, EventArgs e)
        {
            printerForm.Hide();
            scannerForm.Hide();
            msrForm.Show();
            dispFrom.Hide();
            cashDrawerForm.Hide();
        }

        private void disp_btn_Click(object sender, EventArgs e)
        {
            printerForm.Hide();
            scannerForm.Hide();
            msrForm.Hide();
            dispFrom.Show();
            cashDrawerForm.Hide();
        }

        private void cash_btn_Click(object sender, EventArgs e)
        {
            printerForm.Hide();
            scannerForm.Hide();
            msrForm.Hide();
            dispFrom.Hide();
            cashDrawerForm.Show();
        } 
        
        
    }
}
