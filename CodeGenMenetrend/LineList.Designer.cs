namespace CodeGenMenetrend
{
    partial class LineList
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
            this.listBox_lines = new System.Windows.Forms.ListBox();
            this.button_addLine = new System.Windows.Forms.Button();
            this.button_removeLine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_lines
            // 
            this.listBox_lines.FormattingEnabled = true;
            this.listBox_lines.Location = new System.Drawing.Point(13, 13);
            this.listBox_lines.Name = "listBox_lines";
            this.listBox_lines.Size = new System.Drawing.Size(290, 485);
            this.listBox_lines.TabIndex = 0;
            // 
            // button_addLine
            // 
            this.button_addLine.Location = new System.Drawing.Point(310, 13);
            this.button_addLine.Name = "button_addLine";
            this.button_addLine.Size = new System.Drawing.Size(75, 23);
            this.button_addLine.TabIndex = 1;
            this.button_addLine.Text = "Add";
            this.button_addLine.UseVisualStyleBackColor = true;
            this.button_addLine.Click += new System.EventHandler(this.button_addLine_Click);
            // 
            // button_removeLine
            // 
            this.button_removeLine.Location = new System.Drawing.Point(309, 42);
            this.button_removeLine.Name = "button_removeLine";
            this.button_removeLine.Size = new System.Drawing.Size(75, 23);
            this.button_removeLine.TabIndex = 2;
            this.button_removeLine.Text = "Remove";
            this.button_removeLine.UseVisualStyleBackColor = true;
            // 
            // LineList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 516);
            this.Controls.Add(this.button_removeLine);
            this.Controls.Add(this.button_addLine);
            this.Controls.Add(this.listBox_lines);
            this.Name = "LineList";
            this.Text = "LineList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_lines;
        private System.Windows.Forms.Button button_addLine;
        private System.Windows.Forms.Button button_removeLine;
    }
}