/*측정항목*/
SELECT 
	 csm.Item_Code
	, csm.Wc_Code
	, csm.Condition_Code
	, csm.Condition_Name
	, csm.Spec_Desc
	, csm.SL 
	, csm.USL 
	, csm.LSL 
	, csm.Condition_Unit
	, csm.Condition_Group
	, csm.Remark
	FROM Condition_Spec_Master	AS csm;
/*측정그룹*/
SELECT 
	cmh.Condition_measure_seq
	, cmh.Item_code
	, cmh.Wc_Code
	, cmh.Condition_Code
	, cmh.Condition_Date
	, cmh.Condition_Datetime
	, cmh.Condition_Val
	, cmh.Workorderno
	FROM Condition_Measure_History AS cmh
	WHERE cmh.Condition_Code = @Condition_Code;
/*입력*/
INSERT INTO Condition_Measure_History (
		Item_code
		,Wc_Code
		,Condition_Code
		,Condition_Date
		,Condition_Datetime
		,Condition_Val
		,Workorderno
		,Ins_Date
		,Ins_Emp
		,Up_Date
		,Up_Emp
	)
	VALUES (
		Item_code
		,Wc_Code
		,Condition_Code
		,Condition_Date
		,Condition_Datetime
		,Condition_Val
		,Workorderno
		,Ins_Date
		,Ins_Emp
		,Up_Date
		,Up_Emp
	)

/*삭제*/
DELETE FROM Condition_Measure_History
WHERE Condition_measure_seq = @Condition_measure_seq