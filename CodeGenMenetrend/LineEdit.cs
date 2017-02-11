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
    public partial class LineEdit : Form
    {
        public Line line { get; set; }

        public LineEdit()
        {
            InitializeComponent();
        }

        private void button_OkLine_Click(object sender, EventArgs e)
        {
            string id = textBox_lineID.Text;
            if(line == null)
            {
                line = new Line(id);
            }
            else
            {
                line.ID = id;
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
