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

namespace CodeGenMenetrend
{
    public partial class StationListEditor : Form
    {
        private BindingList<Station> stations;

        public StationListEditor(BindingList<Station> pStations)
        {
            InitializeComponent();


            stations = pStations;
        }

        private void button_addStation_Click(object sender, EventArgs e)
        {
            AddNewStation addDialog = new AddNewStation();
            if(addDialog.ShowDialog() == DialogResult.OK)
            {
                stations.Add(addDialog.station);
                MessageBox.Show($"New station: {addDialog.station.Name}");
            }

            Console.WriteLine("Stationlist:");
            foreach(Station s in stations)
            {
                Console.WriteLine(s.Name);
            }
        }
    }
}
