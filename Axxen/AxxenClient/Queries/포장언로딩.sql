/*대차리스트*/

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
  
  
  /*언로딩 되지않은 대차의 작업번호 가져오는 함수*/
  --GetCurrentWorkOrderNo(@gvcode){
  --SELECT TOP(1) gvcs.[Workorderno]
  --FROM [GV_Current_Status] as gvcs 
  --WHERE gvcs.[Unloading_time] = NULL AND gv.[GV_Code] = @gvcode
  --}  RETURN gvcs.[Workorderno]
  /**/


  

/*언로딩*/

/*대차 비우기*/

-- TODO : 소성변경