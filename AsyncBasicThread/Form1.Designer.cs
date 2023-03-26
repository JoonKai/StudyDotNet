namespace AsyncBasicThread
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCopyMain = new Button();
            progressMain = new ProgressBar();
            lblMain = new Label();
            lblBack = new Label();
            progressBack = new ProgressBar();
            btnCopyBack = new Button();
            SuspendLayout();
            // 
            // btnCopyMain
            // 
            btnCopyMain.Location = new Point(12, 12);
            btnCopyMain.Name = "btnCopyMain";
            btnCopyMain.Size = new Size(104, 61);
            btnCopyMain.TabIndex = 0;
            btnCopyMain.Text = "파일 복사비동기(동일 스레드)";
            btnCopyMain.UseVisualStyleBackColor = true;
            btnCopyMain.Click += btnCopyMain_Click;
            // 
            // progressMain
            // 
            progressMain.Location = new Point(148, 12);
            progressMain.Name = "progressMain";
            progressMain.Size = new Size(227, 23);
            progressMain.TabIndex = 1;
            // 
            // lblMain
            // 
            lblMain.AutoSize = true;
            lblMain.Location = new Point(148, 48);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(39, 15);
            lblMain.TabIndex = 2;
            lblMain.Text = "label1";
            // 
            // lblBack
            // 
            lblBack.AutoSize = true;
            lblBack.Location = new Point(148, 130);
            lblBack.Name = "lblBack";
            lblBack.Size = new Size(39, 15);
            lblBack.TabIndex = 5;
            lblBack.Text = "label2";
            // 
            // progressBack
            // 
            progressBack.Location = new Point(148, 94);
            progressBack.Name = "progressBack";
            progressBack.Size = new Size(227, 23);
            progressBack.TabIndex = 4;
            // 
            // btnCopyBack
            // 
            btnCopyBack.Location = new Point(12, 94);
            btnCopyBack.Name = "btnCopyBack";
            btnCopyBack.Size = new Size(104, 61);
            btnCopyBack.TabIndex = 3;
            btnCopyBack.Text = "파일 복사비동기(백그라운드 스레드)\r\n";
            btnCopyBack.UseVisualStyleBackColor = true;
            btnCopyBack.Click += btnCopyBack_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 249);
            Controls.Add(lblBack);
            Controls.Add(progressBack);
            Controls.Add(btnCopyBack);
            Controls.Add(lblMain);
            Controls.Add(progressMain);
            Controls.Add(btnCopyMain);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCopyMain;
        private ProgressBar progressMain;
        private Label lblMain;
        private Label lblBack;
        private ProgressBar progressBack;
        private Button btnCopyBack;
    }
}