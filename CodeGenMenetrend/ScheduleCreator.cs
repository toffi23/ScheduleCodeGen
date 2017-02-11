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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

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
            try
            {
                var formatter = new BinaryFormatter();
                var stream = new FileStream("Schedule.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                schedule = (Schedule)formatter.Deserialize(stream);
                stream.Close();
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show($"Couldn't find Schedule.bin. Creating empty schedule");
                schedule = new Schedule();
            }

            
        }

        private void ScheduleCreator_FormClosing(object sender, FormClosingEventArgs e)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("Schedule.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, schedule);
            stream.Close();

            parent.Show();
        }

        private void button_StationList_Click(object sender, EventArgs e)
        {
            StationListEditor editor = new StationListEditor(schedule.Stations);
            editor.Location = Cursor.Position;
            editor.Show(this);
        }

        private void button_lineList_Click(object sender, EventArgs e)
        {
            LineList editor = new LineList(schedule.Lines);
            editor.Location = Cursor.Position;
            editor.Show(this);
        }
    }
}
