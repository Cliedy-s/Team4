using Axxen.sangyoung;
using Axxen.Util;
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
    public partial class PRM_RPT_001 : Axxen.ReportForm
    {
        public delegate void threadDelegate();
        threadDelegate threadmethod;

        List<Goods_In_HistoryVO> dryList;
        List<InspectMeasureHistoryVO> imhList;

        DataTable dt = new DataTable();
        DryingLog rpt = new DryingLog();
        Goods_In_HistorySercive service = new Goods_In_HistorySercive();

        public PRM_RPT_001()
        {
            InitializeComponent();
        }

        private void ADateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            documentViewer1.DocumentSource = null;
            
        }

        private void ReportBinding()
        {
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            dryList = service.GetDryingHistory(date);

            List<string> workno = new List<string>();

            foreach (var item in dryList)
            {
                workno.Add(item.Workorderno);
            }

            Inspect_Measure_HistoryService inservice = new Inspect_Measure_HistoryService();
            imhList = inservice.GetDrying(workno);

            var figurationList = (from req in dryList
                                  join val in imhList on req.Workorderno equals val.Workorderno
                                  where req.Workorderno == val.Workorderno
                                  select new
                                  {
                                      Num = req.Num,
                                      Pallet_No = req.Pallet_No,
                                      Item_Name = req.Item_Name,
                                      Closed_Time = req.Closed_Time.ToString("HH:mm"),
                                      Workorderno = val.Workorderno,
                                      ADate = val.Adate,
                                      AVal = val.Aval,
                                      BDate = val.Bdate,
                                      BVal = val.Bval,
                                      CDate = val.Cdate,
                                      CVal = val.Cval
                                  }).ToList();


            dt = ListToDataTable.ToDataTable(figurationList);
            dt.TableName = "datDrying";
            dsFiguration ds = new dsFiguration();
            ds.Tables.Add(dt);
            rpt.DataSource = ds.Tables["datDrying"];
            rpt.Parameters["Ins_Date"].Value = dtpDate.Value.ToString("yyyy-MM-dd");
            rpt.Parameters["Ins_Date"].Visible = false; //파라미터 바로 넘기기
            documentViewer1.DocumentSource = rpt;
            rpt.CreateDocument();
        }

        private void AButton1_Click(object sender, EventArgs e)
        {
            threadmethod += ReportBinding;
            using (WaitForm waitfrm = new WaitForm(() => { /*Thread.Sleep(2000);*/ dtpDate.Invoke(threadmethod); }))
            {
                waitfrm.ShowDialog(this);
            }
        }
    }
}
