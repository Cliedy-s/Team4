using Axxen.CustomControls;
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

namespace AxxenClient.Forms
{
    public partial class POP_PRD_012 : AxxenClient.Templets.ClientBaseForm
    {
        public POP_PRD_012()
        {
            InitializeComponent();
        }

        private void POP_PRD_012_Load(object sender, EventArgs e)
        {
            InitControls();
            GetDatas();
        }
        private void InitControls()
        {
            InitControlUtil.SetPOPDGVDesign(dgvGVList);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "대차코드", "GV_Code", false, 80);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "소성대차", "GV_Name", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "적재시각", "Loading_time", true, 200);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "수량", "Loading_Qty", true, 150, DataGridViewContentAlignment.MiddleCenter);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "요입시각", "In_Time", true, 200);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "요출시각", "Out_Time", true, 200);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "소요시간", "Center_Time", true, 110);
            InitControlUtil.AddNewColumnToDataGridView(dgvGVList, "품목코드", "Item_Code", false, 110);
            dgvGVList.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            dgvGVList.Columns[5].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            dgvGVList.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

        }
        private void GetDatas()
        {
            GV_Current_StatusService service = new GV_Current_StatusService();
            // TODO - 원래대로 변경하기
            //List<GVStatusVO> list = service.GetGVCurrentStatus(gvGroup:"건조대차");
            List<GVStatusVO> list = service.GetGVCurrentStatus();
            dgvGVList.DataSource =
                (from item in list
                 where (item.GV_Status == "적재" || item.GV_Status == "언로딩")
                 select item).ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GV_Current_StatusService service = new GV_Current_StatusService();
            List<GVStatusVO> list = service.GetGVCurrentStatus(gvGroup: "건조그룹", gvName: txtGVSearch.TextBoxText);
            dgvGVList.DataSource =
                (from item in list
                 where (item.GV_Status == "적재" || item.GV_Status == "언로딩")
                 select item).ToList();
        }

        private void btnGVClear_Click(object sender, EventArgs e)
        {

            if (!GlobalUsage.WorkOrderNo.Equals("설정안됨"))
            {
                if (dgvGVList.SelectedRows.Count < 1)
                {
                    MessageBox.Show("대차를 선택해주세요");
                    return;
                }
                GV_HistoryService service = new GV_HistoryService();
                GVClearVO clearvo = new GVClearVO()
                {
                    Clear_Cause = "건조대차 비움",
                    Clear_Item = dgvGVList.SelectedRows[0].Cells[7].Value == null ? "" : dgvGVList.SelectedRows[0].Cells[7].Value.ToString(),
                    Clear_Qty = dgvGVList.SelectedRows[0].Cells[3].Value == null ? 0 : Convert.ToInt32(dgvGVList.SelectedRows[0].Cells[3].Value),
                    Clear_wc = GlobalUsage.WcCode,
                    GV_Code = dgvGVList.SelectedRows[0].Cells[0].Value.ToString(),
                    Up_Emp = GlobalUsage.UserID
                };
                if (service.UpdateClearGV(clearvo))
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 대차({clearvo.GV_Code}) 대차비우기에 성공함");
                    GetDatas();
                }
                else
                {
                    Program.Log.WriteInfo($"{GlobalUsage.UserName}이(가) 대차({clearvo.GV_Code})를 비우려고 하였으나 모종의 이유로 실패함");
                    MessageBox.Show("대차 비우기에 실패하였습니다.");
                }
            }
            else
            {
                Program.Log.WriteInfo($"{GlobalUsage.UserID}이(가) 작업시작을 하지않고 대차 비우기를 하려하였음");
                MessageBox.Show("작업을 시작해주세요");
            }
        }
    }
}
