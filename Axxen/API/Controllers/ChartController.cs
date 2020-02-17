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
            List<ChartOutputVO> outputList = chartdac.GetItemOutputChart(name);

            StringBuilder sb = new StringBuilder();
            string data1 = string.Empty, data2 = string.Empty, data3 = string.Empty;

            List<int> planqtys = new List<int>();
            List<int> prdqtys = new List<int>();
            List<decimal> attain = new List<decimal>();

            foreach (var group in outputList)
            {
                sb.Append(group.Prd_Date + ",");
                planqtys.Add(group.Plan_Qty);
                prdqtys.Add(group.Prd_Qty);
                attain.Add(group.Attain);
            }
            data1 = "[" + string.Join(",", planqtys.ToArray()) + "]";
            data2 = "[" + string.Join(",", prdqtys.ToArray()) + "]";
            data3 = "[" + string.Join(",", attain.ToArray()) + "]";
            planqtys.Clear();
            prdqtys.Clear();
            attain.Clear();

            string labels = sb.ToString().TrimEnd(',');

            ViewBag.Labels = labels;
            ViewBag.Data1 = data1;
            ViewBag.Data2 = data2;
            ViewBag.Data3 = data3;
            ViewBag.Name = name;

            return View();
        }
    }
}