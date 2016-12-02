namespace OPOS_Utility
{
    partial class MSRForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSRForm));
            this.msr_gb = new System.Windows.Forms.GroupBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox13 = new System.Windows.Forms.RichTextBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.msrResultCode_rtb = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.msrErrorLocus_rtb = new System.Windows.Forms.RichTextBox();
            this.msrRCExtended_rtb = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.expirationDate_rtb = new System.Windows.Forms.RichTextBox();
            this.firstName_rtb = new System.Windows.Forms.RichTextBox();
            this.surName_rtb = new System.Windows.Forms.RichTextBox();
            this.cardNum_rtb = new System.Windows.Forms.RichTextBox();
            this.track3_rtb = new System.Windows.Forms.RichTextBox();
            this.track2_rtb = new System.Windows.Forms.RichTextBox();
            this.track1_rtb = new System.Windows.Forms.RichTextBox();
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
            this.axOPOSMSR1 = new AxOposMSR_CCO.AxOPOSMSR();
            this.msr_gb.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSMSR1)).BeginInit();
            this.SuspendLayout();
            // 
            // msr_gb
            // 
            this.msr_gb.BackColor = System.Drawing.SystemColors.Control;
            this.msr_gb.Controls.Add(this.richTextBox4);
            this.msr_gb.Controls.Add(this.richTextBox6);
            this.msr_gb.Controls.Add(this.richTextBox13);
            this.msr_gb.Controls.Add(this.richTextBox8);
            this.msr_gb.Controls.Add(this.groupBox3);
            this.msr_gb.Controls.Add(this.groupBox2);
            this.msr_gb.Controls.Add(this.track3_rtb);
            this.msr_gb.Controls.Add(this.track2_rtb);
            this.msr_gb.Controls.Add(this.track1_rtb);
            this.msr_gb.Location = new System.Drawing.Point(278, 7);
            this.msr_gb.Name = "msr_gb";
            this.msr_gb.Size = new System.Drawing.Size(363, 483);
            this.msr_gb.TabIndex = 15;
            this.msr_gb.TabStop = false;
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
            this.richTextBox4.Text = "Card Reading";
            // 
            // richTextBox6
            // 
            this.richTextBox6.BackColor = System.Drawing.Color.Cyan;
            this.richTextBox6.Enabled = false;
            this.richTextBox6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.richTextBox6.Location = new System.Drawing.Point(5, 89);
            this.richTextBox6.Multiline = false;
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.ReadOnly = true;
            this.richTextBox6.Size = new System.Drawing.Size(52, 23);
            this.richTextBox6.TabIndex = 14;
            this.richTextBox6.Text = "Track1";
            // 
            // richTextBox13
            // 
            this.richTextBox13.BackColor = System.Drawing.Color.Cyan;
            this.richTextBox13.Enabled = false;
            this.richTextBox13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.richTextBox13.Location = new System.Drawing.Point(5, 145);
            this.richTextBox13.Multiline = false;
            this.richTextBox13.Name = "richTextBox13";
            this.richTextBox13.ReadOnly = true;
            this.richTextBox13.Size = new System.Drawing.Size(52, 23);
            this.richTextBox13.TabIndex = 16;
            this.richTextBox13.Text = "Track3";
            // 
            // richTextBox8
            // 
            this.richTextBox8.BackColor = System.Drawing.Color.Cyan;
            this.richTextBox8.Enabled = false;
            this.richTextBox8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.richTextBox8.Location = new System.Drawing.Point(5, 117);
            this.richTextBox8.Multiline = false;
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.ReadOnly = true;
            this.richTextBox8.Size = new System.Drawing.Size(52, 23);
            this.richTextBox8.TabIndex = 15;
            this.richTextBox8.Text = "Track2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.msrResultCode_rtb);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.msrErrorLocus_rtb);
            this.groupBox3.Controls.Add(this.msrRCExtended_rtb);
            this.groupBox3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox3.Location = new System.Drawing.Point(231, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(125, 190);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ErrorEvent";
            // 
            // msrResultCode_rtb
            // 
            this.msrResultCode_rtb.BackColor = System.Drawing.Color.LavenderBlush;
            this.msrResultCode_rtb.ForeColor = System.Drawing.Color.Red;
            this.msrResultCode_rtb.Location = new System.Drawing.Point(6, 53);
            this.msrResultCode_rtb.Multiline = false;
            this.msrResultCode_rtb.Name = "msrResultCode_rtb";
            this.msrResultCode_rtb.ReadOnly = true;
            this.msrResultCode_rtb.Size = new System.Drawing.Size(113, 23);
            this.msrResultCode_rtb.TabIndex = 29;
            this.msrResultCode_rtb.Text = "ResultCode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(4, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 11);
            this.label7.TabIndex = 28;
            this.label7.Text = "Error Locus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(4, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 11);
            this.label6.TabIndex = 27;
            this.label6.Text = "RC Extended";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(4, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 11);
            this.label5.TabIndex = 13;
            this.label5.Text = "Result";
            // 
            // msrErrorLocus_rtb
            // 
            this.msrErrorLocus_rtb.BackColor = System.Drawing.Color.LavenderBlush;
            this.msrErrorLocus_rtb.ForeColor = System.Drawing.Color.Red;
            this.msrErrorLocus_rtb.Location = new System.Drawing.Point(6, 147);
            this.msrErrorLocus_rtb.Multiline = false;
            this.msrErrorLocus_rtb.Name = "msrErrorLocus_rtb";
            this.msrErrorLocus_rtb.ReadOnly = true;
            this.msrErrorLocus_rtb.Size = new System.Drawing.Size(113, 23);
            this.msrErrorLocus_rtb.TabIndex = 26;
            this.msrErrorLocus_rtb.Text = "ResultCode";
            // 
            // msrRCExtended_rtb
            // 
            this.msrRCExtended_rtb.BackColor = System.Drawing.Color.LavenderBlush;
            this.msrRCExtended_rtb.ForeColor = System.Drawing.Color.Red;
            this.msrRCExtended_rtb.Location = new System.Drawing.Point(6, 100);
            this.msrRCExtended_rtb.Multiline = false;
            this.msrRCExtended_rtb.Name = "msrRCExtended_rtb";
            this.msrRCExtended_rtb.ReadOnly = true;
            this.msrRCExtended_rtb.Size = new System.Drawing.Size(113, 23);
            this.msrRCExtended_rtb.TabIndex = 25;
            this.msrRCExtended_rtb.Text = "ResultCode";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.expirationDate_rtb);
            this.groupBox2.Controls.Add(this.firstName_rtb);
            this.groupBox2.Controls.Add(this.surName_rtb);
            this.groupBox2.Controls.Add(this.cardNum_rtb);
            this.groupBox2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(5, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 190);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Card Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(7, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 11);
            this.label4.TabIndex = 12;
            this.label4.Text = "ExpirationDate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(7, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 11);
            this.label3.TabIndex = 11;
            this.label3.Text = "FirstName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 11);
            this.label2.TabIndex = 10;
            this.label2.Text = "Sur Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 11);
            this.label1.TabIndex = 9;
            this.label1.Text = "Card Num";
            // 
            // expirationDate_rtb
            // 
            this.expirationDate_rtb.BackColor = System.Drawing.Color.Cornsilk;
            this.expirationDate_rtb.Location = new System.Drawing.Point(6, 159);
            this.expirationDate_rtb.Multiline = false;
            this.expirationDate_rtb.Name = "expirationDate_rtb";
            this.expirationDate_rtb.ReadOnly = true;
            this.expirationDate_rtb.Size = new System.Drawing.Size(208, 23);
            this.expirationDate_rtb.TabIndex = 8;
            this.expirationDate_rtb.Text = "";
            // 
            // firstName_rtb
            // 
            this.firstName_rtb.BackColor = System.Drawing.Color.Cornsilk;
            this.firstName_rtb.Location = new System.Drawing.Point(6, 118);
            this.firstName_rtb.Multiline = false;
            this.firstName_rtb.Name = "firstName_rtb";
            this.firstName_rtb.ReadOnly = true;
            this.firstName_rtb.Size = new System.Drawing.Size(208, 23);
            this.firstName_rtb.TabIndex = 7;
            this.firstName_rtb.Text = "";
            // 
            // surName_rtb
            // 
            this.surName_rtb.BackColor = System.Drawing.Color.Cornsilk;
            this.surName_rtb.Location = new System.Drawing.Point(6, 77);
            this.surName_rtb.Multiline = false;
            this.surName_rtb.Name = "surName_rtb";
            this.surName_rtb.ReadOnly = true;
            this.surName_rtb.Size = new System.Drawing.Size(208, 23);
            this.surName_rtb.TabIndex = 6;
            this.surName_rtb.Text = "";
            // 
            // cardNum_rtb
            // 
            this.cardNum_rtb.BackColor = System.Drawing.Color.Cornsilk;
            this.cardNum_rtb.Location = new System.Drawing.Point(6, 36);
            this.cardNum_rtb.Multiline = false;
            this.cardNum_rtb.Name = "cardNum_rtb";
            this.cardNum_rtb.ReadOnly = true;
            this.cardNum_rtb.Size = new System.Drawing.Size(208, 23);
            this.cardNum_rtb.TabIndex = 5;
            this.cardNum_rtb.Text = "";
            // 
            // track3_rtb
            // 
            this.track3_rtb.BackColor = System.Drawing.Color.Gold;
            this.track3_rtb.Location = new System.Drawing.Point(53, 145);
            this.track3_rtb.Multiline = false;
            this.track3_rtb.Name = "track3_rtb";
            this.track3_rtb.ReadOnly = true;
            this.track3_rtb.Size = new System.Drawing.Size(303, 23);
            this.track3_rtb.TabIndex = 2;
            this.track3_rtb.Text = "";
            this.track3_rtb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.track_tb_MouseClick);
            // 
            // track2_rtb
            // 
            this.track2_rtb.BackColor = System.Drawing.Color.Gold;
            this.track2_rtb.Location = new System.Drawing.Point(53, 117);
            this.track2_rtb.Multiline = false;
            this.track2_rtb.Name = "track2_rtb";
            this.track2_rtb.ReadOnly = true;
            this.track2_rtb.Size = new System.Drawing.Size(303, 23);
            this.track2_rtb.TabIndex = 1;
            this.track2_rtb.Text = "";
            this.track2_rtb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.track_tb_MouseClick);
            // 
            // track1_rtb
            // 
            this.track1_rtb.BackColor = System.Drawing.Color.Gold;
            this.track1_rtb.Location = new System.Drawing.Point(53, 89);
            this.track1_rtb.Multiline = false;
            this.track1_rtb.Name = "track1_rtb";
            this.track1_rtb.ReadOnly = true;
            this.track1_rtb.Size = new System.Drawing.Size(303, 23);
            this.track1_rtb.TabIndex = 0;
            this.track1_rtb.Text = "";
            this.track1_rtb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.track_tb_MouseClick);
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
            this.currentDevice_rtb.Text = "MSR";
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
            // axOPOSMSR1
            // 
            this.axOPOSMSR1.Enabled = true;
            this.axOPOSMSR1.Location = new System.Drawing.Point(2, 497);
            this.axOPOSMSR1.Name = "axOPOSMSR1";
            this.axOPOSMSR1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axOPOSMSR1.OcxState")));
            this.axOPOSMSR1.Size = new System.Drawing.Size(192, 192);
            this.axOPOSMSR1.TabIndex = 25;
            this.axOPOSMSR1.DataEvent += new AxOposMSR_CCO._IOPOSMSREvents_DataEventEventHandler(this.axOPOSMSR1_DataEvent);
            this.axOPOSMSR1.ErrorEvent += new AxOposMSR_CCO._IOPOSMSREvents_ErrorEventEventHandler(this.axOPOSMSR1_ErrorEvent);
            // 
            // MSRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 494);
            this.ControlBox = false;
            this.Controls.Add(this.axOPOSMSR1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.msr_gb);
            this.Name = "MSRForm";
            this.Load += new System.EventHandler(this.MSRForm_Load);
            this.msr_gb.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axOPOSMSR1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox msr_gb;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox13;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox msrResultCode_rtb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox msrErrorLocus_rtb;
        private System.Windows.Forms.RichTextBox msrRCExtended_rtb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox expirationDate_rtb;
        private System.Windows.Forms.RichTextBox firstName_rtb;
        private System.Windows.Forms.RichTextBox surName_rtb;
        private System.Windows.Forms.RichTextBox cardNum_rtb;
        private System.Windows.Forms.RichTextBox track3_rtb;
        private System.Windows.Forms.RichTextBox track2_rtb;
        private System.Windows.Forms.RichTextBox track1_rtb;
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
        private AxOposMSR_CCO.AxOPOSMSR axOPOSMSR1;
        private System.Windows.Forms.RichTextBox richTextBox4;
    }
}