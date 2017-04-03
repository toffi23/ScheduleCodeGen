namespace CodeGenMenetrend.ScheduleGen
{
    partial class StartEditor
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_WORKDAY = new System.Windows.Forms.CheckBox();
            this.checkBox_NOSCHOOLWORK = new System.Windows.Forms.CheckBox();
            this.checkBox_FREEDAY = new System.Windows.Forms.CheckBox();
            this.checkBox_NOWORK = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "hh:mm";
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(62, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2017, 4, 2, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "&OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 74);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(76, 95);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Idő:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Útvonal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Aktív:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(116, 124);
            this.dateTimePicker2.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(80, 20);
            this.dateTimePicker2.TabIndex = 6;
            this.dateTimePicker2.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(116, 150);
            this.dateTimePicker3.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(80, 20);
            this.dateTimePicker3.TabIndex = 7;
            this.dateTimePicker3.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(202, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "-tól";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "-ig";
            // 
            // checkBox_WORKDAY
            // 
            this.checkBox_WORKDAY.AutoSize = true;
            this.checkBox_WORKDAY.Location = new System.Drawing.Point(115, 26);
            this.checkBox_WORKDAY.Name = "checkBox_WORKDAY";
            this.checkBox_WORKDAY.Size = new System.Drawing.Size(153, 17);
            this.checkBox_WORKDAY.TabIndex = 2;
            this.checkBox_WORKDAY.Text = "&WORKDAY/SCHOOLDAY";
            this.checkBox_WORKDAY.UseVisualStyleBackColor = true;
            // 
            // checkBox_NOSCHOOLWORK
            // 
            this.checkBox_NOSCHOOLWORK.AutoSize = true;
            this.checkBox_NOSCHOOLWORK.Location = new System.Drawing.Point(115, 49);
            this.checkBox_NOSCHOOLWORK.Name = "checkBox_NOSCHOOLWORK";
            this.checkBox_NOSCHOOLWORK.Size = new System.Drawing.Size(120, 17);
            this.checkBox_NOSCHOOLWORK.TabIndex = 3;
            this.checkBox_NOSCHOOLWORK.Text = "NO&SCHOOLWORK";
            this.checkBox_NOSCHOOLWORK.UseVisualStyleBackColor = true;
            // 
            // checkBox_FREEDAY
            // 
            this.checkBox_FREEDAY.AutoSize = true;
            this.checkBox_FREEDAY.Location = new System.Drawing.Point(115, 74);
            this.checkBox_FREEDAY.Name = "checkBox_FREEDAY";
            this.checkBox_FREEDAY.Size = new System.Drawing.Size(76, 17);
            this.checkBox_FREEDAY.TabIndex = 4;
            this.checkBox_FREEDAY.Text = "&FREEDAY";
            this.checkBox_FREEDAY.UseVisualStyleBackColor = true;
            // 
            // checkBox_NOWORK
            // 
            this.checkBox_NOWORK.AutoSize = true;
            this.checkBox_NOWORK.Location = new System.Drawing.Point(115, 97);
            this.checkBox_NOWORK.Name = "checkBox_NOWORK";
            this.checkBox_NOWORK.Size = new System.Drawing.Size(76, 17);
            this.checkBox_NOWORK.TabIndex = 5;
            this.checkBox_NOWORK.Text = "NOWO&RK";
            this.checkBox_NOWORK.UseVisualStyleBackColor = true;
            // 
            // StartEditor
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 251);
            this.Controls.Add(this.checkBox_NOWORK);
            this.Controls.Add(this.checkBox_FREEDAY);
            this.Controls.Add(this.checkBox_NOSCHOOLWORK);
            this.Controls.Add(this.checkBox_WORKDAY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.KeyPreview = true;
            this.Name = "StartEditor";
            this.Text = "StartEditor";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.StartEditor_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_WORKDAY;
        private System.Windows.Forms.CheckBox checkBox_NOSCHOOLWORK;
        private System.Windows.Forms.CheckBox checkBox_FREEDAY;
        private System.Windows.Forms.CheckBox checkBox_NOWORK;
    }
}