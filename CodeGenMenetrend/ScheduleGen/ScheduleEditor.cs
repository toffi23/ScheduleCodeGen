using CodeGenMenetrend.ScheduleLib;
using CodeGenMenetrend.ScheduleGen;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;
using System.Collections.Generic;

namespace CodeGenMenetrend
{
    public partial class ScheduleEditor : Form
    {
        private MainMenu _parent;
        private Schedule _schedule;
        
        private Point TopRightCorner
        {
            get
            {
                return new Point(
                    this.Location.X + this.Width,
                    this.Location.Y
                    );
            }
        }

        public ScheduleEditor(MainMenu pParent)
        {
            InitializeComponent();
            
            this._parent = pParent;

            // TODO: deserialize _schedule
            _schedule = DeSerialize();

            if (_schedule == null)
            {
                _schedule = new Schedule();
            
            }
            drawTree();
        }

        private void drawTree()
        {
            // Add root node
            var root = new TreeNode("Menetrend");
            root.Tag = _schedule;
            this.treeView1.Nodes.Add(root);

            // Add stationlist and linelist basic nodes to root
            var mainNode = new TreeNode("Megállók");
            mainNode.Tag = _schedule.Stations;
            root.Nodes.Add(mainNode);

            mainNode = new TreeNode("Járatok");
            mainNode.Tag = _schedule.Lines;
            root.Nodes.Add(mainNode);

            // Add Station nodes 
            foreach(var station in _schedule.Stations)
            {
                addNode(station, root.Nodes[0]);
            }

            // Add Line nodes
            foreach(var line in _schedule.Lines)
            {
                TreeNode node = addNode(line, root.Nodes[1]);
                node.Nodes.Add(drawTracks(line));
                node.Nodes.Add(drawStarts(line));
            }

            // Expand main nodes
            root.Expand();
        }

        private TreeNode drawTracks(Line pLine)
        {
            TreeNode tracksNode = new TreeNode("Útvonalak");
            tracksNode.Tag = pLine.Tracks;
            int trackNum = 0;
            
            foreach(var track in pLine.Tracks)
            {
                var trNode = new TreeNode((++trackNum).ToString());
                trNode.Tag = track;
                foreach(var stop in track.Stops)
                {
                    var stopNode = new TreeNode(stop.ToString());
                    stopNode.Tag = stop;
                    trNode.Nodes.Add(stopNode);
                }
                tracksNode.Nodes.Add(trNode);
            }

            return tracksNode;
        }

        private TreeNode drawStarts(Line pLine)
        {
            TreeNode startsNode = new TreeNode("Indulási idők");
            startsNode.Tag = pLine.Starts;

            foreach(var start in pLine.Starts)
            {
                var sNode = new TreeNode(start.ToString());
                sNode.Tag = start;
                startsNode.Nodes.Add(sNode);
            }

            return startsNode;
        }

        private void updateLineNodeName(TreeNode pLineNode)
        {
            pLineNode.Text = ((Line)pLineNode.Tag).ToString();
        }

        private Schedule DeSerialize()
        {
            Schedule sched = null;

            try
            {
                using (var fs = new FileStream("Schedule.bin", FileMode.Open))
                {
                    var bf = new BinaryFormatter();
                    sched = (Schedule)bf.Deserialize(fs);
                }
            }
            catch(FileNotFoundException ex)
            {
                MessageBox.Show("Schedule.bin is not found.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something terrible has happened :S\n"+ex.ToString());
            }

            return sched;
        }

        private void ScheduleEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Mented a változásokat?","Változások mentése", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                try
                {
                    var bf = new BinaryFormatter();
                    var stream = new FileStream("Schedule.bin", FileMode.Create);
                    bf.Serialize(stream, _schedule);
                    stream.Close();
                    stream.Dispose();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something terrible has happened :S\n" + ex.ToString());
                }
            }

