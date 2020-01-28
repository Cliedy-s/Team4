/*장착 금형 목록*/
SELECT mold.Mold_Code
,mold.Mold_Name
,mold.Mold_Group
,mold.Mold_Status
,mold.Cum_Shot_Cnt
,mold.Cum_Prd_Qty
,mold.Cum_Time
,mold.Guar_Shot_Cnt
,mold.Purchase_Amt
,mold.In_Date
,mold.Last_Setup_Time
,mold.Wc_Code
,mold.Remark
,mold.Use_YN
FROM Mold_Master as mold
WHERE mold.Wc_Code = '현재작업장코드'
	AND mold.Mold_Status = 'O :  장착'
	AND mold.Use_YN = 1;
/*장착 대상 금형 목록*/
SELECT mold.Mold_Code
,mold.Mold_Name
,mold.Mold_Group
,mold.Mold_Status
,mold.Cum_Shot_Cnt
,mold.Cum_Prd_Qty
,mold.Cum_Time
,mold.Guar_Shot_Cnt
,mold.Purchase_Amt
,mold.In_Date
,mold.Last_Setup_Time
,mold.Wc_Code
,mold.Remark
,mold.Use_YN
FROM Mold_Master as mold
WHERE mold.Wc_Code = '현재작업장코드'
	AND mold.Mold_Status = 'S : 대기'
	AND mold.Use_YN = 1
	AND mold.Cum_Shot_Cnt >= mold.Guar_Shot_Cnt;
/*장착 버튼*/
UPDATE Mold_Master 
SET mold.Wc_Code = '현재 작업장 코드',  mold.Mold_Status = 'O : 장착'
WHERE mold.Mold_Code = '금형코드'
/*탈착 버튼*/
UPDATE Mold_Master 
SET mold.Wc_Code = '',  mold.Mold_Status = 'S : 대기'
WHERE mold.Mold_Code = '금형코드'
