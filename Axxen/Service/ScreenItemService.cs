using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;
using DAC;
namespace Service
{
   public class ScreenItemService
    {

        public List<ScreenItem_AuthorityVO> GetUserInfoScreenItem(List<UserGroup_MappingVO> list)
        {
            ScreenItemDAC dac = new ScreenItemDAC();

            return dac.GetUserInfoScreenItem(list);
        }

        /// <summary>
        /// 모든 스크린 아이템
        /// </summary>
        /// <param name="groupCode"></param>
        /// <returns></returns>
        public List<ScreenItem_MasterVO> GetALLScreenItem()
        {
            ScreenItemDAC dac = new ScreenItemDAC();

            return dac.GetALLScreenItem();
        }

            public List<ScreenItem_AuthorityVO> GetUseGroupScreenItem(string groupCode)
        {
            ScreenItemDAC dac = new ScreenItemDAC();

            return dac.GetUseGroupScreenItem(groupCode);
        }
        public List<ScreenItem_AuthorityVO> GetNotUseGroupScreenItem(string groupCode)
        {
            ScreenItemDAC dac = new ScreenItemDAC();

            return dac.GetNotUseGroupScreenItem(groupCode);
        }

        public void InsertUpdateScreenItem_Authority(List<ScreenItem_AuthorityVO> List)
        {
            ScreenItemDAC dac = new ScreenItemDAC();

             dac.InsertUpdateScreenItem_Authority(List);
        }
        
              public void DeleteGroupUseScreenItem_Authority(string group,List<ScreenItem_AuthorityVO> List)
        {
            ScreenItemDAC dac = new ScreenItemDAC();

            dac.DeleteGroupUseScreenItem_Authority(group,List);
        }
    }
}
