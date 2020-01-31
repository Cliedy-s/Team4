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
    public partial class MDS_SDS_006 : Axxen.BaseForm
    {
        ItemMaster_Service itemservice = new ItemMaster_Service(); //품목
        List<Item_MasterVO> Itemlist;

        Inspect_Spec_MasterService inspectservice = new Inspect_Spec_MasterService(); 
        List<InspectSpecVO> inspectlist; //검사항목규격

        ProcessService processService = new ProcessService(); //공정
        List<Process_MasterVO> processlist;

        public MDS_SDS_006()
        {
            InitializeComponent();
        }

        private void MDS_SDS_006_Load(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).MyUpdateEvent += new System.EventHandler(this.MyUpdateShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow);// 수정


            DatagridviewDesigns.SetDesign(dgvItem);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "품목코드", "Item_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvItem, "품목명", "Item_Name", true, 210, default, true);


            DatagridviewDesigns.SetDesign(dgvinspect);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "품목코드", "Item_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "공정코드", "Process_code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "검사항목코드", "Inspect_code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "검사항목명", "Inspect_name", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "규격상한값", "USL", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "규격기준값", "SL", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "규격하한값", "LSL", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "샘플크기", "Sample_size", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "단위", "Inspect_Unit", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "비고", "Remark", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvinspect, "사용여부", "Use_YN", true, 210, default, true);

            DataGridViewButtonColumn gridbtn = new DataGridViewButtonColumn();
            gridbtn.HeaderText = "사용여부";
            gridbtn.Text = "변경";
            gridbtn.Name = "btn";
            gridbtn.Width = 100;
            gridbtn.FlatStyle = FlatStyle.Popup;
            gridbtn.DefaultCellStyle.BackColor = Color.LightYellow;
            gridbtn.UseColumnTextForButtonValue = true;
            dgvinspect.Columns.Add(gridbtn);

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
                Itemlist = itemservice.GetAllItem_Master();
                dgvItem.DataSource = Itemlist;

                inspectlist = new List<InspectSpecVO>();
                inspectlist= inspectservice.GetAll();//품목규격전체

                processlist = new List<Process_MasterVO>(); //공정 목록
                processlist = processService.GetAllProcess_Master();
        
                dgvinspect.DataSource = inspectlist.FindAll(item => item.Item_Code == dgvItem.SelectedRows[0].Cells[0].Value.ToString()); 
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
            // combobox  품목명
            List<Item_MasterVO> dictionname = Itemlist.GroupBy(name => name.Item_Code).Select(grp => grp.First()).ToList();

            Dictionary<string, string> cbblistname = dictionname.ToDictionary(code => code.Item_Code, name => name.Item_Name);
            cbbItem.DisplayMember = "Value";
            cbbItem.ValueMember = "Key";
            cbbItem.DataSource = new BindingSource(cbblistname, null);
            lblItem.Text = cbbItem.SelectedValue.ToString();

          
            //공정 콤보
            Dictionary<string, string> cbbprocesslist = processlist.ToDictionary(code => code.Process_code, name => name.Process_name);
            cbbprocess.DisplayMember = "Value";
            cbbprocess.ValueMember = "Key";
            cbbprocess.DataSource = new BindingSource(cbbprocesslist, null);
            cbbprocess.Text = cbbprocess.SelectedValue.ToString();
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
                   if (dgvinspect.SelectedRows[0].Cells[0].Value != null)
                    {
                        MDS_SDS_006_1 frm = new MDS_SDS_006_1();

                        frm.updateinspectitem = inspectlist.Find(item => item.Item_Code == dgvinspect.SelectedRows[0].Cells[0].Value.ToString() && item.Process_code == dgvinspect.SelectedRows[0].Cells[1].Value.ToString() && item.Inspect_code == dgvinspect.SelectedRows[0].Cells[2].Value.ToString());
                     
             
                        frm.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("품질귝격을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MDS_SDS_006_1 frm = new MDS_SDS_006_1();

                    frm.ShowDialog();
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
                    ///
                    ControlSetting();
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Program.Log.WriteError(err.Message);
            }
        }

        private void DgvItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Getinspects(dgvItem.SelectedRows[0].Cells[0].Value.ToString());
        }
        /// <summary>
        /// 선택한 그룹의 화면get
        /// </summary>
        private void Getinspects(string groupCode)
        {

           
            dgvinspect.DataSource = null;
            dgvinspect.DataSource = inspectlist.FindAll(item => item.Item_Code == groupCode);
        }

        private void AButton1_Click(object sender, EventArgs e)
        {
            MDS_SDS_006_2 frm = new MDS_SDS_006_2();

            frm.itemCode = lblItem.Text;
            frm.Process_code = lblprocess.Text;
            frm.ShowDialog();
        }


        private void CbbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblItem.Text = cbbItem.SelectedValue.ToString();
        }

        private void Cbbprocess_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblprocess.Text = cbbprocess.SelectedValue.ToString();
        }

        private void Dgvinspect_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            InspectSpecVO useitem = new InspectSpecVO();
            try
            {

                if (e.ColumnIndex == dgvinspect.Columns["btn"].Index)//눌러서 사용과 사용안함 변경
                {

                    useitem.Item_Code = dgvinspect.SelectedRows[0].Cells[0].Value.ToString();
                    useitem.Process_code = dgvinspect.SelectedRows[0].Cells[1].Value.ToString();
                    useitem.Inspect_code = dgvinspect.SelectedRows[0].Cells[2].Value.ToString();

                
                    if ((dgvinspect.SelectedRows[0].Cells[10].Value).ToString() == "Y") //사용안함
                    {
                        inspectservice.UseInspectSpec(useitem, "N");
                    }
                    else //사용함
                    {
                        inspectservice.UseInspectSpec(useitem, "Y");
                    }
                    GetAllItem(); 
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
                Program.Log.WriteError(err.Message);
            }
        }
    }
}
