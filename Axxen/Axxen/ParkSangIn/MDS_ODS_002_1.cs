﻿using Service;
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
    public partial class MDS_ODS_002_1 : Axxen.BaseForm
    {
        List<Process_MasterVO> processlist;
        ProcessService processservice = new ProcessService();
        WorkCenter_MasterService Workservice = new WorkCenter_MasterService();
        public MDS_ODS_002_1()
        {
            InitializeComponent();
        }

        private void MDS_ODS_002_1_Load(object sender, EventArgs e)
        {
            GetAllItem();
            ControlSetting();
            lblManager.Text = UserInfo.User_Name;
            lblDay.Text = DateTime.Now.ToShortDateString();

            //if (updateinspectitem != null)//수정이라면
            //{
            //    cbb.Text = Itemlist.Find(itemname => itemname.Item_Code == updateinspectitem.Item_Code).Item_Name;
            //    lblItem.Text = updateinspectitem.Item_Code;
            //    cbbProcess.Text = processlist.Find(proname => proname.Process_code == updateinspectitem.Process_code).Process_name;
            //    lblProcess.Text = updateinspectitem.Process_code;
            //    txtInspect_code.Text = updateinspectitem.Inspect_code;
            //    txtInspect_name.Text = updateinspectitem.Inspect_name;

            //    nudusl.Value = updateinspectitem.USL;
            //    nudsl.Value = updateinspectitem.SL;
            //    nudlsl.Value = updateinspectitem.LSL;
            //    nudsample.Value = updateinspectitem.Sample_size;
            //    txttype.Text = updateinspectitem.Inspect_Unit;
            //    txtRemark.Text = updateinspectitem.Remark;


            //    cbbItem.Enabled = false;
            //    cbbProcess.Enabled = false;
            //}
        }

        /// <summary>
        /// 모든 그룹정보 GET
        /// </summary>
        private void GetAllItem()
        {
            try
            {

                processlist = new List<Process_MasterVO>();
                processlist = processservice.GetAllProcess_Master();

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
            Dictionary<string, string> cbblist = processlist.ToDictionary(item => item.Process_code, item => item.Process_name);
            cbbProcess.DisplayMember = "Value";
            cbbProcess.ValueMember = "Key";
            cbbProcess.DataSource = new BindingSource(cbblist, null);
            lblprocess.Text = cbbProcess.SelectedValue.ToString();
        }

        private void CbbProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblprocess.Text = cbbProcess.SelectedValue.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {


            try
            {

                if (!string.IsNullOrEmpty(txtwork_code.Text) && !string.IsNullOrEmpty(txtwork_name.Text) && !string.IsNullOrEmpty(lblprocess.Text))
                {

                    WorkCenter_Master2VO additem = new WorkCenter_Master2VO()
                    {
                        Wc_Code = txtwork_code.Text,
                        Wc_Name = txtwork_name.Text,
                        Process_Code = lblprocess.Text,
                        Remark = txtRemark.Text,
                        Ins_Emp = UserInfo.User_Name

                    };

                    if (Workservice.InsertWorkservice(additem))
                    {


                        MessageBox.Show("저장 완료", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                    else
                    {
                        MessageBox.Show("이미 등록된 검사항목입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("필수 항목을 입력하세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString(), "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.Log.WriteError(err.Message);
            }


         }
    }
}