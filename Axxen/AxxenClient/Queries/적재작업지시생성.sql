/* 건조대차 현황 */
  SELECT gv.[GV_Code]
      ,gv.[GV_Name]
      ,gv.[GV_Group]
      ,gv.[GV_Status]
      ,im.[Item_Code]
      ,im.[Item_Name]
      ,wo.[Workorderno]
      ,wo.[Prd_Qty]
      ,wo.[Prd_Unit]
	  ,wcm.[Wc_Code]
      ,wcm.[Wo_Ini_Char]
  FROM [WorkOrder] as wo
  JOIN wcm.[WorkCenter_Master] as wcm ON wo.[Wc_Code] = wcm.[Wc_Code] AND wcm.[Use_YN] = 'Y'
  JOIN [Item_Master] as im ON im.[Item_Code] = wo.[Item_Code]
  JOIN (
            SELECT GV_Code, Loading_time 
            FROM [GV_Current_Status] as cs 
            WHERE Loading_time = (SELECT MAX(Loading_time) FROM [GV_Current_Status] as cs2 WHERE cs.GV_Code =cs2.GV_Code GROUP BY cs2.GV_Code 
            )) as gvcs ON gvcs.[Workorderno] = wo.[Workorderno]
  JOIN [GV_Master] as gv ON gv.[GV_Code] = gvcs.[GV_Code]
	WHERE wcm.[Wo_Ini_Char] = @woinichar


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
