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
    public partial class PRM_PRF_008_1 : Axxen.BaseForm
    {
        WorkCenter_MasterService workcenterservice = new WorkCenter_MasterService();
        List<WorkCenter_MasterVO> WorkList;

        Nop_Mi_MasterService Nop_Mi_MasterService = new Nop_Mi_MasterService();
        List<NopMiMasterVO> NopList;

        Nop_HistoryService Nop_HistoryService = new Nop_HistoryService();

        public PRM_PRF_008_1()
        {
            InitializeComponent();
        }

        private void PRM_PRF_008_1_Load(object sender, EventArgs e)
        {
            lblManager.Text = UserInfo.User_Name;
            lblDay.Text = DateTime.Now.ToString();
            GetAllItem();
            ControlSetting();
            
        }

        private void GetAllItem()
        {
            try
            {
                WorkList = new List<WorkCenter_MasterVO>();
                WorkList = workcenterservice.GetCombo1();

                NopList = new List<NopMiMasterVO>();
                NopList = Nop_Mi_MasterService.GetCombo();

            }
            catch (Exception err)
            {
                Program.Log.WriteError(err.Message);
                throw;
            }
        }

        private void ControlSetting()
        {
            // combobox  품목명
            Dictionary<string, string> cbblistname = WorkList.ToDictionary(code => code.Wc_Code, name => name.Wc_Name);
            aComboBox1.DisplayMember = "Value";
            aComboBox1.ValueMember = "Key";
            aComboBox1.DataSource = new BindingSource(cbblistname, null);
            aTextBox1.Text = aComboBox1.SelectedValue.ToString();

            Dictionary<string, string> cbblist = NopList.ToDictionary(code => code.Nop_Mi_Code, name => name.Nop_Mi_Name);
            aComboBox2.DisplayMember = "Value";
            aComboBox2.ValueMember = "Key";
            aComboBox2.DataSource = new BindingSource(cbblist, null);
            aTextBox2.Text = aComboBox2.SelectedValue.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (aTextBox1.Text.Length>0 && aTextBox2.Text.Length > 0 && placeHolderTextBox1.Text.Length>0) 
            {
                NopHistoryVO nop = new NopHistoryVO();
                nop.Wc_Code = aComboBox1.SelectedValue.ToString();
                nop.Nop_Mi_Code = aComboBox2.SelectedValue.ToString();
                nop.Nop_Type = placeHolderTextBox1.Text;
                nop.Nop_Time = nudusl.Value;
                nop.Remark = txtRemark.Text;
                nop.Ins_Emp = lblManager.Text;

                string msg = Nop_HistoryService.InsertNop_History(nop);

                if (msg == "OK")
                {
                    MessageBox.Show("성공적으로 등록하였습니다.", "비동기 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"{msg}", "비동기 오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("모두 입력해주세요");
            }
        }

        private void aComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            aTextBox1.Text = aComboBox1.SelectedValue.ToString();
        }

        private void aComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            aTextBox2.Text = aComboBox2.SelectedValue.ToString();
        }

        private void txtRemark_KeyUp(object sender, KeyEventArgs e)
        {

            if (Encoding.Default.GetBytes(txtRemark.Text).Length > 100 && (int)e.KeyCode != 8)
            {
                MessageBox.Show("100자 이내로 입력해주세요", "자리수 제한", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRemark.Text = aTextBox1.Text.Remove(txtRemark.Text.Length - 1, 1);
                txtRemark.SelectionStart = txtRemark.Text.Length;

                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void nudusl_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링

            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리

            {
                e.Handled = true;
            }
        }
    }
}
