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
    public partial class MDS_SDS_007_1 : Axxen.BaseForm
    {
        ItemMaster_Service itemservice = new ItemMaster_Service();
        List<Item_MasterVO> Itemlist;

        WorkCenter_MasterService workcenterservice = new WorkCenter_MasterService();
        List<WorkCenter_MasterVO> workcenterlist;
        public MDS_SDS_007_1()
        {
            InitializeComponent();
        }

        private void MDS_SDS_007_1_Load(object sender, EventArgs e)
        {
            GetAllItem();
            ControlSetting();
            lblManager.Text = UserInfo.User_Name;
            lblDay.Text = DateTime.Now.ToShortDateString();
        }

        /// <summary>
        /// 모든 그룹정보 GET
        /// </summary>
        private void GetAllItem()
        {
            try
            {
                Itemlist = new List<Item_MasterVO>();
                Itemlist = itemservice.GetAllItem_Master();

                workcenterlist = new List<WorkCenter_MasterVO>();
                workcenterlist = workcenterservice.GetAll();

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
            List<Item_MasterVO> dictionname = Itemlist.GroupBy(name => name.Item_Code).Select(grp => grp.First()).ToList();

            Dictionary<string, string> cbblistname = dictionname.ToDictionary(code => code.Item_Code, name => name.Item_Name);
            cbbItem.DisplayMember = "Value";
            cbbItem.ValueMember = "Key";
            cbbItem.DataSource = new BindingSource(cbblistname, null);
            lblItem.Text = cbbItem.SelectedValue.ToString();


            Dictionary<string, string> cbblistwork = workcenterlist.ToDictionary(code => code.Wc_Code, name => name.Wc_Name);
            cbbwork.DisplayMember = "Value";
            cbbwork.ValueMember = "Key";
            cbbwork.DataSource = new BindingSource(cbblistwork, null);
            lblwork.Text = cbbwork.SelectedValue.ToString();
        }

        private void CbbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblItem.Text = cbbItem.SelectedValue.ToString();
        }

        private void Cbbwork_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblwork.Text = cbbwork.SelectedValue.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            List<ConditionSpecVO> addlist = new List<ConditionSpecVO>();
            try
            {
                if(!string.IsNullOrEmpty(txtCondition_Code.Text) && !string.IsNullOrEmpty(txtCondition_Name.Text))
                {


                Condition_Spec_MasterService service = new Condition_Spec_MasterService();
                ConditionSpecVO inspect = new ConditionSpecVO
                {
                    Item_Code = lblItem.Text,
                    Wc_Code = lblwork.Text,
                    Condition_Code = txtCondition_Code.Text,
                    Condition_Name = txtCondition_Name.Text,
                    //Spec_Desc    =                     ,
                    USL = nudusl.Value,
                    SL = nudsl.Value,
                    LSL = nudlsl.Value,
                    Condition_Unit = txttype.Text,
                    Remark = txtRemark.Text,
                 
                };
                addlist.Add(inspect);
                if (service.InsertConditionSpec(addlist))
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
                    MessageBox.Show("필수 항목을 입력해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {

                Program.Log.WriteError(err.Message);
                MessageBox.Show(err.ToString(), "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
