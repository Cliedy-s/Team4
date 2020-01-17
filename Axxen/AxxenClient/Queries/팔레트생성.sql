/*팔레트 현황*/
  SELECT pal.[Pallet_No]
      ,pal.[Workorderno]
      ,pal.[Grade_Code]
      ,pal.[Grade_Detail_Code]
      ,pal.[Grade_Detail_Name]
      ,pal.[CurrentQty]
      ,wo.[Item_Code]
      ,im.[Item_Name]
  FROM [Pallet_Master] as pal
        JOIN  [WorkOrder] as wo ON pal.[Workorderno] = wo.[Workorderno]
        JOIN [Item_Master] as im ON im.[Item_Code] = wo.[Item_Code]
  WHERE pal.[IsActive] = 1 
    AND '현재작업지시번호' = pal.[Workorderno] ;

/*팔레트 생성*/
 INSERT INTO [dbo].[Pallet_Master]
           ([Pallet_No]
           ,[Workorderno]
           ,[Barcode_No]
           ,[Grade_Code]
           ,[Grade_Detail_Code]
           ,[Grade_Detail_Name]
           ,[In_Qty]
           ,[CurrentQty]
           ,[IsActive])
     VALUES
           (<Pallet_No, nvarchar(10),>
           ,<Workorderno, nvarchar(20),>
           ,<Barcode_No, nvarchar(20),>
           ,<Grade_Code, nvarchar(20),>
           ,<Grade_Detail_Code, nvarchar(20),>
           ,<Grade_Detail_Name, nvarchar(100),>
           ,<In_Qty, int,>
           ,<CurrentQty, int,>
           ,<IsActive, bit,>)