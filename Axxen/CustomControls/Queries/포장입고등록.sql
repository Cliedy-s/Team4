/*금일 입고 팔레트 목록*/
SELECT gih.[Workorderno]
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
  WHERE gih.[In_Date] = CAST(GETDATE() AS DATE) AND gih.[In_YN] = 'Y'

/*입고*/
/*찾기버튼*/
  SELECT pal.[Pallet_No]
      ,pal.[Barcode_No]
      ,pal.[Grade_Detail_Code]
      ,bdm.[Grade_Detail_Name]
      ,bdm.[Boxing_Grade_Code]
      ,pal.[In_Qty]
  FROM [Pallet_Master] as pal
  JOIN bdm.[BoxingGrade_Detail_Master] ON bdm.[Use_YN] = 1 AND bdm.[Grade_Detail_Code] = pal.[Grade_Detail_Code]
  WHERE pal.[IsActive] = 1
  AND pal.[WorkOrderNo] = @Workorderno;
      
  /*입고버튼*/
UPDATE [dbo].[Goods_In_History]
   SET 
      [In_Date] = <In_Date, date,>
      ,[In_YN] = <In_YN, nchar(1),>
      ,[Up_Date] = <Up_Date, datetime,>
      ,[Up_Emp] = <Up_Emp, nvarchar(20),>
 WHERE [Workorderno] = '작업지시'
            ,[Pallet_No] = '팔래트번호';
