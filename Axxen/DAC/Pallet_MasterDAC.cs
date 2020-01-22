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
    class Pallet_MasterDAC : DACParent
    {
        /// <summary>
        /// 팔레트목록 가져오기
        /// </summary>
        public List<PalletVO> GetAll(string workorderno)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" SELECT pal.[Pallet_No]
      ,pal.[WorkOrderNo]
      ,pal.[Barcode_No]
      ,pal.[Grade_Detail_Code]
      ,pal.[Size_Code]
      ,pal.[In_Qty]
      ,pal.[CurrentQty]
      ,pal.[Use_YN]
      ,wo.[Item_Code]
      ,im.[Item_Name]
  FROM [Pallet_Master] as pal
        JOIN  [WorkOrder] as wo ON pal.[WorkorderNo] = wo.[Workorderno]
        JOIN [Item_Master] as im ON im.[Item_Code] = wo.[Item_Code]
  WHERE pal.[Use_YN] = 'Y'
    AND @Workorderno = pal.[Workorderno]; ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Workorderno", workorderno);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<PalletVO> list = Helper.DataReaderMapToList<PalletVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 등급상세정보를 추가한 팔레트목록
        /// </summary>
        /// <param name="workorderno"></param>
        /// <returns></returns>
        public List<PalletDetailVO> GetAllDetail(string workorderno)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"  SELECT pal.[Pallet_No]
      ,pal.[Barcode_No]
      ,pal.[Grade_Detail_Code]
      ,bdm.[Grade_Detail_Name]
      ,bdm.[Boxing_Grade_Code]
      ,pal.[In_Qty]
  FROM [Pallet_Master] as pal
  JOIN bdm.[BoxingGrade_Detail_Master] ON bdm.[Use_YN] = 1 AND bdm.[Grade_Detail_Code] = pal.[Grade_Detail_Code]
  WHERE pal.[IsActive] = 1
  AND pal.[WorkOrderNo] = @Workorderno; ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Workorderno", workorderno);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<PalletDetailVO> list = Helper.DataReaderMapToList<PalletDetailVO>(reader);
                comm.Connection.Close();

                return list;
            }

        }
        /// <summary>
        /// 금일 입고 팔레트 목록
        /// </summary>
        /// <returns></returns>
        public List<PalletTodayInVO> GetPalletTodayIn()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" SELECT gih.[Workorderno]
      ,gih.[Pallet_No]
      ,pal.[Barcode_No]
      ,pal.[Grade_Detail_Code]
      ,bdm.[Grade_Detail_Name]
      ,bdm.[Boxing_Grade_Code]
      ,pal.[In_Qty]
      ,pal.[CurrentQty]
      ,gih.[In_Date]
      ,gih.[In_YN]
      ,wo.[Item_Code]
      ,wo.[Wc_Code]
  FROM [WorkOrder] as wo
  JOIN [Goods_In_History] as gih ON gih.[Workorderno] = wo.[Workorderno]
  JOIN [Pallet_Master] as pal ON pal.[Pallet_No] = gih.[Pallet_No] AND pal.[Use_YN] = 1
  JOIN [BoxingGrade_Detail_Master] as bdm ON bdm.[Grade_Detail_Code] = pal.[Grade_Detail_Code] AND bdm.[Use_YN] = 1
  WHERE gih.[In_Date] = CAST(GETDATE() AS DATE) AND gih.[In_YN] = 'Y'; ";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<PalletTodayInVO> list = Helper.DataReaderMapToList<PalletTodayInVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 팔레트 생성
        /// </summary>
        public bool InsertPallet(PalletVO item)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" INSERT INTO [dbo].[Pallet_Master]
           ([Pallet_No]
           ,[Workorderno]
           ,[Barcode_No]
           ,[Grade_Detail_Code]
           ,[Size_Code]
           ,[In_Qty]
           ,[CurrentQty]
           ,[Use_YN])
     VALUES
           (@Pallet_No
           ,@Workorderno
           ,@Barcode_No
           ,@Grade_Detail_Code
           ,@Size_Code
           ,@In_Qty
           ,@CurrentQty
           ,1);  ";

                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@Pallet_No", item.Pallet_No);
                comm.Parameters.AddWithValue("@Workorderno", item.WorkOrderNo);
                comm.Parameters.AddWithValue("@Barcode_No", item.Barcode_No);
                comm.Parameters.AddWithValue("@Grade_Detail_Code", item.Grade_Detail_Code);
                comm.Parameters.AddWithValue("@Size_Code", item.Size_Code);
                comm.Parameters.AddWithValue("@In_Qty", item.In_Qty);
                comm.Parameters.AddWithValue("@CurrentQty", item.CurrentQty);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        }
        /// <summary>
        /// 팔레트입고
        /// </summary>
        /// <returns></returns>
        public bool InputPallet(string username, string workorderno, string palletno)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" UPDATE [dbo].[Goods_In_History]
   SET 
      [In_Date] = getdate()
      ,[In_YN] = 'Y'
      ,[Up_Date] = getdate()
      ,[Up_Emp] = @username
 WHERE [Workorderno] = @workorderno
            ,[Pallet_No] =@palletno';  ";

                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@username", username);
                comm.Parameters.AddWithValue("@workorderno", workorderno);
                comm.Parameters.AddWithValue("@palletno", palletno);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        }
    }
}