            this._parent.Show();
        }

        private void button_Add_Click(object sender, System.EventArgs e)
        {
            TreeNode node = this.treeView1.SelectedNode;
            this.treeView1.Select();

            if(node == null)
            {
                MessageBox.Show("Nincs kijelölt elem.");
                return;
            }

            if(node.Tag == _schedule)
            {
                // Do nothing with root node
                return;
            }

            if(node.Tag == _schedule.Lines)
            {
                var editor = new LineEditor();
                editor.StartPosition = FormStartPosition.CenterParent;
                editor.ShowDialog();
                if(editor.DialogResult == DialogResult.OK)
                {
                    _schedule.Lines.Add(editor.Line);
                    TreeNode newNode = addNode(editor.Line, node);
                    newNode.Nodes.Add("Útvonalak").Tag = editor.Line.Tracks;
                }

                return; 
            }

            if(node.Tag == _schedule.Stations)
            {
                var editor = new StationEditor();
                editor.StartPosition = FormStartPosition.CenterParent;
                editor.ShowDialog();
                if(editor.DialogResult == DialogResult.OK)
                {
                    _schedule.Stations.Add(editor.Station);
                    addNode(editor.Station,node);
                }
                return;
            }

            if (node.Tag is ICollection<Track>)
            {
                Line line = (Line)node.Parent.Tag;
                int trackNr = line.Tracks.Count + 1;
                TreeNode trackNode = new TreeNode(trackNr.ToString());
                Track newTrack = new Track(trackNr);
                trackNode.Tag = newTrack;
                line.Tracks.Add(newTrack);
                node.Nodes.Add(trackNode);
            }

            if(node.Tag is Track)
            {
                Track track = (Track)node.Tag;
                var editor = new StopEditor(_schedule.Stations);
                editor.StartPosition = FormStartPosition.CenterParent;
                editor.ShowDialog();
                if(editor.DialogResult == DialogResult.OK)
                {
                    track.Stops.Add(editor.Stop);
                    addNode(editor.Stop, node);
                    updateLineNodeName(node.Parent.Parent);
                }
            }

            if(node.Tag is ICollection<Start>)
            {
                Line line = (Line)node.Parent.Tag;
                var editor = new StartEditor(line.Tracks);
                editor.StartPosition = FormStartPosition.CenterParent;
                editor.ShowDialog();
                if (editor.DialogResult == DialogResult.OK)
                {
                    line.Starts.Add(editor.Start);
                    addNode(editor.Start, node);
                }
            }

        }
        /**
        * Return the TreeNode created from the object newNode
        */
        private TreeNode addNode(object newNode,TreeNode parent)
        {
            var node = new TreeNode(newNode.ToString());
            node.Tag = newNode;
            parent.Nodes.Add(node);

            return node;
        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
            TreeNode node = this.treeView1.SelectedNode;
            this.treeView1.Select();

            if (node == null)
            {
                MessageBox.Show("Nincs kijelölt elem.");
                return;
            }

            var item = node.Tag;

            if (item == _schedule)
            {
                // Do nothing with root node
                MessageBox.Show("Schedule root node");
                return;
            }

            if (item == _schedule.Lines)
            {
                MessageBox.Show("Lines is selected");
                return;
            }

            if (item == _schedule.Stations)
            {
                MessageBox.Show("Stations is selected");
                return;
            }

            if(item is Station)
            {
                var editor = new StationEditor((Station)item);
                editor.StartPosition = FormStartPosition.CenterParent;
                editor.ShowDialog();
                if (editor.DialogResult == DialogResult.OK)
                {
                    node.Text = ((Station)item).ToString();
                }
                return;
            }

            if(item is Line)
            {
                var editor = new LineEditor((Line)item);
                editor.StartPosition = FormStartPosition.CenterParent;
                editor.ShowDialog();
                if (editor.DialogResult == DialogResult.OK)
                {
                    node.Text = ((Line)item).ToString();
                }
                return;
            }

            if (item is Stop)
            {
                var editor = new StopEditor(_schedule.Stations,(Stop)item);
                editor.StartPosition = FormStartPosition.CenterParent;
                editor.ShowDialog();
                if (editor.DialogResult == DialogResult.OK)
                {
                    node.Text = ((Stop)item).ToString();
                }
            }

            if (item is Start)
            {
                Line line = (Line)node.Parent.Parent.Tag;
                var editor = new StartEditor(line.Tracks,(Start)node.Tag);
                editor.StartPosition = FormStartPosition.CenterParent;
                editor.ShowDialog();
                if (editor.DialogResult == DialogResult.OK)
                {
                    node.Text = ((Start)item).ToString();
                }
            }

        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Sajnálom, de ez a funkció még nincs implementálva :(."+Environment.NewLine+
                "További információért lépj kapcsolatba a fejlesztővel: Maschefszki Tamás");
        }
    }
}
