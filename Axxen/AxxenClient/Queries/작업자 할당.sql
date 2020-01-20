/*할당 작업자*/
SELECT 
	ewa.Wc_Code
	, ewa.[User_ID]
	, ewa.Allocation_datetime
	, um.[User_ID]
	, um.[User_Name]
FROM Emp_Wc_Allocation AS ewa
	JOIN User_Master AS um ON ewa.[User_ID] = um.[User_ID]
	WHERE ewa.Wc_Code = '현재 작업장' AND ewa.Release_datetime = null;

/*할당 대상 작업자*/
SELECT 
	um.User_ID
	, um.User_Name
	, um.Default_Process_Code
	, wcm2.[Wc_Name]
FROM User_Master AS um
  RIGHT OUTER JOIN Emp_Wc_Allocation AS ewa ON ewa.User_ID = um.User_ID AND ewa.Release_datetime = null
  JOIN [WorkCenter_Master] as wcm ON um.Default_Process_Code = wcm.[Process_Code]
  JOIN [WorkCenter_Master] as wcm2 ON wcm2.[Wc_Code] = ewa.Wc_Code
	WHERE um.Use_YN = 1
		AND wcm.[Wc_Code] = '현재 작업장코드';
/*작업자 할당*/
INSERT INTO Emp_Allocation_History(
	User_ID
	, Allocation_date
	, Allocation_datetime
	, Release_datetime
	, Ins_Date
	, Ins_Emp
	, Up_Date
	, Up_Emp)
	VALUES(
	User_ID
	, Allocation_date
	, Allocation_datetime
	, null
	, Ins_Date
	, Ins_Emp
	, Up_Date
	, Up_Emp);
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
INSERT INTO Emp_Wc_Allocation (
	Wc_Code
	, User_ID
	, Allocation_datetime
	, Release_datetime
	, Ins_Date
	, Ins_Emp
	, Up_Date
	, Up_Emp
	)	
	VALUES(
	Wc_Code
	, User_ID
	, Allocation_datetime
	, null
	, Ins_Date
	, Ins_Emp
	, Up_Date
	, Up_Emp);


/*작업자 해제*/
UPDATE Emp_Allocation_History SET 
	 Release_datetime = '현재'
	, Up_Date = '현재날짜'
	, Up_Emp = '수정자'
WHERE 
	Release_datetime = null 
	AND User_ID = '작업자'

UPDATE [Emp_Allocation_History_Detail] SET
      [Prd_Endtime] = '현재'
	, Up_Date = '현재날짜'
	, Up_Emp = '수정자'
 WHERE 
	[User_ID] = '작업자'
      AND [Workorderno] ='현재 작업번호'
	  AND [Prd_Endtime] = null;
	
UPDATE Emp_Wc_Allocation SET
	 Release_datetime = '현재'
	, Up_Date = '현재날짜'
	, Up_Emp = '수정자'
 WHERE 
	 Release_datetime =null
	AND Wc_Code = '현재 작업장 번호'
	AND User_ID = '작업자'
/*작업자 전체 해제*/

-- 위 해제를 프로시저로 생성해서 STRING으로 IN하기 (작업자, 작업장 번호 전달)