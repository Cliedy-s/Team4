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
		LEFT OUTER JOIN [BoxingGrade_Detail_Master] as bdm ON  bdm.[Use_YN] = 'Y' AND pal.Grade_Detail_Code = bdm.Grade_Detail_Code
  WHERE pal.[Use_YN] = 'Y';  ";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<PalletVO> list = Helper.DataReaderMapToList<PalletVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        public List<PalletVO> GetAll(string workOrderNo)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" SELECT pal.[Pallet_No]
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
		LEFT OUTER JOIN [BoxingGrade_Detail_Master] as bdm ON pal.Grade_Detail_Code = bdm.Grade_Detail_Code
  WHERE pal.[Use_YN] = 'Y' AND pal.Workorderno = @workorderno;  ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@workorderno", workOrderNo);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<PalletVO> list = Helper.DataReaderMapToList<PalletVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        public List<PalletGoodsVO> GetPalletGoods(string workOrderNo)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" 
SELECT pm.[Pallet_No]
      ,pm.[Workorderno]
      ,pm.[Barcode_No]
      ,pm.[Barcode_PublishDate]
      ,pm.[Grade_Code]
      ,pm.[Grade_Detail_Code]
	  ,BGDM.Grade_Detail_Name
	  ,BGDM.Boxing_Grade_Code
      ,pm.[Size_Code]
      ,pm.[In_Qty] as palin
      ,pm.[CurrentQty]
      ,pm.[Use_YN]
      ,gih.[Pal_Seq]
      ,gih.[In_Date]
      ,gih.[Upload_Flag]
      ,gih.[Update_YN]
      ,gih.[Contain_Qty]
      ,gih.[In_Qty] as goodsin
      ,gih.[F_In_Qty]
      ,gih.[Closed_Time]
      ,gih.[Cancel_Time]
      ,gih.[Print_Date]
      ,gih.[In_YN]
      ,gih.[Remark]
      ,gih.[Ins_Date]
      ,gih.[Ins_Emp]
      ,gih.[Up_Date]
      ,gih.[Up_Emp]
  FROM [dbo].[Pallet_Master] AS pm
  JOIN [dbo].[Goods_In_History] as gih ON gih.Pallet_No = pm.Pallet_No and gih.Workorderno = pm.Workorderno
  JOIN BoxingGrade_Detail_Master AS BGDM ON PM.Grade_Detail_Code = BGDM.Grade_Detail_Code
  where pm.Workorderno = @workorderno; ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@workorderno", workOrderNo);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<PalletGoodsVO> list = Helper.DataReaderMapToList<PalletGoodsVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 바코드로 팔레트 검색
        /// </summary>
        /// <param name="workOrderNo"></param>
        /// <returns></returns>
        public PalletGoodsVO GetPalletGoods(string workOrderNo, string barcodeno, string palseq)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" 
