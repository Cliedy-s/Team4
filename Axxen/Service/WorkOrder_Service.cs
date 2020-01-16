using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class WorkOrder_Service
    {
        public List<WorkOrder_J_WC_ItmeVO> GetAll_WorkOrder_Item_WC()
        {
            WorkOrderDAC dac = new WorkOrderDAC();
            return dac.GetAll_WorkOrder_Item_WC();
        }
     
    }
}
