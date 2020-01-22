/*왼쪽 그리드뷰*/
  SELECT gv.[GV_Code]
      ,gv.[GV_Name]
      ,gv.[GV_Group]
      ,gv.[GV_Status]
      ,gv.[Unloading_Wc]
  FROM [GV_Master] as gv
 WHERE '건조대차' = gv.[GV_Group] AND  gv.[GV_Status] = '빈대차' AND gv.[Use_YN]='Y';
 -- GetAllByGV

/*오른쪽 그리드뷰*/
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
	AND gv.[GV_Group] = '성형건조'
	AND wo.[Workorderno] = '현재 작업지시';
 -- GetAllWithLoadingTime

/*특정 대차의 현재 작업지시번호를 가져오는 함수*/
-- TODO : 다른곳에 적용
-- GetCurrentWorkOrderNoByGVCode()
SELECT TOP(1) gvcs.[Workorderno]
  FROM [GV_Current_Status] as gvcs
WHERE gvcs.[GV_Code] = @GVCODE
ORDER BY gvcs.[Status_Seq] DESC;

RETURN gvcs.[Workorderno];

/*로딩*/
UPDATE [WorkOrder] 
SET [In_Qty_Main] = [In_Qty_Main] + @QTY 
WHERE [Workorderno] = '현재 작업지시번호'
