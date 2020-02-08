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
        ProcessService processservice = new ProcessService();
        public MDS_SDS_006_1()
        {
            InitializeComponent();
        }

        public InspectSpecVO updateinspectitem { get; set; }



        private void MDS_SDS_006_1_Load(object sender, EventArgs e)
        {
            GetAllItem();
            ControlSetting();
            lblManager.Text = UserInfo.User_Name;
            lblDay.Text = DateTime.Now.ToShortDateString();

            if (updateinspectitem != null)//수정이라면
            {
                cbbItem.Text = Itemlist.Find(itemname => itemname.Item_Code == updateinspectitem.Item_Code).Item_Name;
                lblItem.Text = updateinspectitem.Item_Code;
                cbbProcess.Text = processlist.Find(proname => proname.Process_code == updateinspectitem.Process_code).Process_name;
                lblProcess.Text = updateinspectitem.Process_code;
                txtInspect_code.Text = updateinspectitem.Inspect_code;
                txtInspect_name.Text = updateinspectitem.Inspect_name;

                nudusl.Value = updateinspectitem.USL;
                nudsl.Value = updateinspectitem.SL;
                nudlsl.Value = updateinspectitem.LSL;
                nudsample.Value = updateinspectitem.Sample_size;
                txttype.Text = updateinspectitem.Inspect_Unit;
                txtRemark.Text = updateinspectitem.Remark;


                cbbItem.Enabled = false;
                cbbProcess.Enabled = false;
            }
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
            List<Item_MasterVO> dictionname = Itemlist.GroupBy(name => name.Item_Code).Select(grp => grp.First()).ToList();

            Dictionary<string, string> cbblistname =  dictionname.FindAll(ite=>ite.Use_YN.Equals("Y")).ToDictionary(code => code.Item_Code, name => name.Item_Name);
            cbbItem.DisplayMember = "Value";
            cbbItem.ValueMember = "Key";
            cbbItem.DataSource = new BindingSource(cbblistname, null);
            lblItem.Text = cbbItem.SelectedValue.ToString();


            Dictionary<string, string> cbblist = processlist.FindAll(ite => ite.Use_YN.Equals("Y")).ToDictionary(item => item.Process_code, item => item.Process_name);
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
            lblProcess.Text = cbbProcess.SelectedValue.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(txtInspect_code.Text) && !string.IsNullOrEmpty(txtInspect_name.Text))
                {


                    Inspect_Spec_MasterService service = new Inspect_Spec_MasterService();
                    List<InspectSpecVO> additem = new List<InspectSpecVO>();


                    InspectSpecVO inspect = new InspectSpecVO
                    {
                        Item_Code = lblItem.Text.Trim(),
                        Process_code = lblProcess.Text.Trim(),
                        Inspect_code = txtInspect_code.Text.Trim(),
                        Inspect_name = txtInspect_name.Text.Trim(),
                        //Spec_Desc    =                     ,
                        USL = nudusl.Value,
                        SL = nudsl.Value,
                        LSL = nudlsl.Value,
                        Sample_size = Convert.ToInt32(nudsample.Value),
                        Inspect_Unit = txttype.Text.Trim(),
                        Remark = txtRemark.Text.Trim()

                    };
                    additem.Add(inspect);
                    if (service.InsertInspectSpec(additem))
                    {
                      
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("이미 등록된 검사항목입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
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

                Program.Log.WriteError(err.Message);
            }

        }
    }
}
