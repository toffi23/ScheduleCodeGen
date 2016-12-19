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
            this.SuspendLayout();
            // 
            // button_StationList
            // 
            this.button_StationList.Location = new System.Drawing.Point(113, 40);
            this.button_StationList.Name = "button_StationList";
            this.button_StationList.Size = new System.Drawing.Size(75, 23);
            this.button_StationList.TabIndex = 0;
            this.button_StationList.Text = "Station list";
            this.button_StationList.UseVisualStyleBackColor = true;
            this.button_StationList.Click += new System.EventHandler(this.button_StationList_Click);
            // 
            // ScheduleCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 287);
            this.Controls.Add(this.button_StationList);
            this.Name = "ScheduleCreator";
            this.Text = "ScheduleCreator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScheduleCreator_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_StationList;
    }
}