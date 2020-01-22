/*요입현황*/
SELECT gvcs.[Status_Seq]
      ,gvcs.[GV_Code]
      ,gvcs.[Workorderno]
      ,gvcs.[Loading_date]
      ,gvcs.[Loading_time]
      ,gvcs.[Loading_Wc]
      ,gvcs.[In_Time]
      ,gvcs.[Center_Time]
      ,gvcs.[Out_Time]
      ,gv.[GV_Name]
      ,wo.[Wc_Code]
      ,wo.[In_Qty_Main]
  FROM [GV_Current_Status] as gvcs
	  JOIN [GV_Master] as gv ON gv.[GV_Code] = gvcs.[GV_Code] AND gv.[Use_YN] = 'Y'
	  JOIN [WorkOrder] as wo ON gvcs.[Workorderno] = wo.[Workorderno]
WHERE gv.[GV_Group] = '소성대차'
	AND wo.[Wc_Code] = '현재 작업장 코드';
/*요입*/
  UPDATE [dbo].[GV_Current_Status]
   SET 
      [In_Time] = '현재'
      ,[Up_Date] = <Up_Date, datetime,>
      ,[Up_Emp] = <Up_Emp, nvarchar(20),>
 WHERE [GV_Code] = <GV_Code, nvarchar(20),>
      AND [Workorderno] = <Workorderno, nvarchar(20),>

   UPDATE [dbo].[GV_History]
   SET 
      [In_Time] = '현재'
      ,[Up_Date] = <Up_Date, datetime,>
      ,[Up_Emp] = <Up_Emp, nvarchar(20),>
 WHERE [GV_Code] = <GV_Code, nvarchar(20),>
      AND [Workorderno] = <Workorderno, nvarchar(20),>

/*요출*/
  UPDATE [dbo].[GV_Current_Status]
   SET 
      [Center_Time] = '현재 - ((현재 - INTIME)/2)'
      ,[Out_Time] =  '현재'
      ,[Up_Date] = <Up_Date, datetime,>
      ,[Up_Emp] = <Up_Emp, nvarchar(20),>
 WHERE [GV_Code] = <GV_Code, nvarchar(20),>
      AND [Workorderno] = <Workorderno, nvarchar(20),>

   UPDATE [dbo].[GV_History]
   SET
      [Center_Time] = '현재 - ((현재 - INTIME)/2)'
      ,[Out_Time] =  '현재'
      ,[Up_Date] = <Up_Date, datetime,>
      ,[Up_Emp] = <Up_Emp, nvarchar(20),>
 WHERE  [GV_Code] = <GV_Code, nvarchar(20),>
      AND [Workorderno] = <Workorderno, nvarchar(20),>