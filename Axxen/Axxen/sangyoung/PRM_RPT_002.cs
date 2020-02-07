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
using System.Threading;
using System.Windows.Forms;
using VO;

namespace Axxen
{
    public partial class PRM_RPT_002 : Axxen.ReportForm
    {
        List<Goods_In_HistoryVO> figList;
        List<InspectMeasureHistoryVO> imhList;
        DataTable dt = new DataTable();
        FigurationRequest rpt = new FigurationRequest();
        public PRM_RPT_002()
        {
            InitializeComponent();
        }

        private void PRM_RPT_002_Load(object sender, EventArgs e)
        {
            Goods_In_HistorySercive service = new Goods_In_HistorySercive();
            figList = service.GetFigurationHistory();
        }

        private void ADateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            documentViewer1.DocumentSource = null;
            threadmethod += ReportBinding;
            using (WaitForm waitfrm = new WaitForm(() => { Thread.Sleep(2000); dtpDate.Invoke(threadmethod); }))
            {
                waitfrm.ShowDialog(this);
            }
        }
        public delegate void threadDelegate();
        threadDelegate threadmethod;
        private void ReportBinding()
        {
            DataSet ds = new DataSet();
            List<string> workno = new List<string>();
            string date = dtpDate.Value.ToString("yyyyMMdd");

            var searchlist = (from data in figList
                              where data.In_Date.ToString("yyyyMMdd") == date
                              select data).ToList();

            foreach (var item in searchlist)
            {
                workno.Add(item.Workorderno);
            }
            Inspect_Measure_HistoryService inservice = new Inspect_Measure_HistoryService();
            imhList = inservice.GetFiguration(workno);

            var figurationList = (from req in figList
                                  join val in imhList on req.Workorderno equals val.Workorderno
                                  where req.Workorderno == val.Workorderno
                                  select new { Num = req.Num, Pallet_No = req.Pallet_No, Item_Name = req.Item_Name, Closed_Time = req.Closed_Time
                                              ,Workorderno = val.Workorderno, ADate = val.Adate, AVal = val.AVal, BDate = val.Bdate, BVal = val.BVal
                                              ,CDate = val.Cdate, CVal = val.CVal, DDate = val.Ddate, DVal = val.DVal, EDate = val.Edate, EVal = val.EVal
                                  }).ToList();


            dt = ListToDataTable.ToDataTable(figurationList);
            rpt.DataSource = dt;
            rpt.Parameters["Ins_Date"].Value = dtpDate.Value.ToString("yyyy-MM-dd");
            rpt.Parameters["Ins_Date"].Visible = false; //파라미터 바로 넘기기
            documentViewer1.DocumentSource = rpt;
            rpt.CreateDocument();
        }
    }
}
