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
        MoldService service = new MoldService();
        string[] month = { "1월", "2월", "3월", "4월", "5월", "6월", "7월", "8월", "9월", "10월", "11월", "12월" };
        public PPS_MLD_001()
        {
            InitializeComponent();
        }

        private void PPS_MLD_001_Load(object sender, EventArgs e)
        {
            MainDataLoad();
            moldList = service.SelectMoldAll();
            dgvMainGrid.DataSource = moldList;
            ComboBinding();
            
            aSplitContainer1.Panel2.Enabled = false;
            ((MainForm)this.MdiParent).InsertFormEvent += new System.EventHandler(this.InsertFormShow);//입력이벤트 등록
            ((MainForm)this.MdiParent).RefreshFormEvent += new EventHandler(this.RefreshFormShow);//새로고침이벤트
        }

        private void ComboBinding()
        {
            cboDate.Items.Insert(0, "==선택==");
            cboDate.SelectedIndex = 0;
            foreach (var item in month)
            {
                cboDate.Items.Add(item);
            }
        }

        public void InsertFormShow(object sender, EventArgs e)
        {
            aSplitContainer1.Panel2.Enabled = true;
        }

        /// <summary>
        /// 데이터 그리드뷰 바인딩
        /// </summary>
        private void MainDataLoad()
        {
            InitControlUtil.SetDGVDesign(dgvMainGrid);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형코드", "Mold_Code", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형명", "Mold_Name", true, 110, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형그룹", "Mold_Group", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형상태", "Mold_Status", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형누적타수", "Cum_Shot_Cnt", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형누적생산량", "Cum_Prd_Qty", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "금형누적사용시간", "Cum_Time", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "보장타수", "Guar_Shot_Cnt", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "구입금액", "Purchase_Amt", true, 90);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "입고일자", "In_Date", true, 100);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "최종장착일시", "Last_Setup_Time", true, 110);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "사용여부", "Use_YN", true, 80);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvMainGrid, "비고", "Remark", true, 160);
        }

        private void PPS_MLD_001_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((MainForm)this.MdiParent).InsertFormEvent -= new System.EventHandler(this.InsertFormShow);//입력이벤트
            ((MainForm)this.MdiParent).RefreshFormEvent -= new EventHandler(this.RefreshFormShow);//새로고침이벤트
        }

        private void RefreshFormShow(object sender, EventArgs e)
        {
            moldList = service.SelectMoldAll();
            dgvMainGrid.DataSource = moldList;
        }

        private void Text_TextKeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                SearchList();
            }
        }

        private void SearchList()
        {
            if(txtCode.TextBoxText.Length > 0 && txtName.TextBoxText.Length <= 0)
            {
                moldList = (from data in moldList
                            where data.Mold_Code.Contains(txtCode.TextBoxText)
                            select data).ToList();
                txtCode.TextBoxText = "";
            }
            else if (txtName.TextBoxText.Length > 0 && txtCode.TextBoxText.Length <= 0)
            {
                moldList = (from data in moldList
                            where data.Mold_Name.Contains(txtCode.TextBoxText)
                            select data).ToList();
                txtName.TextBoxText = "";
            }
            else if (txtCode.TextBoxText.Length > 0 && txtName.TextBoxText.Length > 0)
            {
                moldList = (from data in moldList
                            where data.Mold_Code.Contains(txtCode.TextBoxText) && data.Mold_Name.Contains(txtName.TextBoxText)
                            select data).ToList();
                txtCode.TextBoxText = "";
                txtName.TextBoxText = "";
            }
            else
            {
                MessageBox.Show("검색조건을 입력해 주세요.","금형관리",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            dgvMainGrid.DataSource = moldList;
        }

        private void CboDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboDate.SelectedIndex == 0)
            {
                RefreshFormShow(sender, null);
            }
            else
            {
                moldList = (from date in moldList
                            where date.In_Date.ToString().Contains(cboDate.SelectedItem.ToString())
                            select date).ToList();
                dgvMainGrid.DataSource = moldList;
            }
        }
    }
}
