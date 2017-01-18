namespace CodeGenMenetrend
{
    partial class EditStation
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_newStationName = new System.Windows.Forms.TextBox();
            this.addStationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBox_newStationName
            // 
            this.textBox_newStationName.Location = new System.Drawing.Point(55, 22);
            this.textBox_newStationName.Name = "textBox_newStationName";
            this.textBox_newStationName.Size = new System.Drawing.Size(313, 20);
            this.textBox_newStationName.TabIndex = 1;
            this.textBox_newStationName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_newStationName_KeyDown);
            // 
            // addStationButton
            // 
            this.addStationButton.Location = new System.Drawing.Point(55, 61);
            this.addStationButton.Name = "addStationButton";
            this.addStationButton.Size = new System.Drawing.Size(290, 42);
            this.addStationButton.TabIndex = 2;
            this.addStationButton.Text = "&OK";
            this.addStationButton.UseVisualStyleBackColor = true;
            this.addStationButton.Click += new System.EventHandler(this.addStationButton_Click);
            // 
            // EditStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 115);
            this.Controls.Add(this.addStationButton);
            this.Controls.Add(this.textBox_newStationName);
            this.Controls.Add(this.label1);
            this.Name = "EditStation";
            this.Text = "New station";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_newStationName;
        private System.Windows.Forms.Button addStationButton;
    }
}