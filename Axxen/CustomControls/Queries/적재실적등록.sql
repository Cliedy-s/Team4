/*소성대차*/
  SELECT gv.[GV_Code]
      ,gv.[GV_Name]
      ,gv.[GV_Group]
      ,gv.[GV_Status]
      ,gv.[Unloading_Wc]
  FROM [GV_Master] as gv
 WHERE '소성대차' = gv.[GV_Group] AND  gv.[GV_Status] = '빈대차' AND gv.[Use_YN]='Y';

/*건조대차*/
  SELECT gv.[GV_Code]
      ,gv.[GV_Name]
      ,gv.[GV_Group]
      ,gv.[GV_Status]
      ,gv.[Unloading_Wc]
	  ,GetCurrentWorkOrderNoByGVCode(gv.[GV_Code]) as Workorderno
      ,wo.[Prd_Qty]
      ,wo.[Prd_Unit]
      ,gvcs.[Loading_time]
  FROM [GV_Master] as gv
	JOIN [WorkOrder] as wo ON wo.[Workorderno] = Workorderno
	JOIN [GV_Current_Status] as gvcs ON gvcs.[Workorderno] = Workorderno
  WHERE gv.[Use_YN] = 'Y'
	AND gv.[GV_Group] = '성형건조'
	AND wo.[Workorderno] = '현재 작업지시';

/*옮겨타기*/
INSERT INTO [dbo].[GV_History]
           ([GV_Code]
           ,[Workorderno]
           ,[Loading_Date]
           ,[Loading_time]
           ,[Loading_Qty]
           ,[Loading_Wc]
           ,[Ins_Date]
           ,[Ins_Emp]
           ,[Up_Date]
           ,[Up_Emp])
     VALUES
           (@togvcode
           ,@workorderno
           ,getdate()
           ,getdate()
           ,@qty
           ,@wccode
           ,getdate()
           ,@username
           ,getdate()
           ,@username)
 INSERT INTO [dbo].[GV_Current_Status]
           ([GV_Code]
           ,[Workorderno]
           ,[GV_Qty]
           ,[GV_Rest_Qty]
           ,[Loading_date]
           ,[Loading_time]
           ,[Loading_Wc]
           ,[Ins_Date]
           ,[Ins_Emp]
           ,[Up_Date]
           ,[Up_Emp])
     VALUES
           (@togvcode
           ,@workorderno
           ,@qty
           ,100
           ,getdate()
           ,getdate()
           ,@wccode
           ,getdate()
           ,@username
           ,getdate()
           ,@username)

UPDATE [dbo].[GV_History]
   SET [Unloading_Qty] = @qty
      ,[Unloading_date] = getdate()
      ,[Unloading_datetime] = getdate()
      ,[Unloading_wc] = @wccode
      ,[Target_GV] = @togvcode
      ,[Up_Date] = getdate()
      ,[Up_Emp] = @username
 WHERE [GV_Code] = @fromgvcode
      ,[Workorderno] = @workorderno
      ,[Unloading_datetime] = null
 UPDATE [dbo].[GV_Current_Status]
   SET [GV_Qty] = @qty
      ,[GV_Rest_Qty] = [GV_Rest_Qty]+1
      ,[Unloading_date] = getdate()
      ,[Unloading_time] = getdate()
      ,[Up_Date] = getdate()
      ,[Up_Emp] = @username
 WHERE [GV_Code] = @fromgvcode
      ,[Workorderno] = @workorderno
      ,[Unloading_time] = null
/*대차 비우기*/
   UPDATE [dbo].[GV_History]
   SET 
      [Clear_Date] = <Clear_Date, date,>
      ,[Clear_Datetime] = <Clear_Datetime, datetime,>
      ,[Clear_Qty] = <Clear_Qty, int,>
      ,[Clear_Cause] = <Clear_Cause, nvarchar(20),>
      ,[Clear_wc] = <Clear_wc, nvarchar(20),>
      ,[Clear_Item] = <Clear_Item, nvarchar(20),>
      ,[Up_Date] = <Up_Date, datetime,>
      ,[Up_Emp] = <Up_Emp, nvarchar(20),>
 WHERE [GV_Code] = <GV_Code, nvarchar(20),>
      AND [Workorderno] = <Workorderno, nvarchar(20),>
