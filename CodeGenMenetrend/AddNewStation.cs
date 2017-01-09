using System.Windows.Forms;
using CodeGenMenetrend.ScheduleLib;

namespace CodeGenMenetrend
{
    public partial class AddNewStation : Form
    {
        public Station station { get; private set; }

        public AddNewStation()
        {
            InitializeComponent();

            station = null;
            DialogResult = DialogResult.Cancel;
        }

        private void addStationButton_Click(object sender, System.EventArgs e)
        {
            string name = this.textBox_newStationName.Text;
            station = new Station(name);
            DialogResult = DialogResult.OK;
        }
    }
}
