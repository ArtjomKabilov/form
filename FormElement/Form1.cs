using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormElement
{
    public partial class Form1 : Form
    {
        TreeView tree;
        Button btn;
        Label lbl;
        PictureBox pb;
        public Form1()
        {
            this.Height = 500;
            this.Width = 800;
            this.Text = "Vorm elementidega";
            tree = new TreeView();
            tree.Dock = DockStyle.Left;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode tn = new TreeNode("Elemendid");
            tn.Nodes.Add(new TreeNode("Nupp"));
            tn.Nodes.Add(new TreeNode("label"));
            tn.Nodes.Add(new TreeNode("PictureBox"));
            tn.Nodes.Add(new TreeNode("CheckBox"));
            tn.Nodes.Add(new TreeNode("Radiobutton"));
            tn.Nodes.Add(new TreeNode("TextBox"));
            tn.Nodes.Add(new TreeNode("TabControl"));
            tn.Nodes.Add(new TreeNode("MessageBox"));
            //nupp
            btn = new Button();
            btn.Text = "vajuta siia";
            btn.Location = new Point(150, 30);
            btn.Height = 30;
            btn.Width = 100;
            btn.Click += Btn_Click;
            //label
            lbl = new Label();
            lbl.Text = "Elamentide loomine c# abil";
            lbl.Size = new Size(60,30);
            lbl.Location = new Point(150, 0);
            lbl.MouseHover += Lbl_MouseHover;
            lbl.MouseLeave += Lbl_MouseLeave;
            //imageBox
            pb = new PictureBox();
            pb.Size = new Size(100, 100);
            pb.Location = new Point(150, 70);
            pb.ImageLocation = ("../../image/index.jpg");
            pb.SizeMode = PictureBoxSizeMode.AutoSize;
            pb.MouseDoubleClick += Pb_MouseDoubleClick;

            




            tree.Nodes.Add(tn);
            this.Controls.Add(tree);
            
        }

        private void Pb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            pb.ImageLocation = ("../../image/index2.jpg");
        }

        private void Lbl_MouseLeave(object sender, EventArgs e)
        {
            lbl.BackColor = Color.Transparent;
        }

        private void Lbl_MouseHover(object sender, EventArgs e)
        {
            lbl.BackColor = Color.FromArgb(76,0,153);
        }

        public void link()
        {
            System.Diagnostics.Process.Start("https://kabilov20.thkit.ee");
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            link();
        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text=="Nupp")
            {
                this.Controls.Add(btn);
            }
            else if (e.Node.Text == "label")
            {
                this.Controls.Add(lbl);
            }
            else if (e.Node.Text == "PictureBox")
            {
                this.Controls.Add(pb);
            }
        }
    }
}
