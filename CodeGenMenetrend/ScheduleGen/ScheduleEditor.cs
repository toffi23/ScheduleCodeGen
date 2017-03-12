using CodeGenMenetrend.ScheduleLib;
using CodeGenMenetrend.ScheduleGen;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;

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
                Console.WriteLine(station.ToString());
                addNode(station, root.Nodes[0]);
            }

            // Expand main nodes
            root.ExpandAll();
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
                MessageBox.Show("schedule root node");
                return;
            }

            if(node.Tag == _schedule.Lines)
            {
                MessageBox.Show("Lines is selected");
                return; 
            }

            if(node.Tag == _schedule.Stations)
            {
                var editor = new StationEditor();
                editor.ShowDialog();
                editor.Location = Cursor.Position;
                if(editor.DialogResult == DialogResult.OK)
                {
                    _schedule.Stations.Add(editor.Station);
                    addNode(editor.Station,node);
                }
                return;
            }
        }

        private void addNode(object newNode,TreeNode parent)
        {
            var node = new TreeNode(newNode.ToString());
            node.Tag = newNode;
            parent.Nodes.Add(node);
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
                editor.ShowDialog();
                editor.Location = Cursor.Position;
                if (editor.DialogResult == DialogResult.OK)
                {
                    node.Text = ((Station)item).ToString();
                }
                return;
            }

        }
    }
}
