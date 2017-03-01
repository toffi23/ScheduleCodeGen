using CodeGenMenetrend.ScheduleLib;
using System.Windows.Forms;


namespace CodeGenMenetrend
{
    public partial class ScheduleEditor : Form
    {
        private MainMenu _parent;
        private Schedule _schedule;
        

        public ScheduleEditor(MainMenu pParent)
        {
            InitializeComponent();

            this._parent = pParent;

            // TODO: deserialize _schedule

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

            // Expand main nodes
            root.ExpandAll();
        }

        private void ScheduleEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
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
                MessageBox.Show("Stations is selected.");
                return;
            }

        }
    }
}
