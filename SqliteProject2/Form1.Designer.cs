namespace SqliteProject2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.refreshData_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.addNew_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.moveLast_btn = new System.Windows.Forms.Button();
            this.moveNext_btn = new System.Windows.Forms.Button();
            this.movePreview_btn = new System.Windows.Forms.Button();
            this.moveFirst_btn = new System.Windows.Forms.Button();
            this.Phone_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Email_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.JobTitle_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LastName_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstName_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AutoID_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.strip = new System.Windows.Forms.StatusStrip();
            this.positionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.keyword_txt = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.exit_btn);
            this.groupBox1.Controls.Add(this.refreshData_btn);
            this.groupBox1.Controls.Add(this.save_btn);
            this.groupBox1.Controls.Add(this.addNew_btn);
            this.groupBox1.Controls.Add(this.delete_btn);
            this.groupBox1.Controls.Add(this.moveLast_btn);
            this.groupBox1.Controls.Add(this.moveNext_btn);
            this.groupBox1.Controls.Add(this.movePreview_btn);
            this.groupBox1.Controls.Add(this.moveFirst_btn);
            this.groupBox1.Controls.Add(this.Phone_txt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Email_txt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.JobTitle_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LastName_txt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.FirstName_txt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AutoID_txt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 657);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(376, 546);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(148, 58);
            this.exit_btn.TabIndex = 20;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // refreshData_btn
            // 
            this.refreshData_btn.Location = new System.Drawing.Point(49, 546);
            this.refreshData_btn.Name = "refreshData_btn";
            this.refreshData_btn.Size = new System.Drawing.Size(312, 58);
            this.refreshData_btn.TabIndex = 19;
            this.refreshData_btn.Text = "Refresh Data";
            this.refreshData_btn.UseVisualStyleBackColor = true;
            this.refreshData_btn.Click += new System.EventHandler(this.refreshData_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.ForeColor = System.Drawing.Color.Red;
            this.save_btn.Location = new System.Drawing.Point(376, 465);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(148, 58);
            this.save_btn.TabIndex = 18;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // addNew_btn
            // 
            this.addNew_btn.ForeColor = System.Drawing.Color.Blue;
            this.addNew_btn.Location = new System.Drawing.Point(213, 465);
            this.addNew_btn.Name = "addNew_btn";
            this.addNew_btn.Size = new System.Drawing.Size(148, 58);
            this.addNew_btn.TabIndex = 17;
            this.addNew_btn.Text = "Add New";
            this.addNew_btn.UseVisualStyleBackColor = true;
            this.addNew_btn.Click += new System.EventHandler(this.addNew_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.ForeColor = System.Drawing.Color.Red;
            this.delete_btn.Location = new System.Drawing.Point(49, 465);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(148, 58);
            this.delete_btn.TabIndex = 16;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // moveLast_btn
            // 
            this.moveLast_btn.Location = new System.Drawing.Point(403, 405);
            this.moveLast_btn.Name = "moveLast_btn";
            this.moveLast_btn.Size = new System.Drawing.Size(102, 41);
            this.moveLast_btn.TabIndex = 15;
            this.moveLast_btn.Text = ">|";
            this.moveLast_btn.UseVisualStyleBackColor = true;
            this.moveLast_btn.Click += new System.EventHandler(this.moveLast_btn_Click);
            // 
            // moveNext_btn
            // 
            this.moveNext_btn.Location = new System.Drawing.Point(283, 405);
            this.moveNext_btn.Name = "moveNext_btn";
            this.moveNext_btn.Size = new System.Drawing.Size(102, 41);
            this.moveNext_btn.TabIndex = 14;
            this.moveNext_btn.Text = ">";
            this.moveNext_btn.UseVisualStyleBackColor = true;
            this.moveNext_btn.Click += new System.EventHandler(this.moveNext_btn_Click);
            // 
            // movePreview_btn
            // 
            this.movePreview_btn.Location = new System.Drawing.Point(163, 405);
            this.movePreview_btn.Name = "movePreview_btn";
            this.movePreview_btn.Size = new System.Drawing.Size(102, 41);
            this.movePreview_btn.TabIndex = 13;
            this.movePreview_btn.Text = "<";
            this.movePreview_btn.UseVisualStyleBackColor = true;
            this.movePreview_btn.Click += new System.EventHandler(this.movePreview_btn_Click);
            // 
            // moveFirst_btn
            // 
            this.moveFirst_btn.Location = new System.Drawing.Point(49, 405);
            this.moveFirst_btn.Name = "moveFirst_btn";
            this.moveFirst_btn.Size = new System.Drawing.Size(102, 41);
            this.moveFirst_btn.TabIndex = 12;
            this.moveFirst_btn.Text = "|<";
            this.moveFirst_btn.UseVisualStyleBackColor = true;
            this.moveFirst_btn.Click += new System.EventHandler(this.moveFirst_btn_Click);
            // 
            // Phone_txt
            // 
            this.Phone_txt.Location = new System.Drawing.Point(182, 334);
            this.Phone_txt.Name = "Phone_txt";
            this.Phone_txt.Size = new System.Drawing.Size(342, 35);
            this.Phone_txt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Phone:";
            // 
            // Email_txt
            // 
            this.Email_txt.Location = new System.Drawing.Point(182, 283);
            this.Email_txt.Name = "Email_txt";
            this.Email_txt.Size = new System.Drawing.Size(342, 35);
            this.Email_txt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "E-Mail:";
            // 
            // JobTitle_txt
            // 
            this.JobTitle_txt.Location = new System.Drawing.Point(182, 232);
            this.JobTitle_txt.Name = "JobTitle_txt";
            this.JobTitle_txt.Size = new System.Drawing.Size(342, 35);
            this.JobTitle_txt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Job Title:";
            // 
            // LastName_txt
            // 
            this.LastName_txt.Location = new System.Drawing.Point(182, 181);
            this.LastName_txt.Name = "LastName_txt";
            this.LastName_txt.Size = new System.Drawing.Size(342, 35);
            this.LastName_txt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            // 
            // FirstName_txt
            // 
            this.FirstName_txt.Location = new System.Drawing.Point(182, 130);
            this.FirstName_txt.Name = "FirstName_txt";
            this.FirstName_txt.Size = new System.Drawing.Size(342, 35);
            this.FirstName_txt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name:";
            // 
            // AutoID_txt
            // 
            this.AutoID_txt.Location = new System.Drawing.Point(182, 79);
            this.AutoID_txt.Name = "AutoID_txt";
            this.AutoID_txt.Size = new System.Drawing.Size(342, 35);
            this.AutoID_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Auto ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(608, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1281, 550);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.Size = new System.Drawing.Size(1275, 516);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // strip
            // 
            this.strip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.positionLabel});
            this.strip.Location = new System.Drawing.Point(0, 692);
            this.strip.Name = "strip";
            this.strip.Size = new System.Drawing.Size(1889, 42);
            this.strip.TabIndex = 2;
            this.strip.Text = "Position: 0/0";
            // 
            // positionLabel
            // 
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(149, 32);
            this.positionLabel.Text = "Position: 0/0";
            // 
            // keyword_txt
            // 
            this.keyword_txt.Location = new System.Drawing.Point(621, 83);
            this.keyword_txt.Name = "keyword_txt";
            this.keyword_txt.Size = new System.Drawing.Size(338, 35);
            this.keyword_txt.TabIndex = 3;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(974, 79);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(160, 39);
            this.search_btn.TabIndex = 4;
            this.search_btn.Text = "button1";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1889, 734);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.keyword_txt);
            this.Controls.Add(this.strip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.strip.ResumeLayout(false);
            this.strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button refreshData_btn;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.Button addNew_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button moveLast_btn;
        private System.Windows.Forms.Button moveNext_btn;
        private System.Windows.Forms.Button movePreview_btn;
        private System.Windows.Forms.Button moveFirst_btn;
        private System.Windows.Forms.TextBox Phone_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Email_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox JobTitle_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LastName_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstName_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AutoID_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip strip;
        private System.Windows.Forms.ToolStripStatusLabel positionLabel;
        private System.Windows.Forms.TextBox keyword_txt;
        private System.Windows.Forms.Button search_btn;
    }
}

