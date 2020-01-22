/*작업 시작/ 종료때 확인*/
INSERT INTO [Emp_Allocation_History_Detail](
      [User_ID]
      ,[Workorderno]
      ,[Prd_Starttime]
      ,[Prd_Endtime]
      ,[Prd_Qty]
      ,[Ins_Date]
      ,[Ins_Emp]
      ,[Up_Date]
      ,[Up_Emp])
VALUES(
      [User_ID]
      ,[Workorderno]
      ,[Prd_Starttime]
      ,null
      ,[Prd_Qty]
      ,[Ins_Date]
      ,[Ins_Emp]
      ,[Up_Date]
      ,[Up_Emp]);

      
UPDATE [Emp_Allocation_History_Detail] SET
      [Prd_Endtime] = '현재'
	, Up_Date = '현재날짜'
	, Up_Emp = '수정자'
 WHERE 
	[User_ID] = '작업자'
      AND [Workorderno] ='현재 작업번호'
	  AND [Prd_Endtime] = null;