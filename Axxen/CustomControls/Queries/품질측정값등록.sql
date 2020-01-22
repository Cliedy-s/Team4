/*품질규격*/
SELECT 
	ism.Item_Code
	, ism.Process_code
	, ism.Inspect_code
	, ism.Inspect_name
	, ism.Spec_Desc
	, ism.USL 
	, ism.SL
	, ism.LSL 
	, ism.Sample_size
	, ism.Inspect_Unit
	, ism.Use_YN
	, ism.Remark
	FROM Inspect_Spec_Master	AS ism
/*품질이력*/
SELECT 
	 imh,Inspect_measure_seq
	, imh,Item_code
	, imh,Process_code
	, imh,Inspect_code
	, imh,Inspect_date
	, imh,Inspect_datetime
	, imh,Inspect_val
	, imh,Workorderno
	FROM Inspect_Measure_History AS imh
/*입력*/
INSERT INTO Inspect_Measure_History (
	Inspect_measure_seq
	,Item_code
	,Process_code
	,Inspect_code
	,Inspect_date
	,Inspect_datetime
	,Inspect_val
	,Workorderno
	,Ins_Date
	,Ins_Emp
	,Up_Date
	,Up_Emp
	)
	VALUES (
	Inspect_measure_seq
	,Item_code
	,Process_code
	,Inspect_code
	,Inspect_date
	,Inspect_datetime
	,Inspect_val
	,Workorderno
	,Ins_Date
	,Ins_Emp
	,Up_Date
	,Up_Emp
	)
/*삭제*/
DELETE FROM Inspect_Measure_History 
WHERE Inspect_measure_seq = @Inspect_measure_seq
-- TODO : 팔레트