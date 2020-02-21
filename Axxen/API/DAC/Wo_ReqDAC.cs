using API.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace API.DAC
{
    public class Wo_ReqDAC : DACParent
    {
        /// <summary>
        /// 품목정보 전체
        /// </summary>
        /// <param name="id"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public List<Wo_ReqVO> GetAllWo_ReqVO()
        {
            try
            {
                List<Wo_ReqVO> Itemlist = null;
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = new SqlConnection(Connstr);
                    com.CommandText = @"/****** SSMS의 SelectTopNRows 명령 스크립트 ******/
SELECT TOP (1000) [Wo_Req_No]
      ,[Req_Seq]
      ,[Item_Code]
      ,[Req_Qty]
      ,[Prd_Plan_Date]
      ,[Cust_Name]
      ,[Project_Name]
      ,[Sale_Emp]
      ,[Req_Status]

  FROM [dbo].[Wo_Req]";
                    com.CommandType = CommandType.Text;

                    com.Connection.Open();
                    SqlDataReader reader = com.ExecuteReader();
                    Itemlist = Helper.DataReaderMapToList<Wo_ReqVO>(reader);
                    com.Connection.Close();

                    return Itemlist;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}