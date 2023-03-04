namespace AsyncBasic
{
    partial class window
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
            this.btnWalking = new System.Windows.Forms.Button();
            this.lblWalking = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnPhone = new System.Windows.Forms.Button();
            this.lblTalking = new System.Windows.Forms.Label();
            this.btnTalking = new System.Windows.Forms.Button();
            this.lbAll = new System.Windows.Forms.ListBox();
            this.btnAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWalking
            // 
            this.btnWalking.Location = new System.Drawing.Point(35, 12);
            this.btnWalking.Name = "btnWalking";
            this.btnWalking.Size = new System.Drawing.Size(170, 60);
            this.btnWalking.TabIndex = 0;
            this.btnWalking.Text = "걷기";
            this.btnWalking.UseVisualStyleBackColor = true;
            this.btnWalking.Click += new System.EventHandler(this.btnWalking_Click);
            // 
            // lblWalking
            // 
            this.lblWalking.AutoSize = true;
            this.lblWalking.Location = new System.Drawing.Point(229, 30);
            this.lblWalking.Name = "lblWalking";
            this.lblWalking.Size = new System.Drawing.Size(56, 24);
            this.lblWalking.TabIndex = 1;
            this.lblWalking.Text = "lable";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(229, 96);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 24);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "lable";
            // 
            // btnPhone
            // 
            this.btnPhone.Location = new System.Drawing.Point(35, 78);
            this.btnPhone.Name = "btnPhone";
            this.btnPhone.Size = new System.Drawing.Size(170, 60);
            this.btnPhone.TabIndex = 2;
            this.btnPhone.Text = "핸드폰";
            this.btnPhone.UseVisualStyleBackColor = true;
            this.btnPhone.Click += new System.EventHandler(this.btnPhone_Click);
            // 
            // lblTalking
            // 
            this.lblTalking.AutoSize = true;
            this.lblTalking.Location = new System.Drawing.Point(229, 162);
            this.lblTalking.Name = "lblTalking";
            this.lblTalking.Size = new System.Drawing.Size(56, 24);
            this.lblTalking.TabIndex = 5;
            this.lblTalking.Text = "lable";
            // 
            // btnTalking
            // 
            this.btnTalking.Location = new System.Drawing.Point(35, 144);
            this.btnTalking.Name = "btnTalking";
            this.btnTalking.Size = new System.Drawing.Size(170, 60);
            this.btnTalking.TabIndex = 4;
            this.btnTalking.Text = "말하기";
            this.btnTalking.UseVisualStyleBackColor = true;
            this.btnTalking.Click += new System.EventHandler(this.btnTalking_Click);
            // 
            // lbAll
            // 
            this.lbAll.FormattingEnabled = true;
            this.lbAll.ItemHeight = 24;
            this.lbAll.Location = new System.Drawing.Point(543, 12);
            this.lbAll.Name = "lbAll";
            this.lbAll.Size = new System.Drawing.Size(345, 628);
            this.lbAll.TabIndex = 6;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(317, 12);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(170, 60);
            this.btnAll.TabIndex = 7;
            this.btnAll.Text = "전체";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 790);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.lbAll);
            this.Controls.Add(this.lblTalking);
            this.Controls.Add(this.btnTalking);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.btnPhone);
            this.Controls.Add(this.lblWalking);
            this.Controls.Add(this.btnWalking);
            this.Name = "window";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWalking;
        private System.Windows.Forms.Label lblWalking;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnPhone;
        private System.Windows.Forms.Label lblTalking;
        private System.Windows.Forms.Button btnTalking;
        private System.Windows.Forms.ListBox lbAll;
        private System.Windows.Forms.Button btnAll;
    }
}

