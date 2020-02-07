using DAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace Service
{
    public class Def_MiService
    {
        Def_MiDAC DAC;
        public Def_MiService()
        {
            DAC = new Def_MiDAC();
        }

        public List<Def_MiVO> GetAllDef_Mi_Master()
        {
            return DAC.GetAllDef_Mi_Master();
        }

        public bool InsertUpdateDef_Mi_Master(Def_MiVO item)
        {

            return DAC.InsertUpdateDef_Mi_Master(item);
        }

        /// <summary>
        /// 상세내용 사용유무update 
        /// </summary>
        /// <returns></returns>
        public bool UsedDef_Mi_Master(string Def_Ma_Code, string used)
        {
            return DAC.UsedDef_Mi_Master(Def_Ma_Code, used);
        }
        /// <summary>
        /// 불량상세 삭제
        /// </summary>
        /// <param name="micode"></param>
        /// <returns></returns>
        public bool DeleteDef_MiVO(string micode)
        {
            return DAC.DeleteDef_MiVO(micode);
        }
        }
}