SELECT pm.[Pallet_No]
      ,pm.[Workorderno]
      ,pm.[Barcode_No]
      ,pm.[Barcode_PublishDate]
      ,pm.[Grade_Code]
      ,pm.[Grade_Detail_Code]
	  ,BGDM.Grade_Detail_Name
	  ,BGDM.Boxing_Grade_Code
      ,pm.[Size_Code]
      ,pm.[In_Qty] as palin
      ,pm.[CurrentQty]
      ,pm.[Use_YN]
      ,gih.[Pal_Seq]
      ,gih.[In_Date]
      ,gih.[Upload_Flag]
      ,gih.[Update_YN]
      ,gih.[Contain_Qty]
      ,gih.[In_Qty] as goodsin
      ,gih.[F_In_Qty]
      ,gih.[Closed_Time]
      ,gih.[Cancel_Time]
      ,gih.[Print_Date]
      ,gih.[In_YN]
      ,gih.[Remark]
      ,gih.[Ins_Date]
      ,gih.[Ins_Emp]
      ,gih.[Up_Date]
      ,gih.[Up_Emp]
  FROM [dbo].[Pallet_Master] AS pm
  JOIN [dbo].[Goods_In_History] as gih ON gih.Pallet_No = pm.Pallet_No and gih.Workorderno = pm.Workorderno
  JOIN BoxingGrade_Detail_Master AS BGDM ON PM.Grade_Detail_Code = BGDM.Grade_Detail_Code
  where pm.Workorderno = @workorderno AND Barcode_No = @barcodeno AND Pal_Seq = @palseq AND In_YN = 'N'; ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@workorderno", workOrderNo);
                comm.Parameters.AddWithValue("@barcodeno", barcodeno);
                comm.Parameters.AddWithValue("@palseq", palseq);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<PalletGoodsVO> list = Helper.DataReaderMapToList<PalletGoodsVO>(reader);
                comm.Connection.Close();

                return list.Count == 0 ? null: list[0];
            }
        }
        /// <summary>
        /// 바코드 번호로 팔레트 검색
        /// </summary>
        /// <param name="barcodeNo"></param>
        /// <returns></returns>
        public PalletVO GetPalletByBarcode(string barcodeNo)
        {
            PalletVO item = null;
            string barcode = barcodeNo.Substring(0, 15);
            string seq = barcodeNo.Substring(15);
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"  SELECT TOP(1) pal.[Pallet_No]
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
  WHERE pal.[Use_YN] = 'Y' AND pal.[Barcode_No] = @barcodeNo ;  ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@barcodeNo", barcodeNo);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    item = new PalletVO()
                    {
                        Pallet_No = reader[0].ToString(),
                        WorkOrderNo = reader[1].ToString(),
                        Barcode_No = reader[2].ToString(),
                        Grade_Detail_Code = reader[3].ToString(),
                        Grade_Detail_Name = reader[4].ToString(),
                        Boxing_Grade_Code = reader[5].ToString(),
                        Size_Code = reader[6].ToString(),
                        In_Qty = Convert.ToInt32(reader[7]),
                        CurrentQty = Convert.ToInt32(reader[8]),
                        Use_YN = reader[9].ToString(),
                        Item_Code = reader[10].ToString(),
                        Item_Name = reader[11].ToString()
                    };
                }
                comm.Connection.Close();

                return item;
            }
        }


        /// <summary>
        /// 입고안된 팔레트목록 가져오기
        /// </summary>
        public List<PalletVO> GetNotInputed(string workOrderNo)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" SELECT pal.[Pallet_No]
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
		LEFT OUTER JOIN [BoxingGrade_Detail_Master] as bdm ON  bdm.[Use_YN] = 'Y' AND pal.Grade_Detail_Code = bdm.Grade_Detail_Code
  WHERE pal.[Use_YN] = 'Y' AND pal.Workorderno = @workorderno
	AND concat(pal.Pallet_No, '&&', wo.[Workorderno]) NOT IN (select distinct concat(Pallet_No, '&&',[Workorderno]) from Goods_In_History where In_YN = 'Y');  ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@workorderno", workOrderNo);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<PalletVO> list = Helper.DataReaderMapToList<PalletVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 팔레트 검색하기
        /// </summary>
        public PalletVO GetPallet(string palletno)
        {
            PalletVO item = null;
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"  SELECT TOP(1) pal.[Pallet_No]
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
  WHERE pal.[Use_YN] = 'Y' AND pal.[Pallet_No] = @palletno ;  ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@palletno", palletno);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    item = new PalletVO()
                    {
                        Pallet_No = reader[0].ToString(),
                        WorkOrderNo = reader[1].ToString(),
                        Barcode_No = reader[2].ToString(),
                        Grade_Detail_Code = reader[3].ToString(),
                        Grade_Detail_Name = reader[4].ToString(),
                        Boxing_Grade_Code = reader[5].ToString(),
                        Size_Code = reader[6].ToString(),
                        In_Qty = Convert.ToInt32(reader[7]),
                        CurrentQty = Convert.ToInt32(reader[8]),
                        Use_YN = reader[9].ToString(),
                        Item_Code = reader[10].ToString(),
                        Item_Name = reader[11].ToString()
                    };
                }
                comm.Connection.Close();

                return item;
            }
        }
        /// <summary>
        /// 팔레트 검색하기
        /// </summary>
        public DataTable GetPalletToDT(string palletno, string workOrderNo, int count)
        {
            DataTable dt = new DataTable();
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"  SELECT TOP(@count) pal.[Pallet_No]
      ,pal.[WorkOrderNo]
      ,CONCAT(pal.[Barcode_No], GIH.PAL_SEQ) AS [Barcode_No]
      ,pal.[Grade_Detail_Code]
      ,bdm.[Grade_Detail_Name]
      ,bdm.[Boxing_Grade_Code]
      ,pal.[Size_Code]
      ,pal.[In_Qty]
      ,pal.[CurrentQty]
      ,pal.[Use_YN]
      ,wo.[Item_Code]
      ,im.[Item_Name]
  FROM Goods_In_History as GIH
		JOIN Pallet_Master AS pal ON GIH.Pallet_No = pal.Pallet_No AND pal.Workorderno = GIH.Workorderno
        LEFT OUTER JOIN  [WorkOrder] as wo ON pal.[WorkorderNo] = wo.[Workorderno]
        LEFT OUTER JOIN [Item_Master] as im ON im.[Item_Code] = wo.[Item_Code]
		LEFT OUTER JOIN [BoxingGrade_Detail_Master] as bdm ON  bdm.[Use_YN] = 'Y' AND pal.Grade_Detail_Code = bdm.Grade_Detail_Code
  WHERE pal.[Use_YN] = 'Y' and pal.[Pallet_No] = @palletno and pal.Workorderno = @workorderno 
  order by gih.pal_seq desc; ";

                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@palletno", palletno);
                comm.Parameters.AddWithValue("@workorderno", workOrderNo);
                comm.Parameters.AddWithValue("@count", count);

                SqlDataAdapter adapter = new SqlDataAdapter(comm);

                comm.Connection.Open();
                adapter.Fill(dt);
                comm.Connection.Close();

                return dt;
            }
        }
        /// <summary>
        /// 팔레트목록 날짜로 가져오기
        /// </summary>
        public List<PalletVO> GetAllByDateTime(string workOrderNo, DateTime fromdate, DateTime todate)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"SELECT pal.[Pallet_No]
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
		LEFT OUTER JOIN [BoxingGrade_Detail_Master] as bdm ON  bdm.[Use_YN] = 'Y' AND pal.Grade_Detail_Code = bdm.Grade_Detail_Code
  WHERE pal.[Use_YN] = 'Y'
	AND pal.Pallet_No NOT IN (select distinct Pallet_No from Goods_In_History where In_YN = 'Y')
    AND Barcode_PublishDate BETWEEN @fromdate AND @todate AND pal.Workorderno = @workorderno;  ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@fromdate", fromdate.Date);
                comm.Parameters.AddWithValue("@todate", todate.Date.AddDays(1));
                comm.Parameters.AddWithValue("@workorderno",workOrderNo);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<PalletVO> list = Helper.DataReaderMapToList<PalletVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 팔레트 정보 가져오기
        /// </summary>
        /// <param name="palletno"></param>
        /// <returns></returns>
        public PalletTodayInVO GetPalletInfo(string palletno)
        {
            PalletTodayInVO item = new PalletTodayInVO();
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" 	SELECT gih.[Workorderno]
      ,wo.[Plan_Date]
      ,gih.[Pallet_No]
      ,pal.[Barcode_No]
      ,pal.[Grade_Detail_Code]
      ,bdm.[Grade_Detail_Name]
      ,bdm.[Boxing_Grade_Code]
      ,pal.[In_Qty]
      ,pal.[CurrentQty]
	  ,pal.Size_Code
      ,gih.[In_Date]
      ,gih.[In_YN]
      ,wo.[Item_Code]
      ,wo.[Wc_Code]
  FROM [WorkOrder] as wo
  RIGHT OUTER JOIN [Goods_In_History] as gih ON gih.[Workorderno] = wo.[Workorderno]
  LEFT OUTER JOIN [Pallet_Master] as pal ON pal.[Pallet_No] = gih.[Pallet_No] AND pal.Workorderno = gih.Workorderno AND pal.[Use_YN] = 'Y' 
  LEFT OUTER JOIN [BoxingGrade_Detail_Master] as bdm ON bdm.[Grade_Detail_Code] = pal.[Grade_Detail_Code] AND bdm.[Use_YN] = 'Y'
    WHERE gih.[Pallet_No] =@palletNo ; ";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@palletNo", palletno);

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    item.Workorderno = reader[0].ToString();
                    item.Plan_Date = Convert.ToDateTime(reader[1].ToString());
                    item.Pallet_No = reader[2].ToString();
                    item.Barcode_No = reader[3].ToString();
                    item.Grade_Detail_Code = reader[4].ToString();
                    item.Grade_Detail_Name = reader[5].ToString();
                    item.Boxing_Grade_Code = reader[6].ToString();
                    item.In_Qty = Convert.ToInt32(reader[7].ToString());
                    item.CurrentQty = Convert.ToInt32(reader[8].ToString());
                    item.Size_Code = reader[9].ToString();
                    item.In_YN = reader[11].ToString();
                    item.Item_Code = reader[12].ToString();
                    item.Wc_Code = reader[13].ToString();
                }
                comm.Connection.Close();

                return item;
            }
        }
        /// <summary>
        /// 입고 가능한 팔레트 목록
        /// </summary>
        /// <returns></returns>
        public List<PalletTodayInVO> GetInablePallet()
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" SELECT gih.[Workorderno]
      ,wo.[Plan_Date]
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
  RIGHT OUTER JOIN [Goods_In_History] as gih ON gih.[Workorderno] = wo.[Workorderno] 
  LEFT OUTER JOIN [Pallet_Master] as pal ON pal.[Pallet_No] = gih.[Pallet_No] and gih.Workorderno = pal.Workorderno AND pal.[Use_YN] = 'Y'
  LEFT OUTER JOIN [BoxingGrade_Detail_Master] as bdm ON bdm.[Grade_Detail_Code] = pal.[Grade_Detail_Code] AND bdm.[Use_YN] = 'Y'
    WHERE In_YN = 'N'; ";
                comm.CommandType = CommandType.Text;

                comm.Connection.Open();
                SqlDataReader reader = comm.ExecuteReader();
                List<PalletTodayInVO> list = Helper.DataReaderMapToList<PalletTodayInVO>(reader);
                comm.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 금일 입고 팔레트 목록
        /// </summary>
        /// <returns></returns>
        public List<PalletTodayInVO> GetPalletTodayIn(string workorderno)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"SELECT gih.[Workorderno]
      ,wo.[Plan_Date]
      ,gih.[Pallet_No]
      ,pal.[Barcode_No]
      ,pal.[Grade_Detail_Code]
      ,bdm.[Grade_Detail_Name]
      ,bdm.[Boxing_Grade_Code]
      ,gih.F_In_Qty as In_Qty
      ,pal.[CurrentQty]
	  ,pal.Size_Code
      ,gih.[In_Date]
      ,gih.[In_YN]
      ,wo.[Item_Code]
      ,wo.[Wc_Code]
	  ,im.Item_Name
	  ,gih.Pal_Seq
  FROM [dbo].[Pallet_Master] AS pal
  JOIN WorkOrder AS WO ON pal.Workorderno = wo.Workorderno
  JOIN Item_Master as im on im.Item_Code = wo.Item_Code
  JOIN [dbo].[Goods_In_History] as gih ON gih.Pallet_No = pal.Pallet_No and gih.Workorderno = pal.Workorderno AND In_YN = 'Y'
  JOIN BoxingGrade_Detail_Master AS bdm ON pal.Grade_Detail_Code = bdm.Grade_Detail_Code
    WHERE  gih.[In_Date] = CAST(GETDATE() AS DATE) AND gih.Workorderno = @workorderno ;";
                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@workorderno", workorderno);

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
        public bool UpdateBarcodeNo(string palletNo, string workorderno, string barcodeno)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" UPDATE [Pallet_Master] SET [Barcode_No] = @BarcodeNo WHERE Pallet_No = @PalletNo AND Workorderno = @Workorderno; ";

                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@BarcodeNo", barcodeno);
                comm.Parameters.AddWithValue("@PalletNo", palletNo);
                comm.Parameters.AddWithValue("@Workorderno", workorderno);

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
        public bool IsExistPallet(string palletNo, string workorderno)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" SELECT count(*) FROM [Pallet_Master] WHERE [Pallet_No] = @PalletNo AND Workorderno = @workorderno; ";

                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@PalletNo", palletNo);
                comm.Parameters.AddWithValue("@workorderno", workorderno);

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
        public bool InsertPallet(PalletVO item, string userid)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =@"InsertPallet";

                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@Pallet_No", item.Pallet_No);
                comm.Parameters.AddWithValue("@Workorderno", item.WorkOrderNo);
                comm.Parameters.AddWithValue("@Barcode_No", item.Barcode_No);
                comm.Parameters.AddWithValue("@Grade_Detail_Code", item.Grade_Detail_Code);
                comm.Parameters.AddWithValue("@Grade_Code", item.Boxing_Grade_Code);
                comm.Parameters.AddWithValue("@Size_Code", item.Size_Code);
                comm.Parameters.AddWithValue("@In_Qty", item.In_Qty);
                comm.Parameters.AddWithValue("@CurrentQty", item.CurrentQty);
                comm.Parameters.AddWithValue("@userid", userid);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                return result > 1;
            }
        }
        /// <summary>
        /// 팔레트 수량 증가
        /// </summary>
        public bool UpdatePallet(string palletno, int qty, string workorderno, string sizecode, string userid)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = @"UpdatePallet";

                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@Pallet_No", palletno);
                comm.Parameters.AddWithValue("@qty", qty);
                comm.Parameters.AddWithValue("@Workorderno", workorderno);
                comm.Parameters.AddWithValue("@Size_Code", sizecode);
                comm.Parameters.AddWithValue("@userid", userid);

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
        public bool InputPallet(string userid, string workorderno, string palletno, List<string> seqs)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string item in seqs)
            {
                sb.Append(item + "@");
            }

            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText = "InsertUpdatePalletInput";

                comm.CommandType = CommandType.StoredProcedure;
                comm.Parameters.AddWithValue("@username", userid);
                comm.Parameters.AddWithValue("@workorderno", workorderno);
                comm.Parameters.AddWithValue("@palletno", palletno);
                comm.Parameters.AddWithValue("@In_Qty", seqs.Count);
                comm.Parameters.AddWithValue("@seqs", sb.ToString().TrimEnd('@'));
                comm.Parameters.AddWithValue("@seperator", "@");

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                if(result <= 0)
                {
                    Log.WriteInfo($"{userid}이(가) 팔레트를 입고하려했지만 작업지시번호({workorderno})와 팔레트번호({palletno})가 일치하는 포장이력이 존재하지 않음");
                }
                return result > 1;
            }
        }
        /// <summary>
        /// 팔레트 입고여부
        /// </summary>
        /// <param name="palletno"></param>
        /// <returns></returns>
        public bool IsPalletInput(string palletno, string workorderno)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @" SELECT TOP(1) [In_YN]
  FROM [dbo].[Goods_In_History]
  WHERE Pallet_No = @palletno AND Workorderno = @workorderno
  ORDER BY In_YN DESC; ";

                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@palletno", palletno);
                comm.Parameters.AddWithValue("@workorderno", workorderno);

                comm.Connection.Open();
                string result = (comm.ExecuteScalar() ?? string.Empty).ToString();
                comm.Connection.Close();

                return result.Equals("Y");
            }
        }
        /// <summary>
        /// 팔레트 삭제
        /// </summary>
        /// <returns></returns>
        public bool DeletePallet(string palletno, string workOrderNo)
        {
            using (SqlCommand comm = new SqlCommand())
            {
                comm.Connection = new SqlConnection(Connstr);
                comm.CommandText =
 @"DELETE FROM [Pallet_Master] WHERE [Pallet_No] =@palletno AND Workorderno = @workOrderNo; ";

                comm.CommandType = CommandType.Text;
                comm.Parameters.AddWithValue("@palletno", palletno);
                comm.Parameters.AddWithValue("@workOrderNo", workOrderNo);

                comm.Connection.Open();
                int result = comm.ExecuteNonQuery();
                comm.Connection.Close();

                if(result == 0) Log.WriteError($"존재하지않는 팔레트({palletno})를 제거하려함");
                return result > 0;
            }
        }
    }
}
