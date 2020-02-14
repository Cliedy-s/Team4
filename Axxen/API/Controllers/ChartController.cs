using API.DAC;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace API.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        public ActionResult Index(string name)
        {
            ChartDAC chartdac = new ChartDAC();
            //name = "이형벽돌(계단Gray)";
            List<ChartOutputVO> outputList = chartdac.GetItemOutputChart(name);

            //var mylist = from data in outputList
            //             orderby data.Prd_Date
            //             group data by data.Item_Name;

            //List<string> keys = new List<string>();
            StringBuilder sb = new StringBuilder();
            string data1 = string.Empty, data2 = string.Empty;//, data3 = string.Empty, data4 = string.Empty, data5 = string.Empty, data6 = string.Empty;

            List<int> planqtys = new List<int>();
            List<int> prdqtys = new List<int>();

            //int k = 0;
            foreach (var group in outputList)
            {
                //keys.Add(group.Key);
                //foreach (var item in group)
                //{
                //if (k == 0)
                //{
                sb.Append(group.Prd_Date + ",");
                //}
                planqtys.Add(group.Plan_Qty);
                prdqtys.Add(group.Prd_Qty);
                //}
                //if (k == 0)
                //{
                //data1 = "[" + string.Join(",", planqtys.ToArray()) + "]";
                //data2 = "[" + string.Join(",", prdqtys.ToArray()) + "]";
                //}
                //k++;


                //else if (k == 1)
                //{
                //    data3 = "[" + string.Join(",", planqtys.ToArray()) + "]";
                //    data4 = "[" + string.Join(",", prdqtys.ToArray()) + "]";
                //} 
                //else if (k == 2)
                //{
                //    data5 = "[" + string.Join(",", planqtys.ToArray()) + "]";
                //    data6 = "[" + string.Join(",", planqtys.ToArray()) + "]";
                //}
                //planqtys.Clear();
                //prdqtys.Clear();
            }
            data1 = "[" + string.Join(",", planqtys.ToArray()) + "]";
            data2 = "[" + string.Join(",", prdqtys.ToArray()) + "]";
            planqtys.Clear();
            prdqtys.Clear();

            string labels = sb.ToString().TrimEnd(',');
            //string label1 = keys[0];
            //string label2 = keys[1];
            //string label3 = keys[2];

            ViewBag.Labels = labels;
            //ViewBag.Label1 = label1;
            ViewBag.Data1 = data1;
            //ViewBag.Label2 = label2;
            ViewBag.Data2 = data2;
            //ViewBag.Label3 = label3;
            //ViewBag.Data3 = data3;

            return View();
        }
    }
}