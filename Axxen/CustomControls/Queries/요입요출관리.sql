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
      [In_Time] = getdate()
      ,[Up_Date] = getdate()
      ,[Up_Emp] = @username
 WHERE [GV_Code] = @gvcode
      AND [Workorderno] = @workorderno
      AND [In_Time] = null;

   UPDATE [dbo].[GV_History]
   SET 
      [In_Time] = getdate()
      ,[Up_Date] = getdate()
      ,[Up_Emp] = @username
 WHERE [GV_Code] = @gvcode
      AND [Workorderno] = @workorderno
      AND [In_Time] = null;

/*요출*/
  UPDATE [dbo].[GV_Current_Status]
   SET 
      [Center_Time] = [In_Time] + DATEDIFF(mm,[In_Time],getdate())
      ,[Out_Time] =  getdate()
      ,[Up_Date] = getdate()
      ,[Up_Emp] = @username
 WHERE [GV_Code] = @gvcode
      AND [Workorderno] = @workorderno ; 

   UPDATE [dbo].[GV_History]
   SET
      [Center_Time] = [In_Time] + DATEDIFF(mm,[In_Time],getdate())
      ,[Out_Time] = getdate()
      ,[Up_Date] = getdate()
      ,[Up_Emp] = @username
 WHERE [GV_Code] = @gvcode
      AND [Workorderno] = @workorderno ;