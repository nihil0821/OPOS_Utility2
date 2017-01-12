using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace OPOS_Utility
{
    public partial class LineDisplayForm : Form
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

        string[] rkey_cdp = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\LineDisplay").GetValueNames();
        string[] rkey_cdpSub = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\LineDisplay").GetSubKeyNames();


        Int32 row = 0, colum = 0;
        int count = 19;

        string dispTxt ; //전체 길이 데이터
        StringBuilder dispTxtBuilder; //데이터 담을 변수

        public LineDisplayForm()
        {
            InitializeComponent();
            init();
        }

        private void LineDisplayForm_Load(object sender, EventArgs e)
        {
            ldn_cb.Items.AddRange(rkey_cdp);
            ldn_cb.Items.AddRange(rkey_cdpSub);
            ldn_cb.SelectedIndex = 0;
            axOPOSLineDisplay1.CreateControl();
        }

        private void init()
        {
            simpleMode_chkb.Checked = false;
            dispTxtBuilder = new StringBuilder();
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            try
            {
                returnCode_open = axOPOSLineDisplay1.Open(ldn_cb.Text);
                returnCodeOpn_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(returnCode_open);
                resultCodeOpn_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_open);

                returnCode_claim = axOPOSLineDisplay1.ClaimDevice(500);
                returnCodeClm_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(returnCode_claim);
                resultCodeClm_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_claim);

                axOPOSLineDisplay1.DeviceEnabled = true;
                resultCodeEnable_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_enable);

                if (returnCode_open == OPOS_ErrorConstant.OPOS_SUCCESS && returnCode_claim == OPOS_ErrorConstant.OPOS_SUCCESS)
                {
                    close_btn.Enabled = true;
                }
            }
            catch (System.Windows.Forms.AxHost.InvalidActiveXStateException)
            {
                MessageBox.Show("InvalidActiveXStateException!!");
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if (sender.Equals(close_btn))
            {
                axOPOSLineDisplay1.DeviceEnabled = false;
                resultCodeDis_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_disable);

                returnCode_release = axOPOSLineDisplay1.ReleaseDevice();
                returnCodeRel_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(returnCode_release);
                resultCodeRel_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_release);

                returnCode_close = axOPOSLineDisplay1.Close();
                returnCodeCls_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(returnCode_close);
                resultCodeCls_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_close);

                close_btn.Enabled = false;
            }
            else
            {
                returnCode_close = axOPOSLineDisplay1.Close();
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
            returnCode_open = axOPOSLineDisplay1.Open(ldn_cb.Text);
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
            returnCode_claim = axOPOSLineDisplay1.ClaimDevice(500);
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
            axOPOSLineDisplay1.DeviceEnabled = true;
            resultCodeEnable_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_enable);
        }

        private void dDisable_btn_Click(object sender, EventArgs e)
        {
            axOPOSLineDisplay1.DeviceEnabled = false;
            resultCodeDis_rtb.Text = OPOS_ErrorConstant.return_ErrorMessage(resultCode_disable);
        }

        private void dRelease_btn_Click(object sender, EventArgs e)
        {
            returnCode_release = axOPOSLineDisplay1.ReleaseDevice();
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

        private void dispTest_btn_Click(object sender, EventArgs e)
        {
            string errorMessage;
            int returnCode;

            if (sender.Equals(oneLineTest_btn))
            {
                string displayText = defaultLineText_rtb.Text;
                returnCode = axOPOSLineDisplay1.DisplayText(displayText, OPOS_Constant.DISP_DT_NORMAL);
            }
            else if (sender.Equals(twoLineTest_btn))
            {
                string displayText1 = firstLineText_rtb.Text;
                string displayText2 = secondLineText_rtb.Text;
                Int32 row1 = 0, column1 = 0;


                returnCode = axOPOSLineDisplay1.DisplayTextAt(row1, column1, displayText1, OPOS_Constant.DISP_DT_NORMAL);
                returnCode = axOPOSLineDisplay1.DisplayTextAt(row1 + 1, column1, displayText2, OPOS_Constant.DISP_DT_NORMAL);
            }
            else if (sender.Equals(clearText_btn) || sender.Equals(clearText2_btn))
            {
                returnCode = axOPOSLineDisplay1.ClearText();
            }
            else
            {
                returnCode = -1;
            }

            errorMessage = OPOS_ErrorConstant.return_ErrorMessage(returnCode);

            if (sender.Equals(oneLineTest_btn)) { returnCode_disp_rtb.Text = errorMessage; }
            else if (sender.Equals(twoLineTest_btn)) { returnCode2_disp_rtb.Text = errorMessage; }
            else if (sender.Equals(clearText_btn)) { returnCode4_disp_rtb.Text = errorMessage; }
            else { returnCode = -1; }
        }

        private void flowTestStart_btn_Click(object sender, EventArgs e)
        {
            if (sender.Equals(flowTestStart_btn))
            {
                flowerLine_tmr.Enabled = true;
                dispTxt = flowLineText_rtb.Text;
            }
            if (sender.Equals(flowTestStop_btn))
            {
                flowerLine_tmr.Enabled = false;
                count = 19;
                dispTxtBuilder.Remove(0, dispTxtBuilder.ToString().Length);
            }
        }

        private void dispTxtFlow(object sender, EventArgs e)
        {
            //int returnCode = axOPOSLineDisplay1.DisplayTextAt(row, colum, "NOHDG FLOW TEXT TEST", OPOS_Constant.DISP_DT_NORMAL);
            //colum++;
            //if (colum > 19) colum = 0;                   

            //i = count;
            //for(; i < 19; i++)
            //{
            //    colum = i;
            //    axOPOSLineDisplay1.DisplayTextAt(row, colum, dispTxt[i - count].ToString(), OPOS_Constant.DISP_DT_NORMAL);
            //}            
            //count--;
            //if (count < 0) count = 19;

            //dispTxtBuilder 출력할 스트링
            //dispTxt 전체 스트링
            int res = axOPOSLineDisplay1.DisplayText("                    ", OPOS_Constant.DISP_DT_NORMAL);
            dispTxtBuilder.Append(dispTxt[19-count]);            
            axOPOSLineDisplay1.DisplayTextAt(row, count, dispTxtBuilder.ToString(), OPOS_Constant.DISP_DT_NORMAL);
            count--;
            if (count < 0)
            {
                count = 19;
                dispTxtBuilder.Remove(0,dispTxtBuilder.ToString().Length);
            }
        }


    }
}
