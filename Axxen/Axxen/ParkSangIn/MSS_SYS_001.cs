using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VO;

namespace Axxen
{
    public partial class MSS_SYS_001 : Axxen.BaseForm
    {
        List<MenuTree_Master_VO> menulist; //메뉴
        MainForm_Service service = new MainForm_Service();
        public MSS_SYS_001()
        {
            InitializeComponent();
        }

        private void MSS_SYS_001_Load(object sender, EventArgs e)
        {
            ImageList imgList = new ImageList();
            //imgList.Images.Add(Bitmap.FromFile("treeimg.png"));
            imgList.Images.Add(Properties.Resources.treeimg);
            tvMenu.ImageList = imgList;
            tvMenu.AllowDrop = true;
            treeview();
         

             DatagridviewDesigns.SetDesign(dgvParent);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvParent, "코드", "Screen_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvParent, "이름", "Screen_Name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvParent, "날자", "Ins_Date", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvParent, "입력자", "Ins_Emp", true, 210, default, true);


            DatagridviewDesigns.SetDesign(dgvSon);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSon, "부모코드", "Parent_Screen_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSon, "화면코드", "Screen_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSon, "화면이름", "Screen_Name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSon, "날자", "Ins_Date", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvSon, "입력자", "Ins_Emp", true, 210, default, true);
            datagridviewsetting();
        }

        private void treeview()
        {
            tvMenu.Nodes.Clear();

            menulist = service.GetAll_MenuTree_Master();
            var parent = menulist.FindAll(p => p.Parent_Screen_Code == null);

            for (int i = 0; i < parent.Count; i++)
            {
                tvMenu.Nodes.Add(parent[i].Screen_Name);
                var son = menulist.FindAll(s => s.Parent_Screen_Code == parent[i].Screen_Code);
                for (int j = 0; j < son.Count; j++)
                {
                    tvMenu.Nodes[i].Nodes.Add(son[j].Screen_Name);
                }
            }

            tvMenu.ExpandAll();
        }

        private void datagridviewsetting()
        {
            var parent = menulist.FindAll(p => p.Parent_Screen_Code == null);
            dgvParent.DataSource = parent;


            var son = menulist.FindAll(p => p.Parent_Screen_Code == dgvParent.SelectedRows[0].Cells[0].Value.ToString());
            dgvSon.DataSource = son;
        }
        #region drawtreeview
        private void TvMenu_DragDrop(object sender, DragEventArgs e)
        {
            // Retrieve the client coordinates of the drop location.
            Point targetPoint = tvMenu.PointToClient(new Point(e.X, e.Y));

            // Retrieve the node at the drop location.
            TreeNode targetNode = tvMenu.GetNodeAt(targetPoint);
       

            if (targetNode.Level==0)
            { 

            // Retrieve the node that was dragged.
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

            // Confirm that the node at the drop location is not 
            // the dragged node or a descendant of the dragged node.
            if (!draggedNode.Equals(targetNode) && !ContainsNode(draggedNode, targetNode))
            {
                // If it is a move operation, remove the node from its current 
                // location and add it to the node at the drop location.
                if (e.Effect == DragDropEffects.Move)
                {
                    draggedNode.Remove();
                    targetNode.Nodes.Add(draggedNode);
                }

                // If it is a copy operation, clone the dragged node 
                // and add it to the node at the drop location.
                else if (e.Effect == DragDropEffects.Copy)
                {
                    targetNode.Nodes.Add((TreeNode)draggedNode.Clone());
                }

                // Expand the node at the location 
                // to show the dropped node.
                targetNode.Expand();
            }
            }
            else
            {
                MessageBox.Show("이동할 수 없는 경로입니다.");
            }
        }

        private void TvMenu_DragEnter(object sender, DragEventArgs e)
        {

            e.Effect = e.AllowedEffect;
        }

        private void TvMenu_DragOver(object sender, DragEventArgs e)
        {
            // 마우스 위치의 클라이언트 좌표를 가져옵니다.

            // Retrieve the client coordinates of the mouse position.
            Point targetPoint = tvMenu.PointToClient(new Point(e.X, e.Y));

            // Select the node at the mouse position.
            tvMenu.SelectedNode = tvMenu.GetNodeAt(targetPoint);
            //    tvMenu.tvPersonSaveXml();
        }

        private void TvMenu_ItemDrag(object sender, ItemDragEventArgs e)
        {
            // Move the dragged node when the left mouse button is used.
            if (e.Button == MouseButtons.Left)
            {
                DoDragDrop(e.Item, DragDropEffects.Move);
            }

            // Copy the dragged node when the right mouse button is used.
            else if (e.Button == MouseButtons.Right)
            {
                DoDragDrop(e.Item, DragDropEffects.Copy);
            }
        }

        private void TvMenu_MouseDown(object sender, MouseEventArgs e)
        {
            tvMenu.GetNodeAt(e.X, e.Y);

            if (tvMenu.SelectedNode != null)

            {

        //        tvMenu.tvPersonSaveXml();

            }
        }

        private bool ContainsNode(TreeNode node1, TreeNode node2)
        {
            // Check the parent node of the second node.
            if (node2.Parent == null) return false;
            if (node2.Parent.Equals(node1)) return true;

            // If the parent node is not null or equal to the first node, 
            // call the ContainsNode method recursively using the parent of 
            // the second node.
            return ContainsNode(node1, node2.Parent);
        }
        #endregion
        private void DgvParent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSon.DataSource = null;
           var son = menulist.FindAll(p => p.Parent_Screen_Code == dgvParent.SelectedRows[0].Cells[0].Value.ToString());
            dgvSon.DataSource = son;
        }
    }
}
