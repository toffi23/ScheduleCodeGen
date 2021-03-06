﻿using CodeGenMenetrend.ScheduleLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace CodeGenMenetrend.ScheduleGen
{
    public partial class StopEditor : Form
    {
        public Stop Stop { get; private set; }

        public StopEditor(BindingList<Station> pStations,Stop pStop = null)
        {
            InitializeComponent();

            if(pStop != null)
            {
                this.Stop = pStop;
                this.Text = this.Stop.Station.Name;
            }
            else
            {
                this.Text = "Új állomás";
            }

            var stationList = pStations.OrderBy(x => x.Name).ToList();

            this.listBox1.DataSource = stationList;
            this.AcceptButton = this.button1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acceptData();
        }

        private void acceptData()
        {
            if(this.Stop == null)
            {
                Station station = (Station)this.listBox1.SelectedItem;
                Stop = new Stop(station, (int)this.numericUpDown1.Value);
            }
            else
            {
                Stop.Station = (Station)listBox1.SelectedItem;
                Stop.Delay = (int)numericUpDown1.Value;
            }

            this.DialogResult = DialogResult.OK;
        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            this.numericUpDown1.Select(0, numericUpDown1.Value.ToString().Length);
        }
    }
}
