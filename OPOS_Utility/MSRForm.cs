using Microsoft.Win32;
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
    public partial class MSRForm : Form
    {
        int returnCode_open = -1;
        int returnCode_claim = -1;
        int returnCode_release = -1;
        int returnCode_close = -1;
        int resultCode_open = 0;
        int resultCode_claim = 0;
        int resultCode_enable = 0;
        int resultCode_release = 0;
        int resultCode_close = 0;
        int resultCode_disable = 0;

        string[] rkey_msr = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\MSR").GetValueNames();
        string[] rkey_msrSub = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\MSR").GetSubKeyNames();       
        
        public MSRForm()
        {
            InitializeComponent();
            init();
        }

        private void MSRForm_Load(object sender, EventArgs e)
        {
            ldn_cb.Items.AddRange(rkey_msr);
            ldn_cb.Items.AddRange(rkey_msrSub);
            ldn_cb.SelectedIndex = 0;
        }

        private void init()
        {
            simpleMode_chkb.Checked = false;
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            returnCode_open = axOPOSMSR1.Open(ldn_cb.Text);
            returnCodeOpn_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(returnCode_open);
            resultCodeOpn_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_open);

            returnCode_claim = axOPOSMSR1.ClaimDevice(500);
            returnCodeClm_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(returnCode_claim);
            resultCodeClm_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_claim);

            axOPOSMSR1.DeviceEnabled = true;
            resultCodeEnable_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_enable);

            track1_rtb.Clear();
            track2_rtb.Clear();
            track3_rtb.Clear();

            if (returnCode_open == OPOS_ErrorConstant.OPOS_SUCCESS && returnCode_claim == OPOS_ErrorConstant.OPOS_SUCCESS)
            {
                close_btn.Enabled = true;
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if (sender.Equals(close_btn))
            {
                axOPOSMSR1.DeviceEnabled = false;
                resultCodeDis_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_disable);

                returnCode_release = axOPOSMSR1.ReleaseDevice();
                returnCodeRel_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(returnCode_release);
                resultCodeRel_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_release);

                returnCode_close = axOPOSMSR1.Close();
                returnCodeCls_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(returnCode_close);
                resultCodeCls_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_close);

                close_btn.Enabled = false;
            }
            else
            {
                returnCode_close = axOPOSMSR1.Close();
                returnCodeCls_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(returnCode_close);
                resultCodeCls_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_close);

                dClaim_btn.Enabled = false;
                dEnable_btn.Enabled = false;
                dDisable_btn.Enabled = false;
                dRelease_btn.Enabled = false;
                dClose_btn.Enabled = false;
            }
        }

        private void dOpen_btn_Click(object sender, EventArgs e)
        {
            returnCode_open = axOPOSMSR1.Open(ldn_cb.Text);
            returnCodeOpn_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(returnCode_open);
            resultCodeOpn_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_open);


            if (returnCode_open == OPOS_ErrorConstant.OPOS_SUCCESS)
            {
                dClaim_btn.Enabled = true;
                dClose_btn.Enabled = true;
            }
        }

        private void dClaim_btn_Click(object sender, EventArgs e)
        {
            returnCode_claim = axOPOSMSR1.ClaimDevice(500);
            returnCodeClm_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(returnCode_claim);
            resultCodeClm_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_claim);

            if (returnCode_claim == OPOS_ErrorConstant.OPOS_SUCCESS)
            {
                dEnable_btn.Enabled = true;
                dDisable_btn.Enabled = true;
                dRelease_btn.Enabled = true;
            }
        }

        private void dEnable_btn_Click(object sender, EventArgs e)
        {
            axOPOSMSR1.DeviceEnabled = true;
            resultCodeEnable_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_enable);
            track1_rtb.Clear();
            track2_rtb.Clear();
            track3_rtb.Clear();
        }

        private void dDisable_btn_Click(object sender, EventArgs e)
        {
            axOPOSMSR1.DeviceEnabled = false;
            resultCodeDis_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_disable);
        }

        private void dRelease_btn_Click(object sender, EventArgs e)
        {
            returnCode_release = axOPOSMSR1.ReleaseDevice();
            returnCodeRel_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(returnCode_release);
            resultCodeRel_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_release);
        }

        private void simpleMode_chkb_CheckedChanged(object sender, EventArgs e)
        {
            clearResult_btn_Click(sender, e);

            dClaim_btn.Enabled = false;
            dEnable_btn.Enabled = false;
            dDisable_btn.Enabled = false;
            dRelease_btn.Enabled = false;
            dClose_btn.Enabled = false;

            if (simpleMode_chkb.Checked)
            {
                open_btn.Visible = false;
                close_btn.Visible = false;
                dOpen_btn.Enabled = true;

                dOpen_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                dOpen_btn.Text = "Open";
                dClaim_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                dClaim_btn.Text = "Claim";
                dEnable_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                dEnable_btn.Text = "Enable";
                dDisable_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                dDisable_btn.Text = "Disable";
                dRelease_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                dRelease_btn.Text = "Release";
                dClose_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                dClose_btn.Text = "Close";
            }
            else
            {
                open_btn.Visible = true;
                close_btn.Visible = true;
                dOpen_btn.Enabled = false;

                dOpen_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                dOpen_btn.Text = "O";
                dClaim_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                dClaim_btn.Text = "C";
                dEnable_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                dEnable_btn.Text = "E";
                dDisable_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                dDisable_btn.Text = "D";
                dRelease_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                dRelease_btn.Text = "R";
                dClose_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                dClose_btn.Text = "C";
            }
        }

        private void clearResult_btn_Click(object sender, EventArgs e)
        {
            returnCodeOpn_rtb.Text = "Return Code ( )";
            returnCodeClm_rtb.Text = "Return Code ( )";
            returnCodeCls_rtb.Text = "Return Code ( )";
            returnCodeRel_rtb.Text = "Return Code ( )";


            resultCodeOpn_rtb.Text = "Result Code ( )";
            resultCodeClm_rtb.Text = "Result Code ( )";
            resultCodeEnable_rtb.Text = "Result Code ( )";
            resultCodeDis_rtb.Text = "Result Code ( )";
            resultCodeRel_rtb.Text = "Result Code ( )";
            resultCodeCls_rtb.Text = "Result Code ( )";
        }

        private void track_tb_MouseClick(object sender, MouseEventArgs e)
        {
            track1_rtb.Clear();
            track2_rtb.Clear();
            track3_rtb.Clear();
        }

        private void axOPOSMSR1_DataEvent(object sender, AxOposMSR_CCO._IOPOSMSREvents_DataEventEvent e)
        {
            string track1 = axOPOSMSR1.Track1Data;
            string track2 = axOPOSMSR1.Track2Data;
            string track3 = axOPOSMSR1.Track3Data;

            track1_rtb.Text = track1;
            track2_rtb.Text = track2;
            track3_rtb.Text = track3;

            cardNum_rtb.Text = axOPOSMSR1.AccountNumber;
            surName_rtb.Text = axOPOSMSR1.Surname;
            firstName_rtb.Text = axOPOSMSR1.FirstName;
            expirationDate_rtb.Text = axOPOSMSR1.ExpirationDate;

            msrResultCode_rtb.Text = "0";
            msrRCExtended_rtb.Text = "0";
            msrErrorLocus_rtb.Text = "0";

            axOPOSMSR1.DataEventEnabled = true;
        }

        private void axOPOSMSR1_ErrorEvent(object sender, AxOposMSR_CCO._IOPOSMSREvents_ErrorEventEvent e)
        {
            int res;
            int resCE;
            int errL;
            string resStr;
            string resCEStr;
            string errLStr;

            res = e.resultCode;
            resCE = e.resultCodeExtended;
            errL = e.errorLocus;

            resStr = OPOS_ErrorConstant.return_ErrorMessage(res);
            resCEStr = OPOS_ErrorConstant.return_ErrorMessage(resCE);
            errLStr = OPOS_ErrorConstant.return_ErrorMessage(errL);
            
            msrResultCode_rtb.Text = resStr;
            msrRCExtended_rtb.Text = resCEStr;
            msrErrorLocus_rtb.Text = errLStr;

            MessageBox.Show("Error Event!!");
        }
    }
}
