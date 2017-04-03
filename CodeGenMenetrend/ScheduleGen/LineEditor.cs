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

namespace CodeGenMenetrend.ScheduleGen
{
    public partial class LineEditor : Form
    {
        public Line Line;

        public LineEditor(Line pLine = null)
        {
            InitializeComponent();

            if(pLine != null)
            {
                this.Line = pLine;
                this.Text = this.Line.ID;
                this.textBox1.Text = this.Line.ID;
            }
            else
            {
                this.Text = "Új járat";
            }

            this.AcceptButton = this.button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acceptData();
        }

        private void acceptData()
        {
            if(Line == null)
            {
                string id = this.textBox1.Text;
                Line = new Line(id);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                Line.ID = this.textBox1.Text;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
