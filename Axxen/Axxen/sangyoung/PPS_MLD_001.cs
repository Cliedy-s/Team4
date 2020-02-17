using Axxen.Util;
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
    public partial class PPS_MLD_001 : Axxen.GridManageForm
    {
        List<MoldVO> moldList;
        List<MoldVO> moldSearchList;
        MoldService service = new MoldService();
        List<MoldVO> moldGroup;
        DataSet ds = new DataSet();
        public PPS_MLD_001()
        {
            InitializeComponent();
        }

        private void PPS_MLD_001_Load(object sender, EventArgs e)
        {
            MainDataLoad();
            moldList = service.SelectMoldAll();
            moldGroup = service.selectMoldGroup();
            dgvMainGrid.DataSource = moldList;
            ds = service.MoldWorkCenter();
            ComboBinding();
            
            aSplitContainer1.Panel2.Enabled = false;
            txtCode.Focus();
        }

        /// <summary>
        /// 콤보박스 바인딩
        /// </summary>
        private void ComboBinding()
        {
            cboGroup.Items.Insert(0, "==선택==");
            cboGroup.SelectedIndex = 0;
            foreach (var item in moldGroup)
            {
                cboGroup.Items.Add(item.Mold_Group);
            }

            cboWorkCenter.DisplayMember = "Wc_Name";
            cboWorkCenter.ValueMember = "Wc_Code";
            cboWorkCenter.DataSource = ds.Tables["Wc"];
            cboWorkCenter.Text = "==선택==";
        }
        
        public void InsertFormShow(object sender, EventArgs e)
        {
            aSplitContainer1.Panel2.Enabled = true;
            txtMoldCode.Focus();
        }//추가버튼클릭

        /// <summary>
        /// 데이터 그리드뷰 바인딩
        /// </summary>
        private void MainDataLoad()
        {
            InitControlUtil.SetDGVDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형코드", "Mold_Code", true, 100, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView_Autosize(dgvMainGrid, "금형명", "Mold_Name", true, 110, DataGridViewContentAlignment.MiddleCenter, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형그룹", "Mold_Group", true, 90, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형상태", "Mold_Status", true, 80, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형누적타수", "Cum_Shot_Cnt", true, 105, DataGridViewContentAlignment.MiddleRight);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형누적생산량", "Cum_Prd_Qty", true, 120, DataGridViewContentAlignment.MiddleRight);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형누적사용시간", "Cum_Time", true, 130, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "보장타수", "Guar_Shot_Cnt", true, 90, DataGridViewContentAlignment.MiddleRight);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "구입금액", "Purchase_Amt", true, 90, DataGridViewContentAlignment.MiddleRight);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "입고일자", "In_Date", true, 100, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "최종장착일시", "Last_Setup_Time", true, 140, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "사용여부", "Use_YN", true, 60, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "비고", "Remark", true, 140, DataGridViewContentAlignment.MiddleCenter);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "비고", "Wc_Code", false, 160);
        }

        private void RefreshFormShow(object sender, EventArgs e)
        {
            moldList = service.SelectMoldAll();
            dgvMainGrid.DataSource = moldList;
            cboGroup.SelectedIndex = 0;

            ResetUtillity.ResetPanelControl(aSplitContainer1.Panel2);
            txtMoldCode.TextBoxText = "";
            txtMoldName.TextBoxText = "";
            txtMoldGroup.TextBoxText = "";
            txtCost.TextBoxText = "";

        } //새로고침클릭

        /// <summary>
        /// 텍스트 박스 엔터클릭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">키 입력값</param>
        private void Text_TextKeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                SearchList();
            }
        }

        /// <summary>
        /// 조건 검색
        /// </summary>
        private void SearchList()
        {
            if (txtCode.TextBoxText.Length > 0 && txtName.TextBoxText.Length <= 0)
            {
                moldSearchList = (from data in moldList
                                  where data.Mold_Code.Contains(txtCode.TextBoxText)
                                  select data).ToList();
                txtCode.TextBoxText = "";
            }
            else if (txtName.TextBoxText.Length > 0 && txtCode.TextBoxText.Length <= 0)
            {
                moldSearchList = (from data in moldList
                                  where data.Mold_Name.Contains(txtName.TextBoxText)
                                  select data).ToList();
                txtName.TextBoxText = "";
            }
            else if (txtCode.TextBoxText.Length > 0 && txtName.TextBoxText.Length > 0)
            {
                moldSearchList = (from data in moldList
                                  where data.Mold_Code.Contains(txtCode.TextBoxText) || data.Mold_Name.Contains(txtName.TextBoxText)
                                  select data).ToList();
                txtCode.TextBoxText = "";
                txtName.TextBoxText = "";
            }
            else
            {
                MessageBox.Show("검색조건을 입력해 주세요.", "금형관리", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dgvMainGrid.DataSource = moldSearchList;
        }

        private void CboDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGroup.SelectedIndex == 0)
            {
                RefreshFormShow(null, null);
            }
            else
            {
                var moldgroupList = (from mgroup in moldList
                                     where mgroup.Mold_Group.Contains(cboGroup.SelectedItem.ToString())
                                     select mgroup).ToList();
                dgvMainGrid.DataSource = moldgroupList;
            }
        }//콤보박스 목록선택

        private void PPS_MLD_001_Activated(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow);//새로고침이벤트
            ((MainForm)this.MdiParent).MyDeleteEvent += new EventHandler(this.DeleteFormShow); //삭제 이벤트
            ToolStripManager.Merge(toolStrip1, ((MainForm)this.MdiParent).toolStrip1); //저장버튼 추가
            toolStrip1.Visible = false;
            dgvMainGrid.ClearSelection();
        }

        private void DeleteFormShow(object sender, EventArgs e)
        {
            if(dgvMainGrid.Focused)
            {
                string moldno = dgvMainGrid[0, dgvMainGrid.CurrentRow.Index].Value.ToString();
                bool result = service.DeleteMolde(moldno);
                if(result)
                {
                    MessageBox.Show("Success");
                    RefreshFormShow(null, null);
                }
                else
                    MessageBox.Show("Fail");
            }
            else
            {
                MessageBox.Show("삭제할 목록을 선택해 주세요.","금형정보관리",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void PPS_MLD_001_Deactivate(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).InsertFormEvent -= new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow);//새로고침이벤트
            ((MainForm)this.MdiParent).MyDeleteEvent -= new EventHandler(this.DeleteFormShow);
            ToolStripManager.RevertMerge(((MainForm)this.MdiParent).toolStrip1); //저장버튼삭제
        }

        /// <summary>
        /// 금형정보등록 - 저장버튼클릭
        /// </summary>
        private void TsbtnSave_Click(object sender, EventArgs e)
        {
            MoldVO minfo = new MoldVO
            {
                Mold_Code = txtMoldCode.TextBoxText,
                Mold_Name = txtMoldName.TextBoxText,
                Mold_Group = txtMoldGroup.TextBoxText,
                Mold_Status = "양호",
                Cum_Prd_Qty = 0,
                Cum_Shot_Cnt = 0,
                Cum_Time = 0,
                Guar_Shot_Cnt = Convert.ToInt32(numHit.Value),
                In_Date = dtpInDate.Value,
                Last_Setup_Time = dtpLastEquip.Value,
                Purchase_Amt = Convert.ToInt32(txtCost.TextBoxText),
                Remark = txtRemark.Text,
                Use_YN = "N",
                Wc_Code = cboWorkCenter.SelectedValue.ToString()
            };
            bool result = service.InsertMold(minfo);
            if (result)
                MessageBox.Show("성공");
            else
                MessageBox.Show("실패");

            RefreshFormShow(null, null);
        }
    }
}
