using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AxxenClient.Forms
{
    public partial class WorkOrderForm : AxxenClient.Templets.ClientBaseForm
    {
        WorkType worktype;
        public WorkOrderForm(WorkType worktype)
        {
            InitializeComponent();
            this.worktype = worktype;
        }
        private void InitControl()
        {
            // 화면 set
            SetButtonForms();
            panBoxing.Location = panMolding.Location = panLoad.Location; //panLoad.Location => molding, Boxing
            // 공정별 화면
            switch (worktype)
            {
                case WorkType.Molding:
                    panMolding.Visible = true;
                    panBoxing.Visible = panLoad.Visible = false;
                    break;
                case WorkType.Load:
                    panLoad.Visible = true;
                    panBoxing.Visible = panMolding.Visible = false;
                    break;
                case WorkType.Boxing:
                    panBoxing.Visible = true;
                    panMolding.Visible = panLoad.Visible = false;
                    break;
                default:
                    break;
            }
        }
        private void WorkOrderForm_Load(object sender, EventArgs e)
        {
            InitControl();
        }
        private void SetButtonForms()
        {
            btnWorkOrderCreate1.Tag = typeof(POP_PRD_002);
            btnCreatePallet.Tag = typeof(POP_PRD_003);
            btnBarcordeRecreate.Tag = typeof(POP_PRD_004);
            btnWarehousing.Tag = typeof(POP_PRD_005);
            btnUnload.Tag = typeof(POP_PRD_006);
            btnDryGVLoad.Tag = typeof(POP_PRD_007);
            btnSetMold.Tag = typeof(POP_PRD_008);
            btnWorkOrderCreate2.Tag = typeof(POP_PRD_009);
            btnLoadRecordRegister.Tag = typeof(POP_PRD_010);
            btnFiringInOut.Tag = typeof(POP_PRD_011);
            btnClearDryGV.Tag = typeof(POP_PRD_012);
            btnSetWorker1.Tag = btnSetWorker2.Tag = btnSetWorker3.Tag = typeof(POP_PRD_013);
            btnSetPressCondition1.Tag =  btnSetPressCondition2.Tag = typeof(POP_PRD_014);
            btnQualityMeasure1.Tag = btnQualityMeasure2.Tag = btnQualityMeasure3.Tag = typeof(POP_PRD_015);
            btnNoActive.Tag = typeof(POP_PRD_016);
        }

        private void btnClick(object sender, EventArgs e)
        {
            if(sender is Button btn)
            {
                Form frm = Activator.CreateInstance((Type)btn.Tag) as Form;
                frm.WindowState = FormWindowState.Maximized;
                frm.MdiParent = this.MdiParent;
                frm.Show();
                frm.Activate();
            }
        }
    }
    public enum WorkType { Molding, Load, Boxing}
}
