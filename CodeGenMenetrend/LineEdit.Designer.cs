namespace CodeGenMenetrend
{
    partial class LineEdit
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
            this.textBox_lineID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_OkLine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_lineID
            // 
            this.textBox_lineID.Location = new System.Drawing.Point(37, 10);
            this.textBox_lineID.Name = "textBox_lineID";
            this.textBox_lineID.Size = new System.Drawing.Size(100, 20);
            this.textBox_lineID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // button_OkLine
            // 
            this.button_OkLine.Location = new System.Drawing.Point(16, 53);
            this.button_OkLine.Name = "button_OkLine";
            this.button_OkLine.Size = new System.Drawing.Size(75, 23);
            this.button_OkLine.TabIndex = 2;
            this.button_OkLine.Text = "OK";
            this.button_OkLine.UseVisualStyleBackColor = true;
            this.button_OkLine.Click += new System.EventHandler(this.button_OkLine_Click);
            // 
            // LineEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 138);
            this.Controls.Add(this.button_OkLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_lineID);
            this.Name = "LineEdit";
            this.Text = "LineEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_lineID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_OkLine;
    }
}