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
    public partial class LineList : Form
    {
        private BindingList<Line> lines;

        public LineList(BindingList<Line> _lines)
        {
            InitializeComponent();

            lines = _lines;
            listBox_lines.DataSource = lines;
        }

        private void button_addLine_Click(object sender, EventArgs e)
        {
            LineEdit dialog = new LineEdit();
            var result = dialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                lines.Add(dialog.line);
            }
        }
    }
}
