/* 현황 */
  SELECT gv.[GV_Code]
      ,gv.[GV_Name]
      ,gv.[GV_Group]
      ,im.[Item_Code]
      ,im.[Item_Name]
      ,wo.[Workorderno]
      ,wo.[Prd_Qty]
  FROM [WorkOrder] as wo
  JOIN [Item_Master] as im ON im.[Item_Code] = wo.[Item_Code]
  JOIN [GV_Current_Status] as gvcs ON gvcs.[Workorderno] = wo.[Workorderno]
  JOIN [GV_Master] as gv ON gv.[GV_Code] = gvcs.[GV_Code]


 /* 등록 */
  INSERT INTO [WorkOrder]
           ([Workorderno]
           ,[Item_Code]
           ,[Wc_Code]
           ,[Plan_Qty]
           ,[Plan_Unit]
           ,[Plan_Date]
           ,[Wo_Status]
           ,[Wo_Order]
           ,[Wo_Req_No]
           ,[Req_Seq]
           ,[Mat_LotNo]
           ,[Ins_Date]
           ,[Ins_Emp]
     VALUES
           (<Workorderno, nvarchar(20),>
           ,<Item_Code, nvarchar(20),>
           ,<Wc_Code, nvarchar(20),>
           ,<Plan_Qty, int,>
           ,<Plan_Unit, nvarchar(20),>
           ,<Plan_Date, date,>
           ,<Wo_Status, nvarchar(20),>
           ,<Wo_Order, int,>
           ,<Wo_Req_No, nvarchar(20),>
           ,<Req_Seq, int,>
           ,<Mat_LotNo, nvarchar(10),>
           ,<Ins_Date, datetime,>
           ,<Ins_Emp, nvarchar(20),>);
