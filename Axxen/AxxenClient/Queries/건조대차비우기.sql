/*건조대차 현황*/
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
  WHERE gv.[Use_YN] = 1 

/*대차비우기*/
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
      ,[Workorderno] = <Workorderno, nvarchar(20),>