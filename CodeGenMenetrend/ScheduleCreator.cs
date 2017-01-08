using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeGenMenetrend.ScheduleLib;

namespace CodeGenMenetrend
{
    public partial class ScheduleCreator : Form
    {
        private MainMenu parent;
        private Schedule schedule;

        public ScheduleCreator(MainMenu mainMenu)
        {
            InitializeComponent();

            parent = mainMenu;
            schedule = new Schedule(); 
        }

        private void ScheduleCreator_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void button_StationList_Click(object sender, EventArgs e)
        {
            StationListEditor editor = new StationListEditor(schedule.Stations);
            editor.Show(this);
            

        }
    }
}
