using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
   public class Def_MaService
    {
        Def_MaDAC DAC;
        public Def_MaService()
        {
            DAC = new Def_MaDAC();
        }
        public List<Def_MaVO> GetAllDef_Ma_Master()
        {

            return DAC.GetAllDef_Ma_Master();
        }
        public bool GetUpdateDef_Ma_Master(string groupcode, string used)
        {
            return DAC.GetUpdateDef_Ma_Master(groupcode, used);
        }

        }
}
