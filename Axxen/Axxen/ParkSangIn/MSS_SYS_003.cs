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
    public partial class MSS_SYS_003 : Axxen.BaseForm
    {
        List<ScreenItem_MasterVO> screanlist;
        ScreenItemService screenservice = new ScreenItemService();



        public MSS_SYS_003()
        {
            InitializeComponent();
        }

        private void MSS_SYS_003_Load(object sender, EventArgs e)
        {

            ///gridview
            DatagridviewDesigns.SetDesign(dgvScreen);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvScreen, "화면코드", "Screen_Code", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvScreen, "화면명", "Type", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvScreen, "화면경로", "Screen_Path", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvScreen, "입력일자", "Ins_Date", true, 210, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dgvScreen, "사용여부", "Use_YN", true, 210, default, true);

            DataGridViewButtonColumn gridbtn = new DataGridViewButtonColumn();
            gridbtn.HeaderText = "사용여부";
            gridbtn.Text = "변경";
            gridbtn.Name = "btn";
            gridbtn.Width = 100;
            gridbtn.FlatStyle = FlatStyle.Popup;
            gridbtn.DefaultCellStyle.BackColor = Color.LightYellow;
            gridbtn.UseColumnTextForButtonValue = true;
            dgvScreen.Columns.Add(gridbtn);
            GetAllDefMa();
            ///
            ControlSetting();
        }
        /// <summary>
        /// 그리드뷰 버튼, 콤보박스세팅
        /// </summary>
        private void ControlSetting()
        {
            ///combobox
            Dictionary<string, string> cbblist = screanlist.ToDictionary(item => item.Screen_Code, item => item.Type);
            cbbGroup.DisplayMember = "Value";
            cbbGroup.ValueMember = "Key";
            cbbGroup.DataSource = new BindingSource(cbblist, null);
            lblGroup.Text = cbbGroup.SelectedValue.ToString();
            ///
        }
        /// <summary>
        /// 모든 그룹정보 GET
        /// </summary>
        private void GetAllDefMa()
        {
            screanlist = new List<ScreenItem_MasterVO>();
            screanlist = screenservice.GetALLScreenItem();
            dgvScreen.DataSource = screanlist;
        }

        private void DgvScreen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == dgvScreen.Columns["btn"].Index)//눌러서 사용과 사용안함 변경
                {
                    if ((dgvScreen.SelectedRows[0].Cells[4].Value).ToString() == "Y") //사용안함
                    {
                        screenservice.UsedScreenItem_MasterVO((dgvScreen.SelectedRows[0].Cells[0].Value).ToString(), "N");
                    }
                    else //사용함
                    {
                        screenservice.UsedScreenItem_MasterVO((dgvScreen.SelectedRows[0].Cells[0].Value).ToString(), "Y");
                    }
                    GetAllDefMa();
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }
    }
}
