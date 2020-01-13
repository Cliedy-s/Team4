using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VO;
using Service;
using System.Linq;

namespace Axxen
{
    public partial class MSS_CON_002_1 : Axxen.BaseForm
    {
        UserGroupService userservice = new UserGroupService();
        List<UserGroup_MasterVO> grouplist;
 
        ScreenItemService screenservice = new ScreenItemService();
        List<ScreenItem_AuthorityVO> NotScreenlist ;//초기 안쓰는거
        List<ScreenItem_AuthorityVO> UseScreenlist; //초기 쓰는거
        List<ScreenItem_AuthorityVO> InsertUpdateScreenlist; //db에 들어갈애들

        public MSS_CON_002_1()
        {
            InitializeComponent();
        }

        private void MSS_CON_002_1_Load(object sender, EventArgs e)
        {
            InsertUpdateScreenlist = new List<ScreenItem_AuthorityVO>();
            DatagridviewDesigns.SetDesign(dgvNotUseScreen);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvNotUseScreen, "화면코드", "Screen_Code", true, 200, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvNotUseScreen, "화면명", "Type", true, 200, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvNotUseScreen, "화면경로", "Screen_Path", true, 200, default, true);
          

            DatagridviewDesigns.SetDesign(dgvUseScreen);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvUseScreen, "화면코드", "Screen_Code", true, 200, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvUseScreen, "화면명", "Type", true, 200, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvNotUseScreen, "화면경로", "Screen_Path", true, 200, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvUseScreen, "설정자", "Ins_Emp", true, 200, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvUseScreen, "입력일", "Ins_Date", true, 200, default, true);
            ControlSetting();
        }

        /// <summary>
        /// 그리드뷰 버튼, 콤보박스세팅
        /// </summary>
        private void ControlSetting()
        {
            ///grideview checkbox
            DataGridViewCheckBoxColumn gridcheckbox = new DataGridViewCheckBoxColumn();
            gridcheckbox.HeaderText = "선택";
            gridcheckbox.Name = "checkbtn";
            dgvNotUseScreen.Columns.Insert(0, gridcheckbox);

            DataGridViewCheckBoxColumn gridcheckbox2 = new DataGridViewCheckBoxColumn();
            gridcheckbox2.HeaderText = "선택";
            gridcheckbox2.Name = "checkbtn2";

            dgvUseScreen.Columns.Insert(0, gridcheckbox2);

            DataGridViewCheckBoxColumn gridC = new DataGridViewCheckBoxColumn();
            gridC.HeaderText = "추가";
            gridC.Name = "gridC";
            dgvUseScreen.Columns.Insert(4, gridC);

            DataGridViewCheckBoxColumn gridR = new DataGridViewCheckBoxColumn();
            gridR.HeaderText = "조회";
            gridR.Name = "gridR";

            dgvUseScreen.Columns.Insert(5, gridR);

            DataGridViewCheckBoxColumn gridU = new DataGridViewCheckBoxColumn();
            gridU.HeaderText = "수정";
            gridU.Name = "gridU";
            dgvUseScreen.Columns.Insert(6, gridU);

            DataGridViewCheckBoxColumn gridD = new DataGridViewCheckBoxColumn();
            gridD.HeaderText = "삭제";
            gridD.Name = "gridD";
            dgvUseScreen.Columns.Insert(7, gridD);
            ///combobox
            grouplist = new List<UserGroup_MasterVO>();
            grouplist = userservice.GetAllUserGroup();
            Dictionary<string, string> cbblist = grouplist.FindAll(item => item.Use_YN == "Y").ToDictionary(item => item.UserGroup_Code, item => item.UserGroup_Name); //사용을 하는 그룹만
            cbbGroup.DisplayMember = "Value";
            cbbGroup.ValueMember = "Key";
            cbbGroup.DataSource = new BindingSource(cbblist, null);
            lblGroup.Text = cbbGroup.SelectedValue.ToString();
            ///
        }
        private void CbbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblGroup.Text = cbbGroup.SelectedValue.ToString();
        
        }

        /// <summary>
        /// 그룹버튼 조회시 dgvScreenItem에 적용되지않은화면과 적용된화면 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btngroub_Click(object sender, EventArgs e)
        {
            //그룹에서 사용하지않는 화면
            
            NotScreenlist = new List<ScreenItem_AuthorityVO>();
            NotScreenlist = screenservice.GetNotUseGroupScreenItem(lblGroup.Text);
            dgvNotUseScreen.DataSource = NotScreenlist;

            //그룹에서 사용하는화면
            UseScreenlist = new List<ScreenItem_AuthorityVO>();

            UseScreenlist = screenservice.GetUseGroupScreenItem(lblGroup.Text);
            if (UseScreenlist.Count > 0)
            { 
            dgvUseScreen.DataSource = UseScreenlist;
            }
            else
            {
                dgvUseScreen.DataSource = null;
            }
        }


        private void BtnInsert_Click(object sender, EventArgs e)
        {
         //   UseScreenlist = new List<ScreenItem_MasterVO>();
            List<ScreenItem_AuthorityVO> subDeletelist = new List<ScreenItem_AuthorityVO>();
            foreach (DataGridViewRow row in dgvNotUseScreen.Rows)
            {

                if (Convert.ToBoolean(row.Cells[0].Value) == true) //체크박스가 선택된 row들만
                {
                    ScreenItem_AuthorityVO item = new ScreenItem_AuthorityVO
                    {
                        Screen_Code = row.Cells[1].Value.ToString(),
                        Type = row.Cells[2].Value.ToString(),
                        Screen_Path = row.Cells[3].Value.ToString(),
                        Ins_Date = DateTime.Now,
                        Ins_Emp = UserInfo.User_Name,
                    };
            
                    if (UseScreenlist.Count(a => a.Screen_Code == item.Screen_Code) < 1) //사용하는 리스트에 중복으로 들어가는 지 체크 없다면 add  
                    {
                        UseScreenlist.Add(item); //사용그리드뷰에 담을 리스트
                        subDeletelist.Add(item); // 비사용그리드뷰리시트와 비교할 서브 리스트
                   
                        // NotScreenlist.Remove(removeitem=> removeitem.Screen_Code== item.Screen_Code);

                    }
                }

            }
            for(int i=0; i< NotScreenlist.Count; i++)
            {
                for(int j=0; j< subDeletelist.Count; j++)
                {
                    if (NotScreenlist[i].Screen_Code == subDeletelist[j].Screen_Code)
                    {
                        NotScreenlist.RemoveAt(i);
                  
                    }
                }
            }

            dgvNotUseScreen.DataSource = null;
            dgvNotUseScreen.DataSource = NotScreenlist;

            if (dgvUseScreen.RowCount > 0) {
                  dgvUseScreen.DataSource = null;
            }
            dgvUseScreen.DataSource = UseScreenlist;

        }

        private void DgvUseScreen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dgvUseScreen.SelectedCells[2].ToString());
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {

            StringBuilder crud = new StringBuilder();
            foreach (DataGridViewRow row in dgvUseScreen.Rows)
            {
                crud.Clear();
                
                if (Convert.ToBoolean(row.Cells[4].Value) == true)
                {
                    crud.Append("Y");
                }
                else
                {
                    crud.Append("N");
                }
                if (Convert.ToBoolean(row.Cells[5].Value) == true)
                {
                    crud.Append("Y");
                }
                else
                {
                    crud.Append("N");
                }
                if (Convert.ToBoolean(row.Cells[6].Value) == true)
                {
                    crud.Append("Y");
                }
                else
                {
                    crud.Append("N");
                }
                if (Convert.ToBoolean(row.Cells[7].Value) == true)
                {
                    crud.Append("Y");
                }
                else
                {
                    crud.Append("N");
                }

                ScreenItem_AuthorityVO item = new ScreenItem_AuthorityVO
                {
                    UserGroup_Code = lblGroup.Text,
                    Screen_Code = row.Cells[1].Value.ToString(),
                    Pre_Type = crud.ToString(),
                    Ins_Date = DateTime.Now,
                    Ins_Emp = UserInfo.User_Name

                };
                InsertUpdateScreenlist.Add(item);
            }

            screenservice.InsertUpdateScreenItem_Authority(InsertUpdateScreenlist);
            }
            catch (Exception err)
            {

                MessageBox.Show(err.ToString());
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
