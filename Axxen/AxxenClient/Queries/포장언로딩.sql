/*대차리스트*/
 SELECT tab1.[GV_Code]
      ,tab1.[GV_Name]
      ,tab1.[GV_Group]
      ,tab1.[GV_Status]
      ,tab1.[Use_YN]
      ,tab1.WorkOrderNo
      ,wo.[Item_Code]
      ,wo.[Prd_Qty]
      ,im.[Item_Name]
 FROM (SELECT gv.[GV_Code]
                    ,gv.[GV_Name]
                    ,gv.[GV_Group]
                    ,gv.[GV_Status]
                    ,gv.[Use_YN]
                    ,(SELECT TOP(1) gvcs.[Workorderno] FROM [GV_Current_Status] as gvcs WHERE  gvcs.[GV_Code] =gv.[GV_Code] ORDER BY gvcs.[Loading_time] DESC) as WorkOrderNo
            FROM [GV_Master] as gv
            WHERE 
                  gv.[Unloading_Wc] = '여기'
                  AND (gv.[GV_Status] = '적재' OR gv.[GV_Status] = '언로딩')
                  AND '적재작업지시(소성)' = (SELECT [Wo_Ini_Char] 
                                                            FROM [WorkCenter_Master]
                                                             WHERE gv.[Unloading_Wc] = [Wc_Code]
                  AND gv.[Use_YN] = 1)
             ) as tab1 
                JOIN [WorkOrder] as wo ON tab1.WorkOrderNo = wo.[Workorderno]
                JOIN [Item_Master] as im ON  wo.[Workorderno] = im.[Item_Code];

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
