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

            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow);
            ((MainForm)this.MdiParent).MyDeleteEvent += new EventHandler(this.MyDelete);


            DatagridviewDesigns.SetDesign(dgvParent);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvParent, "코드", "Screen_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvParent, "이름", "Screen_Name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvParent, "날자", "Ins_Date", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvParent, "입력자", "Ins_Emp", true, 210, default, true);


            DatagridviewDesigns.SetDesign(dgvSon);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvSon, "부모코드", "Parent_Screen_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvSon, "화면코드", "Screen_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvSon, "화면이름", "Screen_Name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvSon, "날자", "Ins_Date", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvSon, "입력자", "Ins_Emp", true, 210, default, true);
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
                tvMenu.Nodes[i].Tag = parent[i].Screen_Code;
                var son = menulist.FindAll(s => s.Parent_Screen_Code == parent[i].Screen_Code);
                for (int j = 0; j < son.Count; j++)
                {
                    tvMenu.Nodes[i].Nodes.Add(son[j].Screen_Name);
                    tvMenu.Nodes[i].Nodes[j].Tag = son[j].Screen_Code;
                }
            }

            tvMenu.ExpandAll();
        }

        /// <summary>
        /// 입력 이벤트 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void InsertFormShow(object sender, EventArgs e)
        {

            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    MSS_SYS_001_1 frm = new MSS_SYS_001_1();

                    frm.ShowDialog();
                    datagridviewsetting();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Program.Log.WriteError(err.Message);
            }

        }
        private void MyDelete(object sender, EventArgs e)
        {

            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {

                    if (lbldeletecheck1.Text == "1")
            {
                if (MessageBox.Show(dgvParent.SelectedRows[0].Cells[0].Value.ToString() + "하위항목도 모두 삭제됩니다. 메뉴를 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //   MessageBox.Show(dgvParent.SelectedRows[0].Cells[0].Value.ToString());
                    if (service.DeleteMenuTree_Master_VO(dgvParent.SelectedRows[0].Cells[0].Value.ToString(), dgvParent.SelectedRows[0].Cells[0].Value.ToString()))
                    {
                        treeview();
                        datagridviewsetting();
                        MessageBox.Show(dgvParent.SelectedRows[0].Cells[0].Value.ToString() + "가 삭제되었습니다.", "알림", MessageBoxButtons.YesNo);
                    }
                }
            }
            else if (lbldeletecheck2.Text == "1")
            {
                if (MessageBox.Show(dgvSon.SelectedRows[0].Cells[1].Value.ToString() + "메뉴를 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //      MessageBox.Show(dgvSon.SelectedRows[0].Cells[1].Value.ToString());
                    if (service.DeleteMenuTree_Master_VO("-1", dgvSon.SelectedRows[0].Cells[1].Value.ToString()))
                    {
                        treeview();
                        datagridviewsetting();
                        MessageBox.Show(dgvParent.SelectedRows[0].Cells[0].Value.ToString() + "가 삭제되었습니다.", "알림", MessageBoxButtons.YesNo);
                              }
                }
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Program.Log.WriteError(err.Message);
            }

        }
        /// <summary>
        /// 새로고침 이벤트 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void RefreshFormShow(object sender, EventArgs e)
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    treeview();
                    datagridviewsetting();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Program.Log.WriteError(err.Message);
            }
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

            Point targetPoint = tvMenu.PointToClient(new Point(e.X, e.Y));

            TreeNode targetNode = tvMenu.GetNodeAt(targetPoint);


            if (targetNode != null && targetNode.Level == 0) //레벨0인곳에만 이동가능하게
            {

                // Retrieve the node that was dragged.
                TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

                if (draggedNode.Level != 0) // level0인 부모를 자식에게 넣지못하게
                {
                    if (!draggedNode.Equals(targetNode) && !ContainsNode(draggedNode, targetNode))
                    {
                        if (e.Effect == DragDropEffects.Move)
                        {
                            draggedNode.Remove();
                            targetNode.Nodes.Add(draggedNode);
                            service.UpdateManu(targetNode.Tag.ToString(), draggedNode.Tag.ToString()); //메뉴 db변경
                            ((MainForm)this.MdiParent).Setting();
                        }

                        else if (e.Effect == DragDropEffects.Copy)
                        {
                            targetNode.Nodes.Add((TreeNode)draggedNode.Clone());
                        }

                    }
                }
                else
                {
                    MessageBox.Show("이동할 수 없는 경로입니다.");
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

        private void DgvParent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbldeletecheck1.Text = "1";
            lbldeletecheck2.Text = "0";
        }

        private void DgvSon_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            lbldeletecheck1.Text = "0";
            lbldeletecheck2.Text = "1";
        }

        private void MSS_SYS_001_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).InsertFormEvent -= new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow);
            ((MainForm)this.MdiParent).MyDeleteEvent -= new EventHandler(this.MyDelete);
        }
    }
}
