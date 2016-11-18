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
    public partial class PrinterForm : Form
    {
        int returnCode_open = -1;
        int returnCode_claim = -1;
        int returnCode_release = -1;
        int returnCode_close = -1;

        string[] rkey_ptr = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\POSPrinter").GetValueNames();
        string[] rkey_ptrSub = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\OLEforRetail\ServiceOPOS\POSPrinter").GetSubKeyNames();

        string defaultReciptText =
                "매출전표(고객용)\n" +
                "우리 체크                    신용승인\n" +
                "거래일시               16-11-10 10:56\n" +
                "카드 번호      6275-****-****-****(S)\n" +
                "가맹점 번호                 123456789\n" +
                "승인번호                         9876\n" +
                "매입사:비씨  (전자서명전표)          \n" +
                "-------------------------------------\n" +
                "판매금액                     92,728원\n" +
                "부가가치세                    9,272원\n" +
                "봉사료                            0원\n" +
                "합  계                      102,000원\n" +
                "-------------------------------------\n" +
                "가맹점명                 OPOS프로젝트\n" +
                "사업자번호               201611101056\n" +
                "대표자명:홍길동     TEL:010-1234-5678\n" +
                "주소:서울시 동대문구                 \n" +
                "-------------------------------------\n" +
                "CATID:20161110    전표No:201611101056\n" +
                "감사합니다.                          \n";

        string printText = "";

        Boolean isDefaultText = true;

        public PrinterForm()
        {
            InitializeComponent();
            init();        
        }


        private void PrinterForm_Load(object sender, EventArgs e)
        {
            ldn_cb.Items.AddRange(rkey_ptr);
            ldn_cb.Items.AddRange(rkey_ptrSub);
            ldn_cb.SelectedIndex = 0;
        }

        private void init()
        {
            
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            returnCode_open = axOPOSPOSPrinter1.Open(ldn_cb.Text);
            close_btn.Enabled = true;

            if (sender.Equals(open_btn))
            {
                returnCode_claim = axOPOSPOSPrinter1.ClaimDevice(500);
                axOPOSPOSPrinter1.DeviceEnabled = true;
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if(sender.Equals(close_btn))
            {
                axOPOSPOSPrinter1.DeviceEnabled = false;
                returnCode_release = axOPOSPOSPrinter1.ReleaseDevice();
            }
            returnCode_close = axOPOSPOSPrinter1.Close();
        }

        private void dClaim_btn_Click(object sender, EventArgs e)
        {
            returnCode_claim = axOPOSPOSPrinter1.ClaimDevice(500);
        }

        private void dEnable_btn_Click(object sender, EventArgs e)
        {
            axOPOSPOSPrinter1.DeviceEnabled = true;
        }

        private void dDisable_btn_Click(object sender, EventArgs e)
        {
            axOPOSPOSPrinter1.DeviceEnabled = false;
        }

        private void dRelease_btn_Click(object sender, EventArgs e)
        {
            returnCode_release = axOPOSPOSPrinter1.ReleaseDevice();
        }

        private void simpleMode_chkb_CheckedChanged(object sender, EventArgs e)
        {
            dClaim_btn.Enabled = false;
            dEnable_btn.Enabled = false;
            dDisable_btn.Enabled = false;
            dRelease_btn.Enabled = false;
            dClose_btn.Enabled = false;
            if (simpleMode_chkb.Checked)
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
            else
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
        }

        private void repeatNum_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            //BackSpace allowable
            if (e.KeyChar == '\b') return;
            //Don't allow a value other than number  
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void defualtTxt_btn_Click(object sender, EventArgs e)
        {
            isDefaultText = true;
            printTxt_rtb.Text = defaultReciptText;
            string filePath = @"Logo.bmp";

            logoFileDialog.ShowDialog();
            filePath = logoFileDialog.FileName;

            int res = axOPOSPOSPrinter1.SetBitmap(1, OPOS_Constant.PTR_S_RECEIPT, filePath, OPOS_Constant.PTR_BM_ASIS, OPOS_Constant.PTR_BM_CENTER);
            int res2 = axOPOSPOSPrinter1.PrintNormal(OPOS_Constant.PTR_S_RECEIPT, OPOS_Constant.ESC + "|1B" + OPOS_Constant.ESC + "|100fP");
               

            printTxt_rtb.Text += res + "\n" + res2;
        }

        private void openfile_btn_Click(object sender, EventArgs e)
        {
            isDefaultText = false;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(openFileDialog.FileName, System.Text.Encoding.UTF8, true);
                printText = sr.ReadToEnd();
                printTxt_rtb.Text = printText;
                sr.Close();
            }
        }

        private void printTest_btn_Click(object sender, EventArgs e)
        {
            int repeatNum = int.Parse(repeatNum_tb.Text);
            if (isDefaultText)
            {
                printText = defaultReciptText;
            }
            for (int i = 0; i < repeatNum; i++)
            {
                int ret = axOPOSPOSPrinter1.PrintNormal(OPOS_Constant.PTR_S_RECEIPT,
                    OPOS_Constant.ESC + "|cA" + printText + OPOS_Constant.ESC + "|100fP");
            }
        }

        private void papercut_btn_Click(object sender, EventArgs e)
        {
            axOPOSPOSPrinter1.CutPaper(OPOS_Constant.PTR_CP_FULLCUT);
        }

        private void clearResult_btn_Click(object sender, EventArgs e)
        {
            returnCodeOpn_rtb.Text = "Return Code ( )";
            returnCodeClm_rtb.Text = "Return Code ( )";
            returnCodeEnable_rtb.Text = "Return Code ( )";
            returnCodeDis_rtb.Text = "Return Code ( )";
            returnCodeRel_rtb.Text = "Return Code ( )";
            returnCodeCls_rtb.Text = "Return Code ( )";
        }
    }
}
