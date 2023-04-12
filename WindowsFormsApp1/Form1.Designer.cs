namespace WindowsFormsApp1
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
            this.btnConnection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.status_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(36, 29);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(300, 74);
            this.btnConnection.TabIndex = 0;
            this.btnConnection.Text = "커넥션 연결";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "연결상태 : ";
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.Location = new System.Drawing.Point(487, 54);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(72, 24);
            this.status_lbl.TabIndex = 2;
            this.status_lbl.Text = "status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 634);
            this.Controls.Add(this.status_lbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnection);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label status_lbl;
    }
}

