using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VO;

namespace Axxen
{
    public partial class MDS_SDS_007 : Axxen.BaseForm
    {
        ItemMaster_Service itemservice = new ItemMaster_Service();
        List<Item_MasterVO> Itemlist; //품목

        WorkCenter_MasterService workcenterservice = new WorkCenter_MasterService();
        List<WorkCenter_MasterVO> workcenterlist; //작업장

        Condition_Spec_MasterService Conditionservice = new Condition_Spec_MasterService();
        List<ConditionSpecVO> Conditionlist; //공정조건



        public MDS_SDS_007()
        {
            InitializeComponent();


        }

        private void MDS_SDS_007_Load(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).MyUpdateEvent += new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow);
            ((MainForm)this.MdiParent).MyDeleteEvent += new EventHandler(this.MyDelete);

            DatagridviewDesigns.SetDesign(dgvItem);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "품목코드", "Item_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "품목명", "Item_Name", true, 210, default, true);


            DatagridviewDesigns.SetDesign(dgvCondition);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCondition, "품목코드", "Item_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCondition, "작어장코드", "Wc_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCondition, "검사항목코드", "Condition_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCondition, "검사항목명", "Condition_Name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCondition, "규격상한값", "USL", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCondition, "규격기준값", "SL", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCondition, "규격하한값", "LSL", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCondition, "단위", "Condition_Unit", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvCondition, "비고", "Remark", true, 210, default, true);

            GetAllItem();
            ControlSetting();
        }

        /// <summary>
        /// 모든 그룹정보 GET
        /// </summary>
        private void GetAllItem()
        {
            try
            {

                Itemlist = new List<Item_MasterVO>(); //품목전체
                Itemlist = itemservice.GetAllItem_Master().FindAll(item=>item.Item_Type.Trim().Equals("PR"));
                dgvItem.DataSource = Itemlist;


                workcenterlist = new List<WorkCenter_MasterVO>(); //작업장
                workcenterlist = workcenterservice.GetAll().FindAll(work=>work.Use_YN.Equals("Y"));

                Conditionlist = new List<ConditionSpecVO>();
                Conditionlist = Conditionservice.GetAll();

            }
            catch (Exception err)
            {
                Program.Log.WriteError(err.Message);
                throw;
            }
        }
        /// <summary>
        ///  콤보박스세팅
        /// </summary>
        private void ControlSetting()
        {
         
            Dictionary<string, string> cbblistwork = workcenterlist.ToDictionary(code => code.Wc_Code, name => name.Wc_Name);
            cbbwork.DisplayMember = "Value";
            cbbwork.ValueMember = "Key";
            cbbwork.DataSource = new BindingSource(cbblistwork, null);
            lblwork.Text = cbbwork.SelectedValue.ToString();

            // combobox  품목명

            List<Item_MasterVO> dictionname = Itemlist.GroupBy(name => name.Item_Code).Select(grp => grp.First()).ToList();
            Dictionary<string, string> cbblistname = dictionname.ToDictionary(code => code.Item_Code, name => name.Item_Name);
            cbbItem.DisplayMember = "Value";
            cbbItem.ValueMember = "Key";
            cbbItem.DataSource = new BindingSource(cbblistname, null);
            lblItem.Text = cbbItem.SelectedValue.ToString();
        }
        /// <summary>
        /// 수정
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void MyUpdateShow(object sender, EventArgs e)
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    if (dgvCondition.RowCount > 0) { 
                    MDS_SDS_007_1 frm = new MDS_SDS_007_1();
                    frm.upadatecondition = Conditionlist.Find(item => item.Item_Code.Trim().Equals(dgvCondition.SelectedRows[0].Cells[0].Value.ToString())
                    && item.Wc_Code.Trim().Equals(dgvCondition.SelectedRows[0].Cells[1].Value.ToString())
                    && item.Condition_Code.Trim().Equals(dgvCondition.SelectedRows[0].Cells[2].Value.ToString()));

              
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        GetAllItem();
                        ControlSetting();//콤보박스 
                        MessageBox.Show("저장 완료", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MDS_SDS_007_1 frm = new MDS_SDS_007_1();
                   if(frm.ShowDialog() == DialogResult.OK) { 
                    GetAllItem();
                    ControlSetting();//콤보박스 
                        MessageBox.Show("저장 완료", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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

                    if (MessageBox.Show(dgvCondition.SelectedRows[0].Cells[3].Value.ToString() + "를 삭제하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        
                        // MessageBox.Show(dgvMainGrid.SelectedRows[0].Cells[0].Value.ToString());
                        if (Conditionservice.DeleteConditionSpecVO(dgvCondition.SelectedRows[0].Cells[0].Value.ToString(), dgvCondition.SelectedRows[0].Cells[1].Value.ToString(), dgvCondition.SelectedRows[0].Cells[2].Value.ToString()))
                        {
                            GetAllItem();
                            ControlSetting();//콤보박스 
                        }
                        else
                        {
                            MessageBox.Show("삭제실패");
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
                    GetAllItem();
                    ControlSetting();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Program.Log.WriteError(err.Message);
            }
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            MDS_SDS_007_2 frm = new MDS_SDS_007_2();

            frm.itemCode = lblItem.Text;
            frm.WorkCode = lblwork.Text;
        
            if (frm.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("저장 완료", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAllItem();
                ControlSetting();
            };
        }


        private void CbbItem_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            lblItem.Text = cbbItem.SelectedValue.ToString();
        }

        private void Cbbwork_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblwork.Text = cbbwork.SelectedValue.ToString();
        }

        private void DgvItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Getinspects(dgvItem.SelectedRows[0].Cells[0].Value.ToString());
        }
        /// <summary>
        /// 선택한 그룹의 화면get
        /// </summary>
        private void Getinspects(string itemcode)
        {
            dgvCondition.DataSource = null;
            dgvCondition.DataSource = Conditionlist.FindAll(item => item.Item_Code == itemcode);
        }

        private void MDS_SDS_007_FormClosing(object sender, FormClosingEventArgs e)
        {
            ((MainForm)this.MdiParent).MyUpdateEvent -= new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent -= new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow);
            ((MainForm)this.MdiParent).MyDeleteEvent -= new EventHandler(this.MyDelete);
        }
    }
}
