
  /****** 작업지시현황 ******/
  SELECT wo.[Workorderno]
    ,wo.[Wo_Status]
    ,ds.[User_ID]
    , im.[Item_Code]
      ,im.[Item_Name]
      ,im.[Item_Unit]
      ,wo.[Prd_Qty]
      ,wo.[Prd_Starttime]
      ,wo.[Prd_Endtime]
  FROM [TEAM4].[dbo].[WorkOrder] wo
  JOIN [Item_Master] as im ON im.[Item_Code] = wo.[Item_Code]
  JOIN [Emp_Allocation_History_Detail] as ds ON ds.[Workorderno] = wo.[Workorderno];

  -- TODO : 작업장 코드 별로 수정