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

            if(pStart != null)
            {
                Start = pStart;
                this.Name = Start.ToString();
                this.dateTimePicker1.Value = Start.StartTime;
                this.dateTimePicker2.Value = new DateTime(Start.StartTime.Year, 1, 1).AddDays(Start.ActiveFrom - 1);
                this.dateTimePicker3.Value = new DateTime(Start.StartTime.Year, 1, 1).AddDays(Start.ActiveTill - 1);
                this.listBox1.SelectedItem = Start.Route;
                selectActiveCodeRadioButton(Start.StartCode);
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
        }

        private void selectActiveCodeRadioButton(int code)
        {
            switch (code)
            {
                case 1:
                    this.radioButton_FREEDAY.Checked = false;
                    this.radioButton_NOSCHOOLWORK.Checked = false;
                    this.radioButton_NOWORK.Checked = false;
                    this.radioButton_WORKDAY.Checked = true;
                    break;
                case 2:
                    this.radioButton_FREEDAY.Checked = false;
                    this.radioButton_NOSCHOOLWORK.Checked = true;
                    this.radioButton_NOWORK.Checked = false;
                    this.radioButton_WORKDAY.Checked = false;
                    break;
                case 3:
                    this.radioButton_FREEDAY.Checked = true;
                    this.radioButton_NOSCHOOLWORK.Checked = false;
                    this.radioButton_NOWORK.Checked = false;
                    this.radioButton_WORKDAY.Checked = false;
                    break;
                case 4:
                    this.radioButton_FREEDAY.Checked = false;
                    this.radioButton_NOSCHOOLWORK.Checked = false;
                    this.radioButton_NOWORK.Checked = true;
                    this.radioButton_WORKDAY.Checked = false;
                    break;
            default:
                    this.radioButton_FREEDAY.Checked = false;
                    this.radioButton_NOSCHOOLWORK.Checked = false;
                    this.radioButton_NOWORK.Checked = false;
                    this.radioButton_WORKDAY.Checked = false;
                    break;
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
            if (radioButton_FREEDAY.Checked) { return CalendarGen.DateCodeGen.FREEDAY; }
            else if (radioButton_NOSCHOOLWORK.Checked) { return CalendarGen.DateCodeGen.NOSCHOOLWORK; }
            else if (radioButton_NOWORK.Checked) { return CalendarGen.DateCodeGen.NOWORK; }
            else if (radioButton_WORKDAY.Checked) { return CalendarGen.DateCodeGen.WORKDAY; }
            else { return CalendarGen.DateCodeGen.WORKDAY; };
        }
    }
}
