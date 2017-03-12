using CodeGenMenetrend.ScheduleLib;
using System;
using System.Windows.Forms;

namespace CodeGenMenetrend.ScheduleGen
{
    public partial class StationEditor : Form
    {
        public Station Station { get; private set; }

        public StationEditor(Station pStation = null)
        {
            InitializeComponent();

            if(pStation != null)
            {
                this.Station = pStation;
                this.Name = this.Station.Name;
                this.textBoxStationName.Text = this.Station.Name;
            }
            else
            {
                this.Name = "Új megálló";
            }

            this.AcceptButton = this.button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acceptData();
        }

        private void acceptData()
        {
            if (Station == null)
            {
                string name = this.textBoxStationName.Text;
                Station = new Station(name);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                Station.Name = this.textBoxStationName.Text;
                this.DialogResult = DialogResult.OK;
            }
        }


    }
}
