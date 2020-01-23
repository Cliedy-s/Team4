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
    public partial class POP_PRD_002 : AxxenClient.Templets.ClientBaseForm
    {
        public POP_PRD_002()
        {
            InitializeComponent();
        }
        private void POP_PRD_002_Load(object sender, EventArgs e)
        {
            GetDatas();
        }
        /// <summary>
        /// 데이터 설정
        /// </summary>
        private void GetDatas()
        {
            Wo_ReqService service = new Wo_ReqService();
            dgvWorkOrder.DataSource = service.GetAllWoReq();
        }
        private void btnCreateWorkOrder_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            WorkOrder_Service service = new WorkOrder_Service();
            if (service.InsertWorkOrder(
                new VO.WorkOrderNewVO()
                {
                    Ins_Emp = GlobalUsage.username,
                    //Item_Code = txtItemCode.TextBoxText,
                    Mat_LotNo = now.ToString("yyyyMMddhhmmss"),
                    Plan_Qty = Convert.ToInt32(txtPlanQty.TextBoxText),
                    Plan_Unit = "개",
                    //Req_Seq = 
                }))
            {

            }
        }

        private void dgvWorkOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgvWorkOrder.SelectedRows[0].Cells["Req_Seq"]
        }
    }
}
