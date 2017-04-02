using CodeGenMenetrend.ScheduleLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeGenMenetrend.ScheduleGen
{
    public partial class StartEditor : Form
    {
        public Start Start { get; private set; }

        public StartEditor(ICollection<Track> pTracks, Start pStart = null)
        {
            InitializeComponent();

            if(pStart != null)
            {
                Start = pStart;
                this.Name = Start.ToString();
            }
            else
            {
                this.Name = "Új indulási idő";
            }

            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.CustomFormat = "hh:mm";
            this.listBox1.DataSource = pTracks;
            this.AcceptButton = this.button1;
            this.dateTimePicker2.MinDate = new DateTime(DateTime.Now.Year,1,1);
            this.dateTimePicker2.MaxDate = new DateTime(DateTime.Now.Year, 12, 31);
            this.dateTimePicker2.Value = DateTime.Now;
            this.dateTimePicker2.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker2.CustomFormat = "MM.dd";
            this.dateTimePicker3.MinDate = new DateTime(DateTime.Now.Year, 1, 1);
            this.dateTimePicker3.MaxDate = new DateTime(DateTime.Now.Year, 12, 31);
            this.dateTimePicker3.Value = DateTime.Now;
            this.dateTimePicker3.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker3.CustomFormat = "MM.dd";

            if (this.checkBox_Special.Checked)
            {
                this.dateTimePicker2.Show();
                this.dateTimePicker3.Show();
                this.label4.Show();
                this.label5.Show();
            }
            else
            {
                this.dateTimePicker2.Hide();
                this.dateTimePicker3.Hide();
                this.label4.Hide();
                this.label5.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_Special_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox_Special.Checked)
            {
                this.dateTimePicker2.Show();
                this.dateTimePicker3.Show();
            }
            else
            {
                this.dateTimePicker2.Hide();
                this.dateTimePicker3.Hide();
            }
        }
    }
}
