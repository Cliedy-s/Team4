using Axxen.sangyoung;
using Axxen.Util;
using DevExpress.XtraReports.UI;
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
        dsFiguration ds = new dsFiguration();
        List<Goods_In_HistoryVO> figList;
        List<InspectMeasureHistoryVO> imhList;
        DataTable dt = new DataTable();
        FigurationLog rpt = new FigurationLog();
        Goods_In_HistorySercive service = new Goods_In_HistorySercive();
        Inspect_Measure_HistoryService inservice = new Inspect_Measure_HistoryService();

        public PRM_RPT_002()
        {
            InitializeComponent();
        }

        private void ADateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            documentViewer1.DocumentSource = null;
           
        }
        public delegate void threadDelegate();
        threadDelegate threadmethod;
        private void ReportBinding()
        {
            string date = dtpDate.Value.ToString("yyyy-MM-dd");
            figList = service.GetFigurationHistory(date);
            List<string> orders = service.GetFigurationOrders(date);
            imhList = inservice.GetFiguration(orders);
            //foreach (var item in figList)
            //{
            //    if (figList.Find(x => item.Workorderno == x.Workorderno) != null)
            //    {
            //        workno.Add(item.Workorderno);
            //    }
            //}

            //imhList = inservice.GetFiguration(workno);

            //var figurationList = (from req in figList
            //                      join val in imhList on req.Workorderno equals val.Workorderno
            //                      where req.Workorderno == val.Workorderno
            //                      select new
            //                      {
            //                          Num = req.Num,
            //                          GV_Code = req.GV_Code,
            //                          Item_Name = req.Item_Name,
            //                          Prd_Endtime = req.Prd_Endtime.ToString("HH:mm")
            //                                  ,
            //                          Workorderno = val.Workorderno,
            //                          ADate = val.Adate,
            //                          AVal = val.Aval,
            //                          BDate = val.Bdate,
            //                          BVal = val.Bval,
            //                          CDate = val.Cdate,
            //                          CVal = val.Cval,
            //                          DDate = val.Ddate,
            //                          DVal = val.Dval,
            //                          EDate = val.Edate,
            //                          EVal = val.Eval
            //                      }).ToList();

            
            ds.Relations.Clear();
            ds.Tables.Clear();
            try
            {

            
            dt = ListToDataTable.ToDataTable(figList);
            ds.Tables.Add(dt);
            ds.Tables[0].TableName = "dtFiguration";
            

            dt = ListToDataTable.ToDataTable(imhList);
            ds.Tables.Add(dt);
            ds.Tables[1].TableName = "dtFigurHistory";

            ds.Relations.Add("dtFigurHistory_dtFiguration", ds.Tables[1].Columns["Workorderno"], ds.Tables[0].Columns["Workorderno"]);
            }
            catch
            {
               
            }

            //ds.Tables[0].TableName = "datFiguration";
            //ds.AcceptChanges();

            //dt = ListToDataTable.ToDataTable(imhList);
            //dt.TableName = "FiguraHistroy";
            //ds.Tables.Add(dt);

            rpt.DataSource = ds;
            rpt.Parameters["Ins_Date"].Value = dtpDate.Value.ToString("yyyy-MM-dd");
            rpt.Parameters["Ins_Date"].Visible = false; //파라미터 바로 넘기기
            documentViewer1.DocumentSource = rpt;
            rpt.CreateDocument();
            
            
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            threadmethod += ReportBinding;
            using (WaitForm waitfrm = new WaitForm(() => { /*Thread.Sleep(2000);*/ dtpDate.Invoke(threadmethod); }))
            {
                waitfrm.ShowDialog(this);
            }
        }

        private void TsbtnPrint_Click(object sender, EventArgs e)
        {
            using (ReportPrintTool printTool = new ReportPrintTool(rpt))
            {
                printTool.ShowRibbonPreviewDialog();
            }
        }

        private void PRM_RPT_002_Activated(object sender, EventArgs e)
        {
            ToolStripManager.Merge(toolStrip1, ((MainForm)this.MdiParent).toolStrip1); //출력버튼추가
            toolStrip1.Visible = false;
        }

        private void PRM_RPT_002_Deactivate(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(((MainForm)this.MdiParent).toolStrip1);
        }
    }
}
