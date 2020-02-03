using DAC;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using VO;
using static Axxen.CustomControls.ATextBox_FindNameByCode;

namespace Axxen.CustomControls
{
    public partial class SearchForm : Axxen.FreeForm
    {
        public string ResultCode { get; set; }
        public string ResultName { get; set; }
        DataType type;
        public SearchForm(DataType type)
        {
            InitializeComponent();
            this.type = type;
        }
        private void SearchForm_Load(object sender, EventArgs e)
        {
            //TODO - ( SearchForm ) 검색 결과 출력하기
            switch (type)
            {
                case DataType.Users:
                    break;
                case DataType.Authoritys:
                    break;
                case DataType.Systems:
                    break;
                case DataType.Processes:
                    InitControls("Process_code", "Process_name");
                    dgvSearchResult.DataSource = GetData<ProcessService, Process_MasterVO>("GetAllProcess_Master");
                    lblSearch.Text = "공정 목록";
                    break;
                case DataType.Items:
                    InitControls("Item_Code", "Item_Name");
                    dgvSearchResult.DataSource = GetData<ItemMaster_Service, Item_MasterVO>("GetAllItem_Master");
                    lblSearch.Text = "품목 목록";
                    break;
                case DataType.Facility:
                    break;
                case DataType.Errors:
                    InitControls("Def_Ma_Code", "Def_Ma_Name");
                    dgvSearchResult.DataSource = GetData<Def_MaService, Def_MaVO>("GetAllDef_Ma_Master");
                    lblSearch.Text = "불량현상 대분류 목록";
                    break;
                case DataType.NonOperations:
                    break;
                case DataType.UserDefinitions:
                    break;
                case DataType.PackingGrades:
                    break;                 
                case DataType.WorkCenters:
                    InitControls("Wc_Code", "Wc_Name");
                    dgvSearchResult.DataSource = GetData<WorkCenter_MasterService, WorkCenter_MasterVO>("GetAll");
                    lblSearch.Text = "작업장 목록";
                    break;
                case DataType.GVs:
                    InitControls("GV_Code", "GV_Name");
                    dgvSearchResult.DataSource = GetData<GV_MasterService, GVMasterVO>("GetGV_Code");
                    lblSearch.Text = "대차 목록";
                    break;
                case DataType.GVGroups:
                    InitControls("GV_GroupCode", "GV_Group");
                    dgvSearchResult.DataSource = GetData<GV_MasterService, GVMasterVO>("GetGV_GroupCode");
                    lblSearch.Text = "대차그룹 목록";
                    break;
                case DataType.Workers:
                    InitControls("User_ID", "User_Name");
                    dgvSearchResult.DataSource = GetData<UserInfo_Service, UserInfoVO>("UserID_UserName");
                    lblSearch.Text = "작업자";
                    break;
                case DataType.Pallet:
                    InitControls("Grade_Detail_Name", "Pallet_No");
                    dgvSearchResult.DataSource = GetData<Pallet_MasterService, PalletVO>("GetAll");
                    lblSearch.Text = "팔레트 목록";
                    break;
                case DataType.InablePallet:
                    InitControls("Grade_Detail_Name", "포장등급상세", "Pallet_No", "팔레트번호");
                    dgvSearchResult.DataSource = GetData<Pallet_MasterService, PalletTodayInVO>("GetInablePallet");
                    lblSearch.Text = "입고 대상 팔레트 목록";
                    break;
                default:
                    break;
            }
            //if (codecolumn == null || namecolumn == null)
            //{
            //    return;
            //}

        }
        private void InitControls(string codecolumn, string namecolumn)
        {
            InitControlUtil.SetDGVDesign(dgvSearchResult);
            InitControlUtil.AddNewColumnToDataGridView(dgvSearchResult, "Code", codecolumn, true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvSearchResult, "Name", namecolumn, true, 100, DataGridViewContentAlignment.MiddleLeft, true);
        }
        private void InitControls(string codecolumn, string codecolumnname, string namecolumn, string namecolumnname)
        {
            InitControlUtil.SetDGVDesign(dgvSearchResult);
            InitControlUtil.AddNewColumnToDataGridView(dgvSearchResult, codecolumnname, codecolumn, true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvSearchResult, namecolumnname, namecolumn, true, 100, DataGridViewContentAlignment.MiddleLeft, true);
        }
        /// <summary>
        /// 데이터를 가져오는 메서드
        /// </summary>
        private List<VOType> GetData<Service, VOType>(string methodname) 
        {
            Type type = typeof(Service);
            return (List<VOType>)type.GetMethod(methodname).Invoke(Activator.CreateInstance(type), null);
        }
        private void dgvSearchResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                this.ResultCode = dgvSearchResult.SelectedRows[0].Cells[0].Value==null ? "" : dgvSearchResult.SelectedRows[0].Cells[0].Value.ToString();
                this.ResultName = dgvSearchResult.SelectedRows[0].Cells[1].Value == null ? "" : dgvSearchResult.SelectedRows[0].Cells[1].Value.ToString();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
