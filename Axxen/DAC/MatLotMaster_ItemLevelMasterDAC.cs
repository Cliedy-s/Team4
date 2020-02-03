using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAC
{
    public class MatLotMaster_ItemLevelMasterDAC : DACParent
    {
        public List<MatLotMaster_ItemLevelMasterVO> GetAllMatLotMaster_ItemLevelMaster()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"select YYYY,ilm.Level_Code,Level_Name,Prd_Order,Mat_LotNo
                                    from Item_Level_Master ilm INNER JOIN Mat_Lot_Master mlm ON ilm.Level_Code = mlm.Level_Code";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<MatLotMaster_ItemLevelMasterVO> list = Helper.DataReaderMapToList<MatLotMaster_ItemLevelMasterVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }

        public List<MatLotMaster_ItemLevelMasterVO> PickerMatLotMaster_ItemLevelMaster(string ADateTimePickerValue) //DateTimePicker 사용
        {
            List<MatLotMaster_ItemLevelMasterVO> list = null;
            using (SqlConnection conn = new SqlConnection(Connstr))
            {
                conn.Open();
                string sql = $"select YYYY,ilm.Level_Code,Level_Name,Prd_Order,Mat_LotNo " +
                             $"from Item_Level_Master ilm INNER JOIN Mat_Lot_Master mlm ON ilm.Level_Code = mlm.Level_Code " +
                             $"where YYYY='{ADateTimePickerValue}'";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    list = Helper.DataReaderMapToList<MatLotMaster_ItemLevelMasterVO>(cmd.ExecuteReader());
                }
                conn.Close();
            }
            return list;
        }
        
    }
}
