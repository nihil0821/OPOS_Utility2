namespace OPOS_Utility
{
    partial class ScannerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScannerForm));
            this.scn_gb = new System.Windows.Forms.GroupBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.dataEventEnabled_btn = new System.Windows.Forms.Button();
            this.scandata_rtb = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.currentDevice_rtb = new System.Windows.Forms.RichTextBox();
            this.clearResult_btn = new System.Windows.Forms.Button();
            this.ldn_rtb = new System.Windows.Forms.RichTextBox();
            this.open_btn = new System.Windows.Forms.Button();
            this.simpleMode_chkb = new System.Windows.Forms.CheckBox();
            this.ldn_cb = new System.Windows.Forms.ComboBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.dOpen_btn = new System.Windows.Forms.Button();
            this.dClaim_btn = new System.Windows.Forms.Button();
            this.dEnable_btn = new System.Windows.Forms.Button();
            this.dDisable_btn = new System.Windows.Forms.Button();
            this.dRelease_btn = new System.Windows.Forms.Button();
            this.dClose_btn = new System.Windows.Forms.Button();
            this.resultCodeEnable_rtb = new System.Windows.Forms.RichTextBox();
            this.returnCodeClm_rtb = new System.Windows.Forms.RichTextBox();
            this.returnCodeOpn_rtb = new System.Windows.Forms.RichTextBox();
            this.resultCodeCls_rtb = new System.Windows.Forms.RichTextBox();
            this.returnCodeRel_rtb = new System.Windows.Forms.RichTextBox();
            this.returnCodeCls_rtb = new System.Windows.Forms.RichTextBox();
            this.resultCodeDis_rtb = new System.Windows.Forms.RichTextBox();
            this.resultCodeRel_rtb = new System.Windows.Forms.RichTextBox();
            this.resultCodeOpn_rtb = new System.Windows.Forms.RichTextBox();
            this.resultCodeClm_rtb = new System.Windows.Forms.RichTextBox();
            this.axOPOSScanner1 = new AxOposScanner_CCO.AxOPOSScanner();
            this.scn_gb.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSScanner1)).BeginInit();
            this.SuspendLayout();
            // 
            // scn_gb
            // 
            this.scn_gb.Controls.Add(this.richTextBox4);
            this.scn_gb.Controls.Add(this.dataEventEnabled_btn);
            this.scn_gb.Controls.Add(this.scandata_rtb);
            this.scn_gb.Location = new System.Drawing.Point(278, 5);
            this.scn_gb.Name = "scn_gb";
            this.scn_gb.Size = new System.Drawing.Size(363, 485);
            this.scn_gb.TabIndex = 15;
            this.scn_gb.TabStop = false;
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.Color.MistyRose;
            this.richTextBox4.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.richTextBox4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox4.Location = new System.Drawing.Point(6, 19);
            this.richTextBox4.Multiline = false;
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(351, 44);
            this.richTextBox4.TabIndex = 38;
            this.richTextBox4.Text = "Scanner Scan";
            // 
            // dataEventEnabled_btn
            // 
            this.dataEventEnabled_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataEventEnabled_btn.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataEventEnabled_btn.Location = new System.Drawing.Point(6, 251);
            this.dataEventEnabled_btn.Name = "dataEventEnabled_btn";
            this.dataEventEnabled_btn.Size = new System.Drawing.Size(156, 42);
            this.dataEventEnabled_btn.TabIndex = 27;
            this.dataEventEnabled_btn.Text = "DataEventEnabled";
            this.dataEventEnabled_btn.UseVisualStyleBackColor = false;
            this.dataEventEnabled_btn.Click += new System.EventHandler(this.dataEventEnabled_btn_Click);
            // 
            // scandata_rtb
            // 
            this.scandata_rtb.BackColor = System.Drawing.Color.Gold;
            this.scandata_rtb.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.scandata_rtb.Location = new System.Drawing.Point(6, 85);
            this.scandata_rtb.MaxLength = 30;
            this.scandata_rtb.Name = "scandata_rtb";
            this.scandata_rtb.Size = new System.Drawing.Size(351, 54);
            this.scandata_rtb.TabIndex = 8;
            this.scandata_rtb.Text = "Scanning Barcode";
            this.scandata_rtb.Click += new System.EventHandler(this.scandata_rtb_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.currentDevice_rtb);
            this.groupBox1.Controls.Add(this.clearResult_btn);
            this.groupBox1.Controls.Add(this.ldn_rtb);
            this.groupBox1.Controls.Add(this.open_btn);
            this.groupBox1.Controls.Add(this.simpleMode_chkb);
            this.groupBox1.Controls.Add(this.ldn_cb);
            this.groupBox1.Controls.Add(this.close_btn);
            this.groupBox1.Controls.Add(this.dOpen_btn);
            this.groupBox1.Controls.Add(this.dClaim_btn);
            this.groupBox1.Controls.Add(this.dEnable_btn);
            this.groupBox1.Controls.Add(this.dDisable_btn);
            this.groupBox1.Controls.Add(this.dRelease_btn);
            this.groupBox1.Controls.Add(this.dClose_btn);
            this.groupBox1.Controls.Add(this.resultCodeEnable_rtb);
            this.groupBox1.Controls.Add(this.returnCodeClm_rtb);
            this.groupBox1.Controls.Add(this.returnCodeOpn_rtb);
            this.groupBox1.Controls.Add(this.resultCodeCls_rtb);
            this.groupBox1.Controls.Add(this.returnCodeRel_rtb);
            this.groupBox1.Controls.Add(this.returnCodeCls_rtb);
            this.groupBox1.Controls.Add(this.resultCodeDis_rtb);
            this.groupBox1.Controls.Add(this.resultCodeRel_rtb);
            this.groupBox1.Controls.Add(this.resultCodeOpn_rtb);
            this.groupBox1.Controls.Add(this.resultCodeClm_rtb);
            this.groupBox1.Location = new System.Drawing.Point(2, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 485);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // currentDevice_rtb
            // 
            this.currentDevice_rtb.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.currentDevice_rtb.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.currentDevice_rtb.ForeColor = System.Drawing.SystemColors.WindowText;
            this.currentDevice_rtb.Location = new System.Drawing.Point(4, 15);
            this.currentDevice_rtb.Multiline = false;
            this.currentDevice_rtb.Name = "currentDevice_rtb";
            this.currentDevice_rtb.ReadOnly = true;
            this.currentDevice_rtb.Size = new System.Drawing.Size(249, 52);
            this.currentDevice_rtb.TabIndex = 24;
            this.currentDevice_rtb.Text = "Scanner";
            // 
            // clearResult_btn
            // 
            this.clearResult_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clearResult_btn.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.clearResult_btn.Location = new System.Drawing.Point(121, 445);
            this.clearResult_btn.Name = "clearResult_btn";
            this.clearResult_btn.Size = new System.Drawing.Size(126, 23);
            this.clearResult_btn.TabIndex = 30;
            this.clearResult_btn.Text = "Clear Result";
            this.clearResult_btn.UseVisualStyleBackColor = false;
            this.clearResult_btn.Click += new System.EventHandler(this.clearResult_btn_Click);
            // 
            // ldn_rtb
            // 
            this.ldn_rtb.BackColor = System.Drawing.Color.Cyan;
            this.ldn_rtb.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ldn_rtb.Location = new System.Drawing.Point(5, 71);
            this.ldn_rtb.MaxLength = 5;
            this.ldn_rtb.Multiline = false;
            this.ldn_rtb.Name = "ldn_rtb";
            this.ldn_rtb.ReadOnly = true;
            this.ldn_rtb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ldn_rtb.Size = new System.Drawing.Size(55, 25);
            this.ldn_rtb.TabIndex = 21;
            this.ldn_rtb.Text = "LDN";
            // 
            // open_btn
            // 
            this.open_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.open_btn.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.open_btn.Location = new System.Drawing.Point(9, 116);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(72, 156);
            this.open_btn.TabIndex = 5;
            this.open_btn.Text = "OPEN";
            this.open_btn.UseVisualStyleBackColor = false;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // simpleMode_chkb
            // 
            this.simpleMode_chkb.AutoSize = true;
            this.simpleMode_chkb.Location = new System.Drawing.Point(15, 450);
            this.simpleMode_chkb.Name = "simpleMode_chkb";
            this.simpleMode_chkb.Size = new System.Drawing.Size(99, 16);
            this.simpleMode_chkb.TabIndex = 23;
            this.simpleMode_chkb.Text = "Simple Mode";
            this.simpleMode_chkb.UseVisualStyleBackColor = true;
            this.simpleMode_chkb.CheckedChanged += new System.EventHandler(this.simpleMode_chkb_CheckedChanged);
            // 
            // ldn_cb
            // 
            this.ldn_cb.FormattingEnabled = true;
            this.ldn_cb.Location = new System.Drawing.Point(66, 73);
            this.ldn_cb.Name = "ldn_cb";
            this.ldn_cb.Size = new System.Drawing.Size(188, 20);
            this.ldn_cb.TabIndex = 15;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.close_btn.Enabled = false;
            this.close_btn.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.close_btn.Location = new System.Drawing.Point(9, 278);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(72, 156);
            this.close_btn.TabIndex = 6;
            this.close_btn.Text = "CLOSE";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // dOpen_btn
            // 
            this.dOpen_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dOpen_btn.Enabled = false;
            this.dOpen_btn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dOpen_btn.Location = new System.Drawing.Point(9, 116);
            this.dOpen_btn.Name = "dOpen_btn";
            this.dOpen_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dOpen_btn.Size = new System.Drawing.Size(93, 46);
            this.dOpen_btn.TabIndex = 18;
            this.dOpen_btn.Text = "O";
            this.dOpen_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dOpen_btn.UseVisualStyleBackColor = false;
            this.dOpen_btn.Click += new System.EventHandler(this.dOpen_btn_Click);
            // 
            // dClaim_btn
            // 
            this.dClaim_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dClaim_btn.Enabled = false;
            this.dClaim_btn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dClaim_btn.Location = new System.Drawing.Point(9, 171);
            this.dClaim_btn.Name = "dClaim_btn";
            this.dClaim_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dClaim_btn.Size = new System.Drawing.Size(93, 46);
            this.dClaim_btn.TabIndex = 19;
            this.dClaim_btn.Text = "C";
            this.dClaim_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dClaim_btn.UseVisualStyleBackColor = false;
            this.dClaim_btn.Click += new System.EventHandler(this.dClaim_btn_Click);
            // 
            // dEnable_btn
            // 
            this.dEnable_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dEnable_btn.Enabled = false;
            this.dEnable_btn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dEnable_btn.Location = new System.Drawing.Point(9, 226);
            this.dEnable_btn.Name = "dEnable_btn";
            this.dEnable_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dEnable_btn.Size = new System.Drawing.Size(93, 46);
            this.dEnable_btn.TabIndex = 20;
            this.dEnable_btn.Text = "E";
            this.dEnable_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dEnable_btn.UseVisualStyleBackColor = false;
            this.dEnable_btn.Click += new System.EventHandler(this.dEnable_btn_Click);
            // 
            // dDisable_btn
            // 
            this.dDisable_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dDisable_btn.Enabled = false;
            this.dDisable_btn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dDisable_btn.Location = new System.Drawing.Point(9, 278);
            this.dDisable_btn.Name = "dDisable_btn";
            this.dDisable_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dDisable_btn.Size = new System.Drawing.Size(93, 46);
            this.dDisable_btn.TabIndex = 24;
            this.dDisable_btn.Text = "D";
            this.dDisable_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dDisable_btn.UseVisualStyleBackColor = false;
            this.dDisable_btn.Click += new System.EventHandler(this.dDisable_btn_Click);
            // 
            // dRelease_btn
            // 
            this.dRelease_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dRelease_btn.Enabled = false;
            this.dRelease_btn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dRelease_btn.Location = new System.Drawing.Point(9, 333);
            this.dRelease_btn.Name = "dRelease_btn";
            this.dRelease_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dRelease_btn.Size = new System.Drawing.Size(93, 46);
            this.dRelease_btn.TabIndex = 25;
            this.dRelease_btn.Text = "R";
            this.dRelease_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dRelease_btn.UseVisualStyleBackColor = false;
            this.dRelease_btn.Click += new System.EventHandler(this.dRelease_btn_Click);
            // 
            // dClose_btn
            // 
            this.dClose_btn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dClose_btn.Enabled = false;
            this.dClose_btn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dClose_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dClose_btn.Location = new System.Drawing.Point(9, 388);
            this.dClose_btn.Name = "dClose_btn";
            this.dClose_btn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dClose_btn.Size = new System.Drawing.Size(93, 46);
            this.dClose_btn.TabIndex = 26;
            this.dClose_btn.Text = "C";
            this.dClose_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.dClose_btn.UseVisualStyleBackColor = false;
            this.dClose_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // resultCodeEnable_rtb
            // 
            this.resultCodeEnable_rtb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultCodeEnable_rtb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resultCodeEnable_rtb.ForeColor = System.Drawing.Color.Blue;
            this.resultCodeEnable_rtb.Location = new System.Drawing.Point(100, 251);
            this.resultCodeEnable_rtb.Multiline = false;
            this.resultCodeEnable_rtb.Name = "resultCodeEnable_rtb";
            this.resultCodeEnable_rtb.ReadOnly = true;
            this.resultCodeEnable_rtb.Size = new System.Drawing.Size(149, 21);
            this.resultCodeEnable_rtb.TabIndex = 24;
            this.resultCodeEnable_rtb.Text = "Result Code ( )";
            // 
            // returnCodeClm_rtb
            // 
            this.returnCodeClm_rtb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.returnCodeClm_rtb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.returnCodeClm_rtb.ForeColor = System.Drawing.Color.Blue;
            this.returnCodeClm_rtb.Location = new System.Drawing.Point(100, 172);
            this.returnCodeClm_rtb.Multiline = false;
            this.returnCodeClm_rtb.Name = "returnCodeClm_rtb";
            this.returnCodeClm_rtb.ReadOnly = true;
            this.returnCodeClm_rtb.Size = new System.Drawing.Size(149, 21);
            this.returnCodeClm_rtb.TabIndex = 23;
            this.returnCodeClm_rtb.Text = "Return Code ( )";
            // 
            // returnCodeOpn_rtb
            // 
            this.returnCodeOpn_rtb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.returnCodeOpn_rtb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.returnCodeOpn_rtb.ForeColor = System.Drawing.Color.Blue;
            this.returnCodeOpn_rtb.Location = new System.Drawing.Point(100, 118);
            this.returnCodeOpn_rtb.Multiline = false;
            this.returnCodeOpn_rtb.Name = "returnCodeOpn_rtb";
            this.returnCodeOpn_rtb.ReadOnly = true;
            this.returnCodeOpn_rtb.Size = new System.Drawing.Size(149, 21);
            this.returnCodeOpn_rtb.TabIndex = 22;
            this.returnCodeOpn_rtb.TabStop = false;
            this.returnCodeOpn_rtb.Text = "Return Code ( )";
            // 
            // resultCodeCls_rtb
            // 
            this.resultCodeCls_rtb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultCodeCls_rtb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resultCodeCls_rtb.ForeColor = System.Drawing.Color.Blue;
            this.resultCodeCls_rtb.Location = new System.Drawing.Point(100, 413);
            this.resultCodeCls_rtb.Multiline = false;
            this.resultCodeCls_rtb.Name = "resultCodeCls_rtb";
            this.resultCodeCls_rtb.ReadOnly = true;
            this.resultCodeCls_rtb.Size = new System.Drawing.Size(149, 21);
            this.resultCodeCls_rtb.TabIndex = 29;
            this.resultCodeCls_rtb.Text = "Result Code ( )";
            // 
            // returnCodeRel_rtb
            // 
            this.returnCodeRel_rtb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.returnCodeRel_rtb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.returnCodeRel_rtb.ForeColor = System.Drawing.Color.Blue;
            this.returnCodeRel_rtb.Location = new System.Drawing.Point(100, 334);
            this.returnCodeRel_rtb.Multiline = false;
            this.returnCodeRel_rtb.Name = "returnCodeRel_rtb";
            this.returnCodeRel_rtb.ReadOnly = true;
            this.returnCodeRel_rtb.Size = new System.Drawing.Size(149, 21);
            this.returnCodeRel_rtb.TabIndex = 28;
            this.returnCodeRel_rtb.Text = "Return Code ( )";
            // 
            // returnCodeCls_rtb
            // 
            this.returnCodeCls_rtb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.returnCodeCls_rtb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.returnCodeCls_rtb.ForeColor = System.Drawing.Color.Blue;
            this.returnCodeCls_rtb.Location = new System.Drawing.Point(100, 390);
            this.returnCodeCls_rtb.Multiline = false;
            this.returnCodeCls_rtb.Name = "returnCodeCls_rtb";
            this.returnCodeCls_rtb.ReadOnly = true;
            this.returnCodeCls_rtb.Size = new System.Drawing.Size(149, 21);
            this.returnCodeCls_rtb.TabIndex = 27;
            this.returnCodeCls_rtb.Text = "Return Code ( )";
            // 
            // resultCodeDis_rtb
            // 
            this.resultCodeDis_rtb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultCodeDis_rtb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resultCodeDis_rtb.ForeColor = System.Drawing.Color.Blue;
            this.resultCodeDis_rtb.Location = new System.Drawing.Point(100, 303);
            this.resultCodeDis_rtb.Multiline = false;
            this.resultCodeDis_rtb.Name = "resultCodeDis_rtb";
            this.resultCodeDis_rtb.ReadOnly = true;
            this.resultCodeDis_rtb.Size = new System.Drawing.Size(149, 21);
            this.resultCodeDis_rtb.TabIndex = 33;
            this.resultCodeDis_rtb.Text = "Result Code ( )";
            // 
            // resultCodeRel_rtb
            // 
            this.resultCodeRel_rtb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultCodeRel_rtb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resultCodeRel_rtb.ForeColor = System.Drawing.Color.Blue;
            this.resultCodeRel_rtb.Location = new System.Drawing.Point(100, 358);
            this.resultCodeRel_rtb.Multiline = false;
            this.resultCodeRel_rtb.Name = "resultCodeRel_rtb";
            this.resultCodeRel_rtb.ReadOnly = true;
            this.resultCodeRel_rtb.Size = new System.Drawing.Size(149, 21);
            this.resultCodeRel_rtb.TabIndex = 34;
            this.resultCodeRel_rtb.Text = "Result Code ( )";
            // 
            // resultCodeOpn_rtb
            // 
            this.resultCodeOpn_rtb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultCodeOpn_rtb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resultCodeOpn_rtb.ForeColor = System.Drawing.Color.Blue;
            this.resultCodeOpn_rtb.Location = new System.Drawing.Point(100, 141);
            this.resultCodeOpn_rtb.Multiline = false;
            this.resultCodeOpn_rtb.Name = "resultCodeOpn_rtb";
            this.resultCodeOpn_rtb.ReadOnly = true;
            this.resultCodeOpn_rtb.Size = new System.Drawing.Size(149, 21);
            this.resultCodeOpn_rtb.TabIndex = 31;
            this.resultCodeOpn_rtb.Text = "Result Code ( )";
            // 
            // resultCodeClm_rtb
            // 
            this.resultCodeClm_rtb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resultCodeClm_rtb.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.resultCodeClm_rtb.ForeColor = System.Drawing.Color.Blue;
            this.resultCodeClm_rtb.Location = new System.Drawing.Point(100, 196);
            this.resultCodeClm_rtb.Multiline = false;
            this.resultCodeClm_rtb.Name = "resultCodeClm_rtb";
            this.resultCodeClm_rtb.ReadOnly = true;
            this.resultCodeClm_rtb.Size = new System.Drawing.Size(149, 21);
            this.resultCodeClm_rtb.TabIndex = 32;
            this.resultCodeClm_rtb.Text = "Result Code ( )";
            // 
            // axOPOSScanner1
            // 
            this.axOPOSScanner1.Enabled = true;
            this.axOPOSScanner1.Location = new System.Drawing.Point(646, 494);
            this.axOPOSScanner1.Name = "axOPOSScanner1";
            this.axOPOSScanner1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axOPOSScanner1.OcxState")));
            this.axOPOSScanner1.Size = new System.Drawing.Size(192, 192);
            this.axOPOSScanner1.TabIndex = 25;
            this.axOPOSScanner1.DataEvent += new AxOposScanner_CCO._IOPOSScannerEvents_DataEventEventHandler(this.axOPOSScanner1_DataEvent);
            // 
            // ScannerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 494);
            this.ControlBox = false;
            this.Controls.Add(this.axOPOSScanner1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.scn_gb);
            this.Name = "ScannerForm";
            this.Load += new System.EventHandler(this.ScannerForm_Load);
            this.scn_gb.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSScanner1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox scn_gb;
        private System.Windows.Forms.Button dataEventEnabled_btn;
        private System.Windows.Forms.RichTextBox scandata_rtb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox currentDevice_rtb;
        private System.Windows.Forms.Button clearResult_btn;
        private System.Windows.Forms.RichTextBox ldn_rtb;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.CheckBox simpleMode_chkb;
        private System.Windows.Forms.ComboBox ldn_cb;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button dOpen_btn;
        private System.Windows.Forms.Button dClaim_btn;
        private System.Windows.Forms.Button dEnable_btn;
        private System.Windows.Forms.Button dDisable_btn;
        private System.Windows.Forms.Button dRelease_btn;
        private System.Windows.Forms.Button dClose_btn;
        private System.Windows.Forms.RichTextBox resultCodeEnable_rtb;
        private System.Windows.Forms.RichTextBox returnCodeClm_rtb;
        private System.Windows.Forms.RichTextBox returnCodeOpn_rtb;
        private System.Windows.Forms.RichTextBox resultCodeCls_rtb;
        private System.Windows.Forms.RichTextBox returnCodeRel_rtb;
        private System.Windows.Forms.RichTextBox returnCodeCls_rtb;
        private System.Windows.Forms.RichTextBox resultCodeDis_rtb;
        private System.Windows.Forms.RichTextBox resultCodeRel_rtb;
        private System.Windows.Forms.RichTextBox resultCodeOpn_rtb;
        private System.Windows.Forms.RichTextBox resultCodeClm_rtb;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private AxOposScanner_CCO.AxOPOSScanner axOPOSScanner1;
    }
}