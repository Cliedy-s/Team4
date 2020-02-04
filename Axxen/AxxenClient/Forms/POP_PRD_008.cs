using Axxen.CustomControls;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AxxenClient.Forms
{
    public partial class POP_PRD_008 : AxxenClient.Templets.ClientBaseForm
    {
        public POP_PRD_008()
        {
            InitializeComponent();
        }

        private void POP_PRD_008_Load(object sender, EventArgs e)
        {
            InitControls();
            GetDatas();
        }
        private void InitControls()
        {
            InitControlUtil.SetPOPDGVDesign(dgvEquipMoldList);
            InitControlUtil.AddNewColumnToDataGridView(dgvEquipMoldList, "금형코드", "Mold_Code", true, 110);
            InitControlUtil.AddNewColumnToDataGridView(dgvEquipMoldList, "금형명", "Mold_Name", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvEquipMoldList, "그룹", "Mold_Group", true, 100);

            InitControlUtil.SetPOPDGVDesign(dgvEquipedMoldList);
            InitControlUtil.AddNewColumnToDataGridView(dgvEquipedMoldList, "금형코드", "Mold_Code", true, 110);
            InitControlUtil.AddNewColumnToDataGridView(dgvEquipedMoldList, "금형명", "Mold_Name", true, 100, DataGridViewContentAlignment.MiddleLeft, true);
            InitControlUtil.AddNewColumnToDataGridView(dgvEquipedMoldList, "그룹", "Mold_Group", true, 100);

        }
        private void GetDatas()
        {
            MoldService service = new MoldService();
            dgvEquipMoldList.DataSource = service.GetMoldList(moldstatus:"양호", wccode:null);
            dgvEquipedMoldList.DataSource = service.GetMoldList(wccode:GlobalUsage.WcCode);
        }

        private void btnEquip_Click(object sender, EventArgs e)
        {
            // 장착
            MoldService service = new MoldService();
            service.UpdateEquipMold(GlobalUsage.WcCode, dgvEquipMoldList.SelectedRows[0].Cells[0].Value.ToString());
            GetDatas();
        }

        private void btnUnEquip_Click(object sender, EventArgs e)
        {
            // 탈착
            MoldService service = new MoldService();
            service.UpdateEquipMold(dgvEquipedMoldList.SelectedRows[0].Cells[0].Value.ToString());
            GetDatas();
        }
    }
}
