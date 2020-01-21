
  /****** 작업지시현황 ******/
  SELECT wo.[Workorderno]
		,wo.[Wc_Code]
		,wo.[Wo_Status]
		,ds.[User_ID]
		,im.[Item_Code]
		,im.[Item_Name]
		,im.[Item_Unit]
		,wo.[Prd_Qty]
		,wo.[Prd_Starttime]
		,wo.[Prd_Endtime]
		,wcm.[Wo_Ini_Char]
  FROM [TEAM4].[dbo].[WorkOrder] wo
  JOIN wcm.[WorkCenter_Master] as wcm ON wcm.[Wc_Code] = wo.[Wc_Code]
  JOIN [Item_Master] as im ON im.[Item_Code] = wo.[Item_Code]
  JOIN [Emp_Allocation_History_Detail] as ds ON ds.[Workorderno] = wo.[Workorderno]
	WHERE wcm.[Wo_Ini_Char] = '소성'
