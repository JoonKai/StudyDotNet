namespace SingletonPattern
{
    partial class Form1
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
            this.btnCreateForm2 = new System.Windows.Forms.Button();
            this.btnShowLogs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateForm2
            // 
            this.btnCreateForm2.Location = new System.Drawing.Point(50, 67);
            this.btnCreateForm2.Name = "btnCreateForm2";
            this.btnCreateForm2.Size = new System.Drawing.Size(259, 77);
            this.btnCreateForm2.TabIndex = 0;
            this.btnCreateForm2.Text = "폼2 생성";
            this.btnCreateForm2.UseVisualStyleBackColor = true;
            this.btnCreateForm2.Click += new System.EventHandler(this.btnCreateForm2_Click);
            // 
            // btnShowLogs
            // 
            this.btnShowLogs.Location = new System.Drawing.Point(342, 67);
            this.btnShowLogs.Name = "btnShowLogs";
            this.btnShowLogs.Size = new System.Drawing.Size(259, 77);
            this.btnShowLogs.TabIndex = 1;
            this.btnShowLogs.Text = "로그 메세지 확인";
            this.btnShowLogs.UseVisualStyleBackColor = true;
            this.btnShowLogs.Click += new System.EventHandler(this.btnShowLogs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowLogs);
            this.Controls.Add(this.btnCreateForm2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateForm2;
        private System.Windows.Forms.Button btnShowLogs;
    }
}

