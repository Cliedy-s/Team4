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
        FigurationLog rpt = new FigurationLog();
        Goods_In_HistorySercive service = new Goods_In_HistorySercive();
        public PRM_RPT_002()
        {
            InitializeComponent();
        }

        private void ADateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            documentViewer1.DocumentSource = null;
            threadmethod += ReportBinding;
            using (WaitForm waitfrm = new WaitForm(() => { /*Thread.Sleep(2000);*/ dtpDate.Invoke(threadmethod); }))
            {
                waitfrm.ShowDialog(this);
            }
        }
        public delegate void threadDelegate();
        threadDelegate threadmethod;
        private void ReportBinding()
        {
            
            List<string> workno = new List<string>();
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            figList = service.GetFigurationHistory(date);

            foreach (var item in figList)
            {
                workno.Add(item.Workorderno);
            }
            Inspect_Measure_HistoryService inservice = new Inspect_Measure_HistoryService();
            imhList = inservice.GetFiguration(workno);

            var figurationList = (from req in figList
                                  join val in imhList on req.Workorderno equals val.Workorderno
                                  where req.Workorderno == val.Workorderno
                                  select new { Num = req.Num, Pallet_No = req.Pallet_No, Item_Name = req.Item_Name, Closed_Time = req.Closed_Time.ToString("HH:mm")
                                              ,Workorderno = val.Workorderno, ADate = val.Adate, AVal = val.Aval, BDate = val.Bdate, BVal = val.Bval
                                              ,CDate = val.Cdate, CVal = val.Cval, DDate = val.Ddate, DVal = val.Dval, EDate = val.Edate, EVal = val.Eval
                                  }).ToList();

            dt = ListToDataTable.ToDataTable(figurationList);
            dt.TableName = "datFiguration";
            dsFiguration ds = new dsFiguration();
            //ds.Tables.Clear();
            ds.Tables.Add(dt);
            //ds.Tables[0].TableName = "datFiguration";
            //ds.AcceptChanges();
            rpt.DataSource = ds.Tables["datFiguration"];
            rpt.Parameters["Ins_Date"].Value = dtpDate.Value.ToString("yyyy-MM-dd");
            rpt.Parameters["Ins_Date"].Visible = false; //파라미터 바로 넘기기
            documentViewer1.DocumentSource = rpt;
            rpt.CreateDocument();
        }
    }
}
