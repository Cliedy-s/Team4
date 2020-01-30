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
    public partial class MDS_SDS_002_1 : Axxen.BaseForm
    {
        ItemMaster_Service itemservice = new ItemMaster_Service();
        List<Item_Level_Master> itemgrouplist;
        public MDS_SDS_002_1()
        {
            InitializeComponent();
        }

        private void MDS_SDS_002_1_Load(object sender, EventArgs e)
        {
            lblManager.Text = UserInfo.User_Name;
            lblDay.Text = DateTime.Now.ToShortDateString();
            GetAllItemGroup();
            ControlSetting();
        }

        /// <summary>
        /// 그리드뷰 버튼, 콤보박스세팅
        /// </summary>
        private void ControlSetting()
        {
            ///combobox
    
            Item_Level_Master first = new Item_Level_Master();
            var level1list = itemgrouplist.FindAll(level => level.Item_lvl1 == "Y");
            level1list.Insert(0, first);
            cbbLevel_1.DisplayMember = "Level_Name";
            cbbLevel_1.ValueMember = "Level_Code";
            cbbLevel_1.DataSource = level1list;

            var level2list = itemgrouplist.FindAll(level => level.Item_lvl2 == "Y");
            level2list.Insert(0, first);
            cbbLevel_2.DisplayMember = "Level_Name";
            cbbLevel_2.ValueMember = "Level_Code";
            cbbLevel_2.DataSource = new BindingSource(level2list, null);

            var level3list = itemgrouplist.FindAll(level => level.Item_lvl3 == "Y");
            level3list.Insert(0, first);
            cbbLevel_3.DisplayMember = "Level_Name";
            cbbLevel_3.ValueMember = "Level_Code";
            cbbLevel_3.DataSource = new BindingSource(level3list, null);

            var level4list = itemgrouplist.FindAll(level => level.Item_lvl4 == "Y");
            level4list.Insert(0, first);
            cbbLevel_4.DisplayMember = "Level_Name";
            cbbLevel_4.ValueMember = "Level_Code";
            cbbLevel_4.DataSource = new BindingSource(level4list, null);

            var level5list = itemgrouplist.FindAll(level => level.Item_lvl5 == "Y");
            level5list.Insert(0, first);
            cbbLevel_5.DisplayMember = "Level_Name";
            cbbLevel_5.ValueMember = "Level_Code";
            cbbLevel_5.DataSource = new BindingSource(level5list, null);

            ///
        }
        /// <summary>
        /// 모든 그룹정보 GET
        /// </summary>
        private void GetAllItemGroup()
        {

            itemgrouplist = new List<Item_Level_Master>();
            itemgrouplist = itemservice.GetAllItem_Level_Master();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCode.Text) && !string.IsNullOrEmpty(txtName.Text) && !string.IsNullOrEmpty(txtType.Text))
                {

                    Item_MasterVO item = new Item_MasterVO()
                    {

                        Item_Code = txtCode.Text,
                        Item_Name = txtName.Text,
                        Item_Name_Eng = txteng.Text,
                        Item_Name_Eng_Alias = txtengAs.Text,
                        Item_Type = txtType.Text,
                        Item_Spec = txtSpec.Text,
                        Item_Unit = nudunit.Text,
                        Item_Stock = nudStock.Value,
                        PrdQty_Per_Hour = nudhour.Value,
                        PrdQTy_Per_Batch = nudbatch.Value,
                        Cavity = int.Parse(nudcavity.Value.ToString()),
                        Line_Per_Qty = int.Parse(nudlinper.Value.ToString()),
                        Shot_Per_Qty = int.Parse(nudshotper.Value.ToString()),
                        Dry_GV_Qty = int.Parse(nuddrgdv.Value.ToString()),
                        Heat_GV_Qty = int.Parse(nudheatgv.Value.ToString()),
                        Level_1 = cbbLevel_1.ValueMember,
                        Level_2 = cbbLevel_2.ValueMember,
                        Level_3 = cbbLevel_3.ValueMember,
                        Level_4 = cbbLevel_4.ValueMember,
                        Level_5 = cbbLevel_5.ValueMember,
                        Ins_Date = Convert.ToDateTime(lblDay.Text),
                        Ins_Emp = lblManager.Text,
                    };
                    if (itemservice.InsertUpdateAllItem_Master(item))
                    {
                        MessageBox.Show("저장 완료", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("저장 실패", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("필수 항목을 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception err)
            {

                MessageBox.Show("db 오류 저장 실패", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.Log.WriteError(err.Message);
            }
        }
    }
}
