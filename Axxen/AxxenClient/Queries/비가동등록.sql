/*비가동 현황*/
SELECT 	
	 nh.Nop_Seq
	, nh.Nop_Date
	, nh.Nop_Happentime
	, nh.Nop_Canceltime
	, nh.Wc_Code
	, nh.Nop_Mi_Code
	, nh.Nop_Type
	, nh.Nop_Time
	, nim.Nop_Mi_Name
	, nam.Nop_Ma_Name
    , wcm.[Wc_Name]
FROM Nop_History as nh
	JOIN Nop_Mi_Master AS nim ON nh.Nop_Mi_Code = nim.Nop_Mi_Code AND nim.Use_YN = 1
	JOIN Nop_Ma_Master AS nam ON nim.Nop_Ma_Code = nam.Nop_Ma_Code AND nam.Use_YN = 1
	JOIN [WorkCenter_Master] as wcm ON wcm.[Wc_Code] = nh.Wc_Code AND wcm.[Use_YN] =1;
/*비가동 사유변경*/
-- popup (COMBOBOX)
SELECT 	
	nim.Nop_Mi_Code
	, nim.Nop_Mi_Name
	, nim.Nop_Ma_Code
	, nim.Remark
	, nim.Ins_Date
	, nim.Ins_Emp
	, nim.Up_Date
	, nim.Up_Emp
	FROM Nop_Mi_Master AS nim
	WHERE nim.Use_YN = 'Y';

SELECT 	
	nam.Nop_Ma_Code
	,nam.Nop_Ma_Name
	,nam.Use_YN
	FROM Nop_Ma_Master AS nam
UPDATE Nop_History 
	SET 
	Nop_Mi_Code = @Nop_Mi_Code
	, Up_Date = '현재'
	, Up_Emp = '수정자'
	WHERE Nop_Seq = @Nop_Seq;
-- TODO : 팔레트