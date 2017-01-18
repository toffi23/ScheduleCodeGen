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

            listBox_editStations.DataSource = stations;
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

        private void button_removeStation_Click(object sender, EventArgs e)
        {
            // TODO: do not allow removing stations that are used in schedule but list the lines that are use it
            if(listBox_editStations.SelectedItem == null)
            {
                MessageBox.Show("You must select a station first.");
                return;
            }

            Station toRemove = stations[listBox_editStations.SelectedIndex];
            stations.Remove(toRemove);
        }
    }
}
