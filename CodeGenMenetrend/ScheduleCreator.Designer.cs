namespace CodeGenMenetrend
{
    partial class ScheduleCreator
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
            this.button_StationList = new System.Windows.Forms.Button();
            this.button_lineList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_StationList
            // 
            this.button_StationList.Location = new System.Drawing.Point(12, 12);
            this.button_StationList.Name = "button_StationList";
            this.button_StationList.Size = new System.Drawing.Size(75, 23);
            this.button_StationList.TabIndex = 0;
            this.button_StationList.Text = "Station list";
            this.button_StationList.UseVisualStyleBackColor = true;
            this.button_StationList.Click += new System.EventHandler(this.button_StationList_Click);
            // 
            // button_lineList
            // 
            this.button_lineList.Location = new System.Drawing.Point(13, 42);
            this.button_lineList.Name = "button_lineList";
            this.button_lineList.Size = new System.Drawing.Size(75, 23);
            this.button_lineList.TabIndex = 1;
            this.button_lineList.Text = "Line list";
            this.button_lineList.UseVisualStyleBackColor = true;
            this.button_lineList.Click += new System.EventHandler(this.button_lineList_Click);
            // 
            // ScheduleCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 163);
            this.Controls.Add(this.button_lineList);
            this.Controls.Add(this.button_StationList);
            this.Name = "ScheduleCreator";
            this.Text = "ScheduleCreator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScheduleCreator_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_StationList;
        private System.Windows.Forms.Button button_lineList;
    }
}