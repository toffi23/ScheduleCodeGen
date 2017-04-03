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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button_calGen_Click(object sender, EventArgs e)
        {
            LabelCal calGen = new LabelCal(this);
            this.Hide();
            calGen.StartPosition = FormStartPosition.CenterScreen;
            calGen.Show();

        }

        private void button_scheduleGen_Click(object sender, EventArgs e)
        {
            ScheduleEditor scheduleEditor = new ScheduleEditor(this);
            this.Hide();
            scheduleEditor.StartPosition = FormStartPosition.CenterScreen;
            scheduleEditor.Show();
        }
    }
}
