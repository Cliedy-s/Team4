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
    public partial class MDS_SDS_006_1 : Axxen.BaseForm
    {
        ItemMaster_Service itemservice = new ItemMaster_Service();
        List<Item_MasterVO> Itemlist;

        List<Process_MasterVO> processlist;
        ProcessService userservice = new ProcessService();
        public MDS_SDS_006_1()
        {
            InitializeComponent();
        }



        private void MDS_SDS_006_1_Load(object sender, EventArgs e)
        {
            GetAllItem();
            ControlSetting();
            lblManager.Text = UserInfo.User_Name;
            lblDay.Text = DateTime.Now.ToShortDateString() ;
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

                processlist = new List<Process_MasterVO>();
                processlist = userservice.GetAllProcess_Master();

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


            Dictionary<string, string> cbblist = processlist.ToDictionary(item => item.Process_code, item => item.Process_name);
            cbbProcess.DisplayMember = "Value";
            cbbProcess.ValueMember = "Key";
            cbbProcess.DataSource = new BindingSource(cbblist, null);
            lblProcess.Text = cbbProcess.SelectedValue.ToString();
        }

        private void CbbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblItem.Text = cbbItem.SelectedValue.ToString();
        }

        private void CbbProcess_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblProcess.Text = cbbItem.SelectedValue.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Inspect_Spec_MasterService service = new Inspect_Spec_MasterService();
                List<InspectSpecVO> additem = new List<InspectSpecVO>();


                InspectSpecVO inspect = new InspectSpecVO
                {
                    Item_Code = lblItem.Text,
                    Process_code = lblProcess.Text,
                    Inspect_code = txtInspect_code.Text,
                    Inspect_name = txtInspect_name.Text,
                    //Spec_Desc    =                     ,
                    USL = nudusl.Value,
                    SL = nudsl.Value,
                    LSL = nudlsl.Value,
                    Sample_size = Convert.ToInt32(nudsample.Value),
                    Inspect_Unit = txttype.Text,
                    Remark = txtRemark.Text

                };
                additem.Add(inspect);
                if (service.InsertInspectSpec(additem))
                {


                    MessageBox.Show("저장 완료", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("이미 등록된 검사항목입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {

                Program.Log.WriteError(err.Message);
            }

        }
    }
}
