namespace CodeGenMenetrend
{
    partial class MainMenu
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
            this.button_scheduleGen = new System.Windows.Forms.Button();
            this.button_calGen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_scheduleGen
            // 
            this.button_scheduleGen.Location = new System.Drawing.Point(48, 90);
            this.button_scheduleGen.Name = "button_scheduleGen";
            this.button_scheduleGen.Size = new System.Drawing.Size(151, 44);
            this.button_scheduleGen.TabIndex = 1;
            this.button_scheduleGen.Text = "&Schedule";
            this.button_scheduleGen.UseVisualStyleBackColor = true;
            this.button_scheduleGen.Click += new System.EventHandler(this.button_scheduleGen_Click);
            // 
            // button_calGen
            // 
            this.button_calGen.Location = new System.Drawing.Point(48, 40);
            this.button_calGen.Name = "button_calGen";
            this.button_calGen.Size = new System.Drawing.Size(151, 44);
            this.button_calGen.TabIndex = 2;
            this.button_calGen.Text = "&Calendar";
            this.button_calGen.UseVisualStyleBackColor = true;
            this.button_calGen.Click += new System.EventHandler(this.button_calGen_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 182);
            this.Controls.Add(this.button_calGen);
            this.Controls.Add(this.button_scheduleGen);
            this.Name = "MainMenu";
            this.Text = "Menetrend Codegenerator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_scheduleGen;
        private System.Windows.Forms.Button button_calGen;
    }
}