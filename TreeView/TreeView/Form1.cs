using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadTreeView();
        }

        void LoadTreeView()
        {
            TreeNode root1 = new TreeNode();
            root1.Text = "Root 1 ne";

            TreeNode node1 = new TreeNode() { Text = "Node 1 ne"};
            root1.Nodes.Add(node1);

            TreeNode root2 = new TreeNode();
            root2.Text = "Root 2 ne";
            tv.Nodes.Add(root1);
            tv.Nodes.Add(root2);
        }
    }
}
