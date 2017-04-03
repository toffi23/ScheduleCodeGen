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
using CodeGenMenetrend.CalendarGen;

namespace CodeGenMenetrend.ScheduleGen
{
    public partial class StartEditor : Form
    {
        public Start Start { get; private set; }

        public StartEditor(ICollection<Track> pTracks, Start pStart = null)
        {
            InitializeComponent();
            this.dateTimePicker1.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker1.CustomFormat = "HH:mm";
            this.listBox1.DataSource = pTracks;
            this.AcceptButton = this.button1;
            this.dateTimePicker2.MinDate = new DateTime(DateTime.Now.Year,1,1);
            this.dateTimePicker2.MaxDate = new DateTime(DateTime.Now.Year, 12, 31);
            this.dateTimePicker2.Value = new DateTime(DateTime.Now.Year, 1, 1);
            this.dateTimePicker2.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker2.CustomFormat = "MM.dd";
            this.dateTimePicker3.MinDate = new DateTime(DateTime.Now.Year, 1, 1);
            this.dateTimePicker3.MaxDate = new DateTime(DateTime.Now.Year, 12, 31);
            this.dateTimePicker3.Value = new DateTime(DateTime.Now.Year, 12, 31); ;
            this.dateTimePicker3.Format = DateTimePickerFormat.Custom;
            this.dateTimePicker3.CustomFormat = "MM.dd";

            if (pStart != null)
            {
                Start = pStart;
                this.Text = Start.ToString();
                this.dateTimePicker1.Value = Start.StartTime;
                this.dateTimePicker2.Value = new DateTime(Start.StartTime.Year, 1, 1).AddDays(Start.ActiveFrom - 1);
                this.dateTimePicker3.Value = new DateTime(Start.StartTime.Year, 1, 1).AddDays(Start.ActiveTill - 1);
                this.listBox1.SelectedItem = Start.Route;
                selectActiveCodeRadioButton(Start.StartCode);
            }
            else
            {
                this.Text = "Új indulási idő";
            }
        }

        private void selectActiveCodeRadioButton(int code)
        {
            if((code & DateCodeGen.FREEDAY) > 0)
            {
                checkBox_FREEDAY.Checked = true;
            }

            if ((code & DateCodeGen.NOSCHOOLWORK) > 0)
            {
                checkBox_NOSCHOOLWORK.Checked = true;
            }

            if ((code & DateCodeGen.NOWORK) > 0)
            {
                checkBox_NOWORK.Checked = true;
            }

            if ((code & DateCodeGen.WORKDAY) > 0)
            {
                checkBox_WORKDAY.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int from = 0;
            int till = 0;
            from = dateTimePicker2.Value.DayOfYear;
            till = dateTimePicker3.Value.DayOfYear;

            Track track = (Track)listBox1.SelectedItem;

            if (Start == null)
            {
                Start = new Start(dateTimePicker1.Value, CheckActiveCode(), track, from, till);
            }
            else
            {
                Start.StartTime = dateTimePicker1.Value;
                Start.StartCode = CheckActiveCode();
                Start.Route = track;
                Start.ActiveFrom = from;
                Start.ActiveTill = till;
            }

            DialogResult = DialogResult.OK;
        }

        private int CheckActiveCode()
        {
            int activeCode = 0;

            if (checkBox_WORKDAY.Checked) { activeCode |= DateCodeGen.WORKDAY; }
            if (checkBox_FREEDAY.Checked) { activeCode |= DateCodeGen.FREEDAY; }
            if (checkBox_NOSCHOOLWORK.Checked) { activeCode |= DateCodeGen.NOSCHOOLWORK; }
            if (checkBox_NOWORK.Checked) { activeCode |= DateCodeGen.NOWORK; }

            return activeCode;
        }

        private void StartEditor_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
