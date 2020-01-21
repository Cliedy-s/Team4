/*팔레트 현황*/
  SELECT pal.[Pallet_No]
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
    AND '현재작업지시번호' = pal.[Workorderno] ;

/*팔레트 생성*/
 INSERT INTO [dbo].[Pallet_Master]
           ([Pallet_No]
           ,[Workorderno]
           ,[Barcode_No]
           ,[Grade_Detail_Code]
           ,[Size_Code]
           ,[In_Qty]
           ,[CurrentQty]
           ,[Use_YN])
     VALUES
           (<Pallet_No, nvarchar(10),>
           ,<Workorderno, nvarchar(20),>
           ,<Barcode_No, nvarchar(20),>
           ,<Grade_Detail_Code, nvarchar(20),>
           ,<Size_Code nvarchar(20),>
           ,<In_Qty, int,>
           ,<CurrentQty, int,>
           ,<Use_YN, nchar(1),>)