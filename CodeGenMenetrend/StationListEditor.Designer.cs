namespace CodeGenMenetrend
{
    partial class StationListEditor
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
            this.listBox_editStations = new System.Windows.Forms.ListBox();
            this.button_addStation = new System.Windows.Forms.Button();
            this.button_editStation = new System.Windows.Forms.Button();
            this.button_removeStation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_editStations
            // 
            this.listBox_editStations.FormattingEnabled = true;
            this.listBox_editStations.Location = new System.Drawing.Point(13, 13);
            this.listBox_editStations.Name = "listBox_editStations";
            this.listBox_editStations.Size = new System.Drawing.Size(293, 459);
            this.listBox_editStations.TabIndex = 0;
            // 
            // button_addStation
            // 
            this.button_addStation.Location = new System.Drawing.Point(313, 13);
            this.button_addStation.Name = "button_addStation";
            this.button_addStation.Size = new System.Drawing.Size(75, 23);
            this.button_addStation.TabIndex = 1;
            this.button_addStation.Text = "Add new";
            this.button_addStation.UseVisualStyleBackColor = true;
            this.button_addStation.Click += new System.EventHandler(this.button_addStation_Click);
            // 
            // button_editStation
            // 
            this.button_editStation.Location = new System.Drawing.Point(313, 43);
            this.button_editStation.Name = "button_editStation";
            this.button_editStation.Size = new System.Drawing.Size(75, 23);
            this.button_editStation.TabIndex = 2;
            this.button_editStation.Text = "Edit";
            this.button_editStation.UseVisualStyleBackColor = true;
            // 
            // button_removeStation
            // 
            this.button_removeStation.Location = new System.Drawing.Point(313, 73);
            this.button_removeStation.Name = "button_removeStation";
            this.button_removeStation.Size = new System.Drawing.Size(75, 23);
            this.button_removeStation.TabIndex = 3;
            this.button_removeStation.Text = "Remove";
            this.button_removeStation.UseVisualStyleBackColor = true;
            this.button_removeStation.Click += new System.EventHandler(this.button_removeStation_Click);
            // 
            // StationListEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 504);
            this.Controls.Add(this.button_removeStation);
            this.Controls.Add(this.button_editStation);
            this.Controls.Add(this.button_addStation);
            this.Controls.Add(this.listBox_editStations);
            this.Name = "StationListEditor";
            this.Text = "StationListEditor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_editStations;
        private System.Windows.Forms.Button button_addStation;
        private System.Windows.Forms.Button button_editStation;
        private System.Windows.Forms.Button button_removeStation;
    }
}