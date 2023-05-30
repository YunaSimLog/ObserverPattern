namespace ObserverPattern
{
    partial class MainForm
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.lbNote = new System.Windows.Forms.Label();
            this.pnlColor = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnShowForm2 = new System.Windows.Forms.Button();
            this.btnShowForm3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUpdate.Location = new System.Drawing.Point(12, 202);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 31);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "업데이트";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(133, 202);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(96, 31);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "닫기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbNote
            // 
            this.tbNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNote.Location = new System.Drawing.Point(12, 35);
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(215, 21);
            this.tbNote.TabIndex = 2;
            // 
            // lbNote
            // 
            this.lbNote.AutoSize = true;
            this.lbNote.Location = new System.Drawing.Point(12, 20);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(57, 12);
            this.lbNote.TabIndex = 3;
            this.lbNote.Text = "문자 입력";
            // 
            // pnlColor
            // 
            this.pnlColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlColor.BackColor = System.Drawing.Color.Linen;
            this.pnlColor.Location = new System.Drawing.Point(14, 111);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Size = new System.Drawing.Size(213, 29);
            this.pnlColor.TabIndex = 4;
            // 
            // btnColor
            // 
            this.btnColor.Font = new System.Drawing.Font("굴림", 9F);
            this.btnColor.Location = new System.Drawing.Point(12, 74);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(111, 31);
            this.btnColor.TabIndex = 5;
            this.btnColor.Text = "색상 편집";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnShowForm2
            // 
            this.btnShowForm2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowForm2.Font = new System.Drawing.Font("굴림", 9F);
            this.btnShowForm2.Location = new System.Drawing.Point(14, 158);
            this.btnShowForm2.Name = "btnShowForm2";
            this.btnShowForm2.Size = new System.Drawing.Size(111, 34);
            this.btnShowForm2.TabIndex = 6;
            this.btnShowForm2.Text = "Form2 보이기";
            this.btnShowForm2.UseVisualStyleBackColor = true;
            this.btnShowForm2.Click += new System.EventHandler(this.btnShowForm2_Click);
            // 
            // btnShowForm3
            // 
            this.btnShowForm3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowForm3.Font = new System.Drawing.Font("굴림", 9F);
            this.btnShowForm3.Location = new System.Drawing.Point(131, 158);
            this.btnShowForm3.Name = "btnShowForm3";
            this.btnShowForm3.Size = new System.Drawing.Size(96, 34);
            this.btnShowForm3.TabIndex = 7;
            this.btnShowForm3.Text = "Form3 보이기";
            this.btnShowForm3.UseVisualStyleBackColor = true;
            this.btnShowForm3.Click += new System.EventHandler(this.btnShowForm3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 245);
            this.Controls.Add(this.btnShowForm3);
            this.Controls.Add(this.btnShowForm2);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.pnlColor);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.MinimumSize = new System.Drawing.Size(257, 284);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.Label lbNote;
        private System.Windows.Forms.Panel pnlColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnShowForm2;
        private System.Windows.Forms.Button btnShowForm3;
    }
}

