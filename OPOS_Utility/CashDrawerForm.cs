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
    public partial class CashDrawerForm : Form
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

        string[] rkey_cash = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\CashDrawer").GetValueNames();
        string[] rkey_cashSub = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\CashDrawer").GetSubKeyNames();

        //CashDrawer Test var
        int intervalNum = 1000;
        int repeatNum = 0;
        int currentRepeatNum = 0;

        public CashDrawerForm()
        {
            InitializeComponent();
            init();
        }

        private void CashDrawerForm_Load(object sender, EventArgs e)
        {
            ldn_cb.Items.AddRange(rkey_cash);
            ldn_cb.Items.AddRange(rkey_cashSub);
            ldn_cb.SelectedIndex = 0;

        }

        private void init()
        {
            simpleMode_chkb.Checked = false;
            timer_gb.Enabled = false;
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            returnCode_open = axOPOSCashDrawer1.Open(ldn_cb.Text);
            returnCodeOpn_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(returnCode_open);
            resultCodeOpn_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_open);

            returnCode_claim = axOPOSCashDrawer1.ClaimDevice(500);
            returnCodeClm_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(returnCode_claim);
            resultCodeClm_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_claim);

            axOPOSCashDrawer1.DeviceEnabled = true;
            resultCodeEnable_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_enable);

            if (returnCode_open == OPOS_ErrorConstant.OPOS_SUCCESS && returnCode_claim == OPOS_ErrorConstant.OPOS_SUCCESS)
            {
                close_btn.Enabled = true;
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if (sender.Equals(close_btn))
            {
                axOPOSCashDrawer1.DeviceEnabled = false;
                resultCodeDis_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_disable);

                returnCode_release = axOPOSCashDrawer1.ReleaseDevice();
                returnCodeRel_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(returnCode_release);
                resultCodeRel_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_release);

                returnCode_close = axOPOSCashDrawer1.Close();
                returnCodeCls_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(returnCode_close);
                resultCodeCls_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_close);

                close_btn.Enabled = false;
            }
            else
            {
                returnCode_close = axOPOSCashDrawer1.Close();
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
            returnCode_open = axOPOSCashDrawer1.Open(ldn_cb.Text);
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
            returnCode_claim = axOPOSCashDrawer1.ClaimDevice(500);
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
            axOPOSCashDrawer1.DeviceEnabled = true;
            resultCodeEnable_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_enable);
        }

        private void dDisable_btn_Click(object sender, EventArgs e)
        {
            axOPOSCashDrawer1.DeviceEnabled = false;
            resultCodeDis_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_disable);
        }

        private void dRelease_btn_Click(object sender, EventArgs e)
        {
            returnCode_release = axOPOSCashDrawer1.ReleaseDevice();
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

        private void openDrawer_btn_Click(object sender, EventArgs e)
        {
            if (timerMode_cb.Checked)
            {
                if (currentRepeatNum > 0)
                {

                    int res = axOPOSCashDrawer1.OpenDrawer();
                    currentRepeatNum--;
                    currentRepeat_rtb.Text = currentRepeatNum + "";

                }
                else
                {
                    timerStop_btn.Enabled = false;
                    timerMode_cb.Enabled = true;
                    currentRepeatNum = repeatNum;
                    cashTimer.Enabled = false;
                }
            }
            else
            {
                int res = axOPOSCashDrawer1.OpenDrawer();
            }
        }

        private void timerMode_cb_CheckedChanged(object sender, EventArgs e)
        {
            if (timerMode_cb.Checked)
            {
                timer_gb.Enabled = true;
            }
            else
            {
                timer_gb.Enabled = false;
            }
        }

        private void interRepet_KeyPress(object sender, KeyPressEventArgs e)
        {
            //BackSpace allowable
            if (e.KeyChar == '\b') return;
            //Don't allow a value other than number  
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;

            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                if (sender.Equals(interval_rtb))
                {
                    MessageBox.Show("Enter Key pressed1");
                    if (!interval_rtb.Text.Equals("")) // 공백이 아닐 때만
                    {
                        intervalNum = int.Parse(interval_rtb.Text);
                        currentInterval_rtb.Text = interval_rtb.Text;
                        interval_rtb.Clear();
                    }
                    else //공백일 시 디폴트로 설정
                    {
                        intervalNum = 1000;
                        currentInterval_rtb.Text = 1000 + "";
                    }
                }
                else
                {
                    MessageBox.Show("Enter Key pressed2");

                    if (!repeatNum_rtb.Text.Equals("")) // 공백이 아닐 때만
                    {
                        repeatNum = int.Parse(repeatNum_rtb.Text);
                        currentRepeat_rtb.Text = repeatNum_rtb.Text;
                        currentRepeatNum = repeatNum;
                    }
                    else //공백일 시 디폴트로 설정
                    {
                        repeatNum = 1;
                        currentRepeat_rtb.Text = 1 + "";
                    }
                }
            }
        }

        private void timerStart_btn_Click(object sender, EventArgs e)
        {
            cashTimer.Enabled = true;
            cashTimer.Interval = intervalNum;
            timerStop_btn.Enabled = true;
            timerMode_cb.Enabled = false;
        }

        private void timerStop_btn_Click(object sender, EventArgs e)
        {
            cashTimer.Enabled = false;
            timerStop_btn.Enabled = false;
            timerMode_cb.Enabled = true;
        }

        
    }
}
