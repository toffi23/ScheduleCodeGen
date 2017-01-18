using System.Windows.Forms;
using CodeGenMenetrend.ScheduleLib;

namespace CodeGenMenetrend
{
    public partial class EditStation : Form
    {
        public Station station { get; private set; }

        public EditStation(Station pStation = null)
        {
            InitializeComponent();

            station = pStation;
            DialogResult = DialogResult.Cancel;
            
            if(station != null)
            {
                textBox_newStationName.Text = station.Name;
            }

        }

        private void addStationButton_Click(object sender, System.EventArgs e)
        {
            string name = this.textBox_newStationName.Text;
            if (station == null)
            {
                station = new Station(name);
            }
            else
            {
                station.Name = name;
            }
            DialogResult = DialogResult.OK;
        }

        private void textBox_newStationName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                addStationButton_Click(null, null);
            }
        }
    }
}
