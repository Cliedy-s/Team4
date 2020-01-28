﻿using Service;
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
        /// <summary>
        /// POP작업 종류에 따른 다른 화면 설정
        /// </summary>
        /// <param name="worktype"></param>
        public WorkOrderForm(WorkType worktype)
        {
            InitializeComponent();
            GlobalUsage.worktype = worktype;
            GlobalUsage.woinichar = worktype.ToString();
        }
        /// <summary>
        /// 컨트롤들 기본설정
        /// </summary>
        private void InitControl()
        {
            // 화면 set
            SetButtonForms();
            btnClose.Visible = false;

            // 공정별 화면
            switch (GlobalUsage.worktype)
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
            panBoxing.Location  = panLoad.Location = panMolding.Location; //panLoad.Location => molding, Boxing

            //데이터 읽어오기
            GetDatas();
        }
        /// <summary>
        /// 데이터를 DB에서 가져온다
        /// </summary>
        private void GetDatas()
        {
            WorkOrder_Service service = new WorkOrder_Service();
            string woinichar = string.Empty;
            dgvMain.DataSource = service.GetAllWorkOrder_AlloHisDetail_Item_Wc(woinichar);
        }
        /// <summary>
        /// 버튼에 폼을 연결한다.
        /// </summary>
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
            btnSetPressCondition1.Tag = btnSetPressCondition2.Tag = typeof(POP_PRD_014);
            btnQualityMeasure1.Tag = btnQualityMeasure2.Tag = btnQualityMeasure3.Tag = typeof(POP_PRD_015);
            btnNoActive.Tag = typeof(POP_PRD_016);
        }
        private void WorkOrderForm_Load(object sender, EventArgs e)
        {
            InitControl();
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
}
