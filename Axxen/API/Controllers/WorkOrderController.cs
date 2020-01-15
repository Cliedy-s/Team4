using API.DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VO;

namespace API.Controllers
{
    public class WorkOrderController : ApiController
    {
        public List<WorkOrder_J_WC_ItmeVO> GetAll_WorkOrder_Item_WC()
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.GetAll_WorkOrder_Item_WC();
        }
    }
}
