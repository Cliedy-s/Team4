/*대차리스트*/
  SELECT gv.[GV_Code]
      ,gv.[GV_Name]
      ,gv.[GV_Group]
      ,gv.[GV_Status]
      ,gv.[Unloading_Wc]
      ,gv.[Use_YN]
      ,gv.[Ins_Date]
      ,gv.[Ins_Emp]
      ,gv.[Up_Date]
      ,gv.[Up_Emp]
  FROM [GV_Master] as gv
 WHERE 
      gv.[Unloading_Wc] = '여기'
      AND (gv.[GV_Status] = '적재' OR gv.[GV_Status] = '언로딩')
      AND '적재작업지시(소성)' = (SELECT [Wo_Ini_Char] 
                                                FROM [WorkCenter_Master]
                                                 WHERE gv.[Unloading_Wc] = [Wc_Code] );

SELECT TOP(1) gvcs.[Status_Seq]
      ,gvcs.[GV_Code]
      ,gvcs.[Workorderno]
      ,gvcs.[GV_Qty]
      ,gvcs.[GV_Rest_Qty]
      ,gvcs.[Loading_date]
      ,gvcs.[Loading_time]
      ,gvcs.[Loading_Wc]
      ,gvcs.[Unloading_date]
      ,gvcs.[Unloading_time]
      ,gvcs.[In_Time]
      ,gvcs.[Center_Time]
      ,gvcs.[Out_Time]
      ,gvcs.[Ins_Date]
      ,gvcs.[Ins_Emp]
      ,gvcs.[Up_Date]
      ,gvcs.[Up_Emp]
  FROM [GV_Current_Status] as gvcs
  WHERE [GV_Code] = @GV_Code
  ORDER BY gvcs.[Loading_time] DESC;


  -- TODO : 대차 언로딩








  SELECT wo.[Workorderno]
      ,wo.[Item_Code]
      ,wo.[Prd_Qty]
      ,wo.[Prd_Unit]
      ,wo.[Wo_Order]
      ,im.[Item_Name]
      ,wcm.[Wc_Code]
      ,wcm.[Wc_Name]
      ,wcm.[Wc_Group]
      ,wcm.[Process_Code]
      ,gv.[GV_Code]
      ,gv.[GV_Name]
      ,gv.[GV_Group]
  FROM [WorkOrder] as wo 
  JOIN [Item_Master] as im ON im.[Item_Code] = wo.[Item_Code]
  JOIN (SELECT wcm2.[Wc_Code]
      ,wcm2.[Wc_Name]
      ,wcm2.[Wc_Group]
      ,wcm2.[Process_Code] FROM [WorkCenter_Master] as wcm2 WHERE wcm2.[Process_Code]='소성') as wcm ON wo.[Wc_Code] = wcm.[Wc_Code] 
  JOIN (SELECT gv2.[GV_Code]
      ,gv2.[GV_Name]
      ,gv2.[GV_Group]
      ,GetCurrentWorkOrderNo(gv2.[GV_Code]) as WorkorderNo
        FROM [GV_Master] as gv2
        WHERE gv.[Use_YN] = 'Y') as gv ON gv.WorkorderNo = wo.[Workorderno]
  
  
  /*언로딩이 끝나지 않은 대차의 작업번호 가져오는 함수*/
  --GetCurrentWorkOrderNo(@gvcode){
  --SELECT TOP(1) [Workorderno]
  --FROM [GV_History] 
  --WHERE [Loading_Qty] > [Unloading_Qty]+[Clear_Qty] AND [GV_Code] = @gvcode
  --}  RETURN [Workorderno]
  /**/

/*언로딩*/

  UPDATE [dbo].[GV_Current_Status]
   SET 
      [Unloading_date] = '현재 날짜'
      ,[Unloading_time] = '현재 날짜시간'
      ,[Up_Date] = '현재 날짜'
      ,[Up_Emp] = '수정자 이름'
 WHERE [GV_Code] = '대차코드'
      AND [Workorderno] = '작업지시번호'
      AND [Unloading_time] = null;

   UPDATE [dbo].[GV_History]
   SET 
      [Unloading_Qty] = [Unloading_Qty] + '언로딩 수량'
      ,[Unloading_date] = '현재 날짜'
      ,[Unloading_datetime] = '현재 날짜,시간'
      ,[Unloading_wc] = '현재 작업장'
      ,[Up_Date] = '현재 날짜,시간'
      ,[Up_Emp] = '수정자 이름'
 WHERE [GV_Code] = '대차코드'
      AND [Workorderno] = '작업지시번호'
      AND [Unloading_datetime] = null

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
      ,[Workorderno] = <Workorderno, nvarchar(20),>

-- TODO : 소성변경