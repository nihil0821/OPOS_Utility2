namespace OPOS_Utility
{
    partial class OPOSUtilityForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.utilityPanel = new System.Windows.Forms.Panel();
            this.ptr_btn = new System.Windows.Forms.Button();
            this.scan_btn = new System.Windows.Forms.Button();
            this.msr_btn = new System.Windows.Forms.Button();
            this.disp_btn = new System.Windows.Forms.Button();
            this.cash_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // utilityPanel
            // 
            this.utilityPanel.Location = new System.Drawing.Point(2, 67);
            this.utilityPanel.Name = "utilityPanel";
            this.utilityPanel.Size = new System.Drawing.Size(662, 524);
            this.utilityPanel.TabIndex = 0;
            // 
            // ptr_btn
            // 
            this.ptr_btn.Location = new System.Drawing.Point(12, 12);
            this.ptr_btn.Name = "ptr_btn";
            this.ptr_btn.Size = new System.Drawing.Size(61, 49);
            this.ptr_btn.TabIndex = 1;
            this.ptr_btn.Text = "ptr_btn";
            this.ptr_btn.UseVisualStyleBackColor = true;
            this.ptr_btn.Click += new System.EventHandler(this.ptr_btn_Click);
            // 
            // scan_btn
            // 
            this.scan_btn.Location = new System.Drawing.Point(79, 12);
            this.scan_btn.Name = "scan_btn";
            this.scan_btn.Size = new System.Drawing.Size(61, 49);
            this.scan_btn.TabIndex = 2;
            this.scan_btn.Text = "scan_btn";
            this.scan_btn.UseVisualStyleBackColor = true;
            this.scan_btn.Click += new System.EventHandler(this.scan_btn_Click);
            // 
            // msr_btn
            // 
            this.msr_btn.Location = new System.Drawing.Point(146, 12);
            this.msr_btn.Name = "msr_btn";
            this.msr_btn.Size = new System.Drawing.Size(61, 49);
            this.msr_btn.TabIndex = 3;
            this.msr_btn.Text = "button3";
            this.msr_btn.UseVisualStyleBackColor = true;
            this.msr_btn.Click += new System.EventHandler(this.msr_btn_Click);
            // 
            // disp_btn
            // 
            this.disp_btn.Location = new System.Drawing.Point(213, 12);
            this.disp_btn.Name = "disp_btn";
            this.disp_btn.Size = new System.Drawing.Size(61, 49);
            this.disp_btn.TabIndex = 4;
            this.disp_btn.Text = "button4";
            this.disp_btn.UseVisualStyleBackColor = true;
            this.disp_btn.Click += new System.EventHandler(this.disp_btn_Click);
            // 
            // cash_btn
            // 
            this.cash_btn.Location = new System.Drawing.Point(280, 12);
            this.cash_btn.Name = "cash_btn";
            this.cash_btn.Size = new System.Drawing.Size(61, 49);
            this.cash_btn.TabIndex = 5;
            this.cash_btn.Text = "cash_btn";
            this.cash_btn.UseVisualStyleBackColor = true;
            this.cash_btn.Click += new System.EventHandler(this.cash_btn_Click);
            // 
            // OPOSUtilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 597);
            this.Controls.Add(this.cash_btn);
            this.Controls.Add(this.disp_btn);
            this.Controls.Add(this.msr_btn);
            this.Controls.Add(this.scan_btn);
            this.Controls.Add(this.ptr_btn);
            this.Controls.Add(this.utilityPanel);
            this.Name = "OPOSUtilityForm";
            this.Text = "OPOS Utility";
            this.Load += new System.EventHandler(this.OPOSUtilityForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel utilityPanel;
        private System.Windows.Forms.Button ptr_btn;
        private System.Windows.Forms.Button scan_btn;
        private System.Windows.Forms.Button msr_btn;
        private System.Windows.Forms.Button disp_btn;
        private System.Windows.Forms.Button cash_btn;
    }
}

