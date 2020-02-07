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
        public bool InsertUpdateDef_MaVO(Def_MaVO def)
        {
            return DAC.InsertUpdateDef_MaVO(def);
        }
        /// <summary>
        /// 불량현상대분류 삭제
        /// </summary>
        /// <param name="def"></param>
        /// <returns></returns>
        public bool DeleteDef_MaVO(string defmacode)
        {
            return DAC.DeleteDef_MaVO(defmacode);
        }

        }
}
