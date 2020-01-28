﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VO;

namespace DAC
{
    public class Pallet_MasterDAC : DACParent
    {
        /// <summary>
        /// 팔레트목록 가져오기
        /// </summary>
        public List<PalletVO> GetAll()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"  SELECT pal.[Pallet_No]
      ,pal.[WorkOrderNo]
      ,pal.[Barcode_No]
      ,pal.[Grade_Detail_Code]
      ,bdm.[Grade_Detail_Name]
      ,bdm.[Boxing_Grade_Code]
      ,pal.[Size_Code]
      ,pal.[In_Qty]
      ,pal.[CurrentQty]
      ,pal.[Use_YN]
      ,wo.[Item_Code]
      ,im.[Item_Name]
  FROM [Pallet_Master] as pal
        LEFT OUTER JOIN  [WorkOrder] as wo ON pal.[WorkorderNo] = wo.[Workorderno]
        LEFT OUTER JOIN [Item_Master] as im ON im.[Item_Code] = wo.[Item_Code]
		LEFT OUTER JOIN [BoxingGrade_Detail_Master] as bdm ON  bdm.[Use_YN] = 'Y' AND pal.Grade_Detail_Code = bdm.Boxing_Grade_Code
  WHERE pal.[Use_YN] = 'Y';  ";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<PalletVO> list = Helper.DataReaderMapToList<PalletVO>(reader);
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
        /// 바코드 번호 변경하기
        /// </summary>
        /// <param name="palletNo"></param>
        /// <returns></returns>
        public bool UpdateBarcodeNo(string palletNo, string barcodeno)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" UPDATE [Pallet_Master] SET [Barcode_No] = @BarcodeNo WHERE Pallet_No = @PalletNo; ";

                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@BarcodeNo", barcodeno);
                comm.Parameters.AddWithValue("@PalletNo", palletNo);

                comm.Connection.Open();
                int result = Convert.ToInt32(comm.ExecuteNonQuery());
                comm.Connection.Close();

                return result > 0;
            }
        }
        /// <summary>
        /// 존재하는 팔레트인지 확인
        /// </summary>
        /// <param name="palletNo"></param>
        /// <returns></returns>
        public bool IsExistPallet(string palletNo)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" SELECT count(*) FROM [Pallet_Master] WHERE [Pallet_No] = @PalletNo;  ";

                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@PalletNo", palletNo);

                comm.Connection.Open();
                int result = Convert.ToInt32(comm.ExecuteScalar());
                comm.Connection.Close();

                return result > 0;
            }

        }
        /// <summary>
        /// 바코드 번호 가져오기
        /// </summary>
        /// <param name="palletNo"></param>
        /// <returns></returns>
        public string GetBarcodeNo(string palletNo)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" SELECT [Barcode_No]
  FROM [dbo].[Pallet_Master]
  WHERE Use_YN = 'Y' AND Pallet_No = @PalletNo;  ";

                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@PalletNo", palletNo);

                comm.Connection.Open();
                string result = comm.ExecuteScalar().ToString();
                comm.Connection.Close();

                return result;
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
           ,'Y');  ";

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
        /// <summary>
        /// 팔레트 삭제
        /// </summary>
        /// <returns></returns>
        public bool DeletePallet(string palletno)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" DELETE FROM [Pallet_Master] WHERE [Pallet_No] =@palletno; ";

                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@palletno", palletno);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 0;
            }
        }
    }
}
