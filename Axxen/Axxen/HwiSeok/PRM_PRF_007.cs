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
    public partial class PRM_PRF_007 : Axxen.FreeForm
    {
        List<GV_History_Work_ItemVO> gvhwi;
        GV_Work_ItemService gvwiservice = new GV_Work_ItemService();
        public PRM_PRF_007()
        {
            InitializeComponent();           
        }
        private void PRM_PRF_007_Load(object sender, EventArgs e)
        {
            ((MainForm)this.MdiParent).RefreshFormEvent += new System.EventHandler(this.RefreshFormShow); // 새로고침
            GV_Current_YesStatus(); // 사용중인 대차 현황
            GV_Current_NOStatus(); // 빈 현황 그리드뷰
        }

        private void RefreshFormShow(object sender, EventArgs e) //새로고침
        {
            try
            {
                if (this == ((MainForm)this.MdiParent).ActiveMdiChild)
                {
                    gvhwi = gvwiservice.GV_Current_YesStatus();
                    this.flowLayoutPanel1.Controls.Clear();
                    foreach (var item in gvhwi)
                    {
                        Label lab = new Label();
                        lab.Text = $"대차명: {item.GV_Name}\n대차상태: {item.GV_Status}\n작업지시번호: {item.Workorderno}\n품목코드: {item.Item_Code}\n품목명: {item.Item_Name }\n로딩시간: {item.Loading_time}";
                        lab.Margin = new Padding(10);
                        lab.TextAlign = ContentAlignment.MiddleCenter;
                        lab.BorderStyle = BorderStyle.FixedSingle;
                        lab.Font = new System.Drawing.Font("맑은 고딕", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                        lab.AutoSize = true;

                        this.flowLayoutPanel1.Controls.Add(lab);
                    }
                    
                    gvhwi = gvwiservice.GetGV_Current_NO_Status();
                    dataGridView1.DataSource = gvhwi;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                Program.Log.WriteError(err.Message);
            }
        }

        private void GV_Current_YesStatus() // 사용중인 대차 현황
        {
            gvhwi = gvwiservice.GV_Current_YesStatus();

            foreach (var item in gvhwi)
            {
                Label lab = new Label();
                lab.Text = $"대차명: {item.GV_Name}\n대차상태: {item.GV_Status}\n작업지시번호: {item.Workorderno}\n품목코드: {item.Item_Code}\n품목명: {item.Item_Name }\n로딩시간: {item.Loading_time}";
                lab.Margin = new Padding(10);
                lab.TextAlign = ContentAlignment.MiddleCenter;
                lab.BorderStyle = BorderStyle.FixedSingle;
                lab.Font = new System.Drawing.Font("맑은 고딕", 10.00F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
                lab.AutoSize = true;
                
                this.flowLayoutPanel1.Controls.Add(lab);
            }

        }

        private void GV_Current_NOStatus() // 빈 현황 그리드뷰
        {
            DatagridviewDesigns.SetDesign(dataGridView1);
            DatagridviewDesigns.AddNewColumnToDataGridView(dataGridView1, "대차코드", "GV_Code", true, 100, default, true);
            DatagridviewDesigns.AddNewColumnToDataGridView(dataGridView1, "대차명", "GV_Name", true, 100, default, true);

            gvhwi = gvwiservice.GetGV_Current_NO_Status();
            dataGridView1.DataSource = gvhwi;
        }


    }

    
}
