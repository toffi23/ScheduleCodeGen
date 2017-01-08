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
            

            stations = new BindingList<Station>(pStations);
        }

        private void button_addStation_Click(object sender, EventArgs e)
        {

        }
    }
}
