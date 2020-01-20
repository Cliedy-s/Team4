  /*작업지시*/
SELECT wo.[Workorderno]
      ,wo.[Item_Code]
      ,wo.[Wc_Code]
      ,wo.[Plan_Qty]
      ,wo.[Plan_Unit]
      ,wo.[Plan_Date]
      ,wo.[Prd_Date]
      ,wo.[Wo_Status]
      ,wo.[Wo_Order]
      ,wo.[Plan_Starttime]
      ,wo.[Plan_Endtime]
      ,wo.[Prd_Starttime]
      ,wo.[Prd_Endtime]
      ,wo.[In_Qty_Main]
      ,wo.[Out_Qty_Main]
      ,wo.[Prd_Qty]
      ,wo.[Prd_Unit]
      ,wo.[Worker_CloseTime]
      ,wo.[Manager_CloseTime]
      ,wo.[Close_CancelTime]
      ,wo.[Wo_Req_No]
      ,wo.[Req_Seq]
      ,wo.[Mat_LotNo]
      ,wo.[Remark]
      ,wo.[Ins_Date]
      ,wo.[Ins_Emp]
      ,wo.[Up_Date]
      ,wo.[Up_Emp]
  FROM [WorkOrder] as wo
INSERT INTO [dbo].[WorkOrder]
           ([Workorderno]
           ,[Item_Code]
           ,[Wc_Code]
           ,[Plan_Qty]
           ,[Plan_Unit]
           ,[Plan_Date]
           ,[Prd_Date]
           ,[Wo_Status]
           ,[Wo_Order]
           ,[Plan_Starttime]
           ,[Plan_Endtime]
           ,[Prd_Starttime]
           ,[Prd_Endtime]
           ,[In_Qty_Main]
           ,[Out_Qty_Main]
           ,[Prd_Qty]
           ,[Prd_Unit]
           ,[Worker_CloseTime]
           ,[Manager_CloseTime]
           ,[Close_CancelTime]
           ,[Wo_Req_No]
           ,[Req_Seq]
           ,[Mat_LotNo]
           ,[Remark]
           ,[Ins_Date]
           ,[Ins_Emp]
           ,[Up_Date]
           ,[Up_Emp])
     VALUES
           (<Workorderno, nvarchar(20),>
           ,<Item_Code, nvarchar(20),>
           ,<Wc_Code, nvarchar(20),>
           ,<Plan_Qty, int,>
           ,<Plan_Unit, nvarchar(20),>
           ,<Plan_Date, date,>
           ,<Prd_Date, date,>
           ,<Wo_Status, nvarchar(20),>
           ,<Wo_Order, int,>
           ,<Plan_Starttime, datetime,>
           ,<Plan_Endtime, datetime,>
           ,<Prd_Starttime, datetime,>
           ,<Prd_Endtime, datetime,>
           ,<In_Qty_Main, int,>
           ,<Out_Qty_Main, int,>
           ,<Prd_Qty, int,>
           ,<Prd_Unit, nvarchar(20),>
           ,<Worker_CloseTime, datetime,>
           ,<Manager_CloseTime, datetime,>
           ,<Close_CancelTime, datetime,>
           ,<Wo_Req_No, nvarchar(20),>
           ,<Req_Seq, int,>
           ,<Mat_LotNo, nvarchar(10),>
           ,<Remark, nvarchar(100),>
           ,<Ins_Date, datetime,>
           ,<Ins_Emp, nvarchar(20),>
           ,<Up_Date, datetime,>
           ,<Up_Emp, nvarchar(20),>)

  /*품목*/
SELECT im.[Item_Code]
      ,im.[Item_Name]
      ,im.[Item_Name_Eng]
      ,im.[Item_Name_Eng_Alias]
      ,im.[Item_Type]
      ,im.[Item_Spec]
      ,im.[Item_Unit]
      ,im.[Level_1]
      ,im.[Level_2]
      ,im.[Level_3]
      ,im.[Level_4]
      ,im.[Level_5]
      ,im.[Item_Stock]
      ,im.[Lead_Time]
      ,im.[LotSize]
      ,im.[PrdQty_Per_Hour]
      ,im.[PrdQTy_Per_Batch]
      ,im.[Cavity]
      ,im.[Line_Per_Qty]
      ,im.[Shot_Per_Qty]
      ,im.[Dry_GV_Qty]
      ,im.[Heat_GV_Qty]
      ,im.[Remark]
      ,im.[Use_YN]
      ,im.[Ins_Date]
      ,im.[Ins_Emp]
      ,im.[Up_Date]
      ,im.[Up_Emp]
  FROM [Item_Master] as im

  /*작업자 할당*/
SELECT 
	eah.Hist_Seq
	, eah.User_ID
	, eah.Allocation_date
	, eah.Allocation_datetime
	, eah.Release_datetime
	, eah.Ins_Date
	, eah.Ins_Emp
	, eah.Up_Date
	, eah.Up_Emp
FROM Emp_Allocation_History	as eah
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
	, Release_datetime
	, Ins_Date
	, Ins_Emp
	, Up_Date
	, Up_Emp);
SELECT ds.[Detail_Seq]
      ,ds.[User_ID]
      ,ds.[Workorderno]
      ,ds.[Prd_Starttime]
      ,ds.[Prd_Endtime]
      ,ds.[Prd_Qty]
      ,ds.[Ins_Date]
      ,ds.[Ins_Emp]
      ,ds.[Up_Date]
      ,ds.[Up_Emp]
  FROM [Emp_Allocation_History_Detail] as ds
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
	  [Detail_Seq]
      ,[User_ID]
      ,[Workorderno]
      ,[Prd_Starttime]
      ,[Prd_Endtime]
      ,[Prd_Qty]
      ,[Ins_Date]
      ,[Ins_Emp]
      ,[Up_Date]
      ,[Up_Emp]);
/*현재 작업자 인원 할당*/
SELECT 
	ewa.Wc_Code
	, ewa.User_ID
	, ewa.Allocation_datetime
	, ewa.Release_datetime
	, ewa.Ins_Date
	, ewa.Ins_Emp
	, ewa.Up_Date
	, ewa.Up_Emp
FROM Emp_Wc_Allocation AS ewa
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
	, Release_datetime
	, Ins_Date
	, Ins_Emp
	, Up_Date
	, Up_Emp);

  /*대차*/
  SELECT gv.[GV_Code]
      ,gv.[GV_Name]
      ,gv.[GV_Group]
      ,gv.[GV_Status]
      ,gv.[Unloading_Wc]
      ,gv.[Use_YN]
      ,gv.[Ins_Date]
      ,gv.[Ins_Emp]
      ,gv.[Up_Date]
      ,gv.[Up_Emp]
  FROM [GV_Master] as gv

  /* 대차 현황 */
SELECT gvcs.[Status_Seq]
      ,gvcs.[GV_Code]
      ,gvcs.[Workorderno]
      ,gvcs.[GV_Qty]
      ,gvcs.[GV_Rest_Qty]
      ,gvcs.[Loading_date]
      ,gvcs.[Loading_time]
      ,gvcs.[Loading_Wc]
      ,gvcs.[Unloading_date]
      ,gvcs.[Unloading_time]
      ,gvcs.[In_Time]
      ,gvcs.[Center_Time]
      ,gvcs.[Out_Time]
      ,gvcs.[Ins_Date]
      ,gvcs.[Ins_Emp]
      ,gvcs.[Up_Date]
      ,gvcs.[Up_Emp]
  FROM [GV_Current_Status] as gvcs
INSERT INTO [dbo].[GV_Current_Status]
           ([GV_Code]
           ,[Workorderno]
           ,[GV_Qty]
           ,[GV_Rest_Qty]
           ,[Loading_date]
           ,[Loading_time]
           ,[Loading_Wc]
           ,[Unloading_date]
           ,[Unloading_time]
           ,[In_Time]
           ,[Center_Time]
           ,[Out_Time]
           ,[Ins_Date]
           ,[Ins_Emp]
           ,[Up_Date]
           ,[Up_Emp])
     VALUES
           (<GV_Code, nvarchar(20),>
           ,<Workorderno, nvarchar(20),>
           ,<GV_Qty, int,>
           ,<GV_Rest_Qty, int,>
           ,<Loading_date, date,>
           ,<Loading_time, datetime,>
           ,<Loading_Wc, nvarchar(20),>
           ,<Unloading_date, date,>
           ,<Unloading_time, datetime,>
           ,<In_Time, datetime,>
           ,<Center_Time, datetime,>
           ,<Out_Time, datetime,>
           ,<Ins_Date, datetime,>
           ,<Ins_Emp, nvarchar(20),>
           ,<Up_Date, datetime,>
           ,<Up_Emp, nvarchar(20),>);
/* -- UPDATE GV_Current_Status
  UPDATE [dbo].[GV_Current_Status]
   SET [GV_Code] = <GV_Code, nvarchar(20),>
      ,[Workorderno] = <Workorderno, nvarchar(20),>
      ,[GV_Qty] = <GV_Qty, int,>
      ,[GV_Rest_Qty] = <GV_Rest_Qty, int,>
      ,[Loading_date] = <Loading_date, date,>
      ,[Loading_time] = <Loading_time, datetime,>
      ,[Loading_Wc] = <Loading_Wc, nvarchar(20),>
      ,[Unloading_date] = <Unloading_date, date,>
      ,[Unloading_time] = <Unloading_time, datetime,>
      ,[In_Time] = <In_Time, datetime,>
      ,[Center_Time] = <Center_Time, datetime,>
      ,[Out_Time] = <Out_Time, datetime,>
      ,[Ins_Date] = <Ins_Date, datetime,>
      ,[Ins_Emp] = <Ins_Emp, nvarchar(20),>
      ,[Up_Date] = <Up_Date, datetime,>
      ,[Up_Emp] = <Up_Emp, nvarchar(20),>
 WHERE <검색 조건,,>
*/ 
DELETE FROM [dbo].[GV_Current_Status]
      WHERE <검색 조건,,>

  /*대차 이력*/
SELECT gvh.[Hist_Seq]
      ,gvh.[GV_Code]
      ,gvh.[Workorderno]
      ,gvh.[Loading_Date]
      ,gvh.[Loading_Qty]
      ,gvh.[Loading_Wc]
      ,gvh.[In_Time]
      ,gvh.[Center_Time]
      ,gvh.[Out_Time]
      ,gvh.[Unloading_Qty]
      ,gvh.[Unloading_date]
      ,gvh.[Unloading_datetime]
      ,gvh.[Unloading_wc]
      ,gvh.[Target_GV]
      ,gvh.[Clear_Date]
      ,gvh.[Clear_Datetime]
      ,gvh.[Clear_Qty]
      ,gvh.[Clear_Cause]
      ,gvh.[Clear_wc]
      ,gvh.[Clear_Item]
      ,gvh.[Ins_Date]
      ,gvh.[Ins_Emp]
      ,gvh.[Up_Date]
      ,gvh.[Up_Emp]
  FROM gvh.[GV_History]
INSERT INTO [dbo].[GV_History]
           ([GV_Code]
           ,[Workorderno]
           ,[Loading_Date]
           ,[Loading_Qty]
           ,[Loading_Wc]
           ,[In_Time]
           ,[Center_Time]
           ,[Out_Time]
           ,[Unloading_Qty]
           ,[Unloading_date]
           ,[Unloading_datetime]
           ,[Unloading_wc]
           ,[Target_GV]
           ,[Clear_Date]
           ,[Clear_Datetime]
           ,[Clear_Qty]
           ,[Clear_Cause]
           ,[Clear_wc]
           ,[Clear_Item]
           ,[Ins_Date]
           ,[Ins_Emp]
           ,[Up_Date]
           ,[Up_Emp])
     VALUES
           (<GV_Code, nvarchar(20),>
           ,<Workorderno, nvarchar(20),>
           ,<Loading_Date, date,>
           ,<Loading_Qty, int,>
           ,<Loading_Wc, nvarchar(20),>
           ,<In_Time, datetime,>
           ,<Center_Time, datetime,>
           ,<Out_Time, datetime,>
           ,<Unloading_Qty, int,>
           ,<Unloading_date, date,>
           ,<Unloading_datetime, datetime,>
           ,<Unloading_wc, nvarchar(20),>
           ,<Target_GV, nvarchar(20),>
           ,<Clear_Date, date,>
           ,<Clear_Datetime, datetime,>
           ,<Clear_Qty, int,>
           ,<Clear_Cause, nvarchar(20),>
           ,<Clear_wc, nvarchar(20),>
           ,<Clear_Item, nvarchar(20),>
           ,<Ins_Date, datetime,>
           ,<Ins_Emp, nvarchar(20),>
           ,<Up_Date, datetime,>
           ,<Up_Emp, nvarchar(20),>)
/* -- UPDATE GV_History
   UPDATE [dbo].[GV_History]
   SET [GV_Code] = <GV_Code, nvarchar(20),>
      ,[Workorderno] = <Workorderno, nvarchar(20),>
      ,[Loading_Date] = <Loading_Date, date,>
      ,[Loading_Qty] = <Loading_Qty, int,>
      ,[Loading_Wc] = <Loading_Wc, nvarchar(20),>
      ,[In_Time] = <In_Time, datetime,>
      ,[Center_Time] = <Center_Time, datetime,>
      ,[Out_Time] = <Out_Time, datetime,>
      ,[Unloading_Qty] = <Unloading_Qty, int,>
      ,[Unloading_date] = <Unloading_date, date,>
      ,[Unloading_datetime] = <Unloading_datetime, datetime,>
      ,[Unloading_wc] = <Unloading_wc, nvarchar(20),>
      ,[Target_GV] = <Target_GV, nvarchar(20),>
      ,[Clear_Date] = <Clear_Date, date,>
      ,[Clear_Datetime] = <Clear_Datetime, datetime,>
      ,[Clear_Qty] = <Clear_Qty, int,>
      ,[Clear_Cause] = <Clear_Cause, nvarchar(20),>
      ,[Clear_wc] = <Clear_wc, nvarchar(20),>
      ,[Clear_Item] = <Clear_Item, nvarchar(20),>
      ,[Ins_Date] = <Ins_Date, datetime,>
      ,[Ins_Emp] = <Ins_Emp, nvarchar(20),>
      ,[Up_Date] = <Up_Date, datetime,>
      ,[Up_Emp] = <Up_Emp, nvarchar(20),>
 WHERE <검색 조건,,>
*/
DELETE FROM [dbo].[GV_History]
      WHERE <검색 조건,,>

  /*팔레트*/
SELECT gih.[Workorderno]
      ,gih.[Pallet_No]
      ,gih.[Barcode_No]
      ,gih.[In_Date]
      ,gih.[Grade_Code]
      ,gih.[Grade_Detail_Code]
      ,gih.[Size_Code]
      ,gih.[Grade_Detail_Name]
      ,gih.[In_Qty]
      ,gih.[Upload_Flag]
      ,gih.[Update_YN]
      ,gih.[F_In_Qty]
      ,gih.[Closed_Time]
      ,gih.[Cancel_Time]
      ,gih.[Print_Date]
      ,gih.[In_YN]
      ,gih.[Remark]
      ,gih.[Ins_Date]
      ,gih.[Ins_Emp]
      ,gih.[Up_Date]
      ,gih.[Up_Emp]
  FROM [Goods_In_History] as gih

  /*작업장*/
SELECT wcm.[Wc_Code]
      ,wcm.[Wc_Name]
      ,wcm.[Wc_Group]
      ,wcm.[Process_Code]
      ,wcm.[Auto_Wo_YN]
      ,wcm.[Auto_Start_YN]
      ,wcm.[ERP_IF_YN]
      ,wcm.[Wo_Status]
      ,wcm.[Nop_Auto_YN]
      ,wcm.[Nop_Check_Time]
      ,wcm.[Last_Cnt_Time]
      ,wcm.[Gas_UseYN]
      ,wcm.[Prd_Req_Type]
      ,wcm.[Pallet_YN]
      ,wcm.[Item_Code]
      ,wcm.[Prd_Unit]
      ,wcm.[Mold_Setup_YN]
      ,wcm.[In_Qty_Auto_YN]
      ,wcm.[Wo_Ini_Char]
      ,wcm.[Use_YN]
      ,wcm.[Remark]
      ,wcm.[Ins_Date]
      ,wcm.[Ins_Emp]
      ,wcm.[Up_Date]
      ,wcm.[Up_Emp]
  FROM [WorkCenter_Master] as wcm

  /*팔래트*/
  SELECT pal.[Pallet_No]
      ,pal.[Workorderno]
      ,pal.[Barcode_No]
      ,pal.[Grade_Code]
      ,pal.[Grade_Detail_Code]
      ,pal.[Grade_Detail_Name]
      ,pal.[In_Qty]
      ,pal.[CurrentQty]
      ,pal.[IsActive]
  FROM [Pallet_Master] as pal
 INSERT INTO [dbo].[Pallet_Master]
           ([Pallet_No]
           ,[Workorderno]
           ,[Barcode_No]
           ,[Grade_Code]
           ,[Grade_Detail_Code]
           ,[Grade_Detail_Name]
           ,[In_Qty]
           ,[CurrentQty]
           ,[IsActive])
     VALUES
           (<Pallet_No, nvarchar(10),>
           ,<Workorderno, nvarchar(20),>
           ,<Barcode_No, nvarchar(20),>
           ,<Grade_Code, nvarchar(20),>
           ,<Grade_Detail_Code, nvarchar(20),>
           ,<Grade_Detail_Name, nvarchar(100),>
           ,<In_Qty, int,>
           ,<CurrentQty, int,>
           ,<IsActive, bit,>)

/*포장 실적*/
SELECT [Workorderno]
      ,[Pallet_No]
      ,[Barcode_No]
      ,[In_Date]
      ,[Grade_Code]
      ,[Grade_Detail_Code]
      ,[Size_Code]
      ,[Grade_Detail_Name]
      ,[In_Qty]
      ,[Upload_Flag]
      ,[Update_YN]
      ,[F_In_Qty]
      ,[Closed_Time]
      ,[Cancel_Time]
      ,[Print_Date]
      ,[In_YN]
      ,[Remark]
      ,[Ins_Date]
      ,[Ins_Emp]
      ,[Up_Date]
      ,[Up_Emp]
  FROM [Goods_In_History]
INSERT INTO [dbo].[Goods_In_History]
           ([Workorderno]
           ,[Pallet_No]
           ,[Barcode_No]
           ,[In_Date]
           ,[Grade_Code]
           ,[Grade_Detail_Code]
           ,[Size_Code]
           ,[Grade_Detail_Name]
           ,[In_Qty]
           ,[Upload_Flag]
           ,[Update_YN]
           ,[F_In_Qty]
           ,[Closed_Time]
           ,[Cancel_Time]
           ,[Print_Date]
           ,[In_YN]
           ,[Remark]
           ,[Ins_Date]
           ,[Ins_Emp]
           ,[Up_Date]
           ,[Up_Emp])
     VALUES
           (<Workorderno, nvarchar(20),>
           ,<Pallet_No, nvarchar(10),>
           ,<Barcode_No, nvarchar(20),>
           ,<In_Date, date,>
           ,<Grade_Code, nvarchar(20),>
           ,<Grade_Detail_Code, nvarchar(20),>
           ,<Size_Code, nvarchar(20),>
           ,<Grade_Detail_Name, nvarchar(100),>
           ,<In_Qty, int,>
           ,<Upload_Flag, nchar(1),>
           ,<Update_YN, nchar(1),>
           ,<F_In_Qty, int,>
           ,<Closed_Time, datetime,>
           ,<Cancel_Time, datetime,>
           ,<Print_Date, datetime,>
           ,<In_YN, nchar(1),>
           ,<Remark, nvarchar(100),>
           ,<Ins_Date, datetime,>
           ,<Ins_Emp, nvarchar(20),>
           ,<Up_Date, datetime,>
           ,<Up_Emp, nvarchar(20),>)
/* --UPDATE GOODS_IN_HISTORY
UPDATE [dbo].[Goods_In_History]
   SET [Workorderno] = <Workorderno, nvarchar(20),>
      ,[Pallet_No] = <Pallet_No, nvarchar(10),>
      ,[Barcode_No] = <Barcode_No, nvarchar(20),>
      ,[In_Date] = <In_Date, date,>
      ,[Grade_Code] = <Grade_Code, nvarchar(20),>
      ,[Grade_Detail_Code] = <Grade_Detail_Code, nvarchar(20),>
      ,[Size_Code] = <Size_Code, nvarchar(20),>
      ,[Grade_Detail_Name] = <Grade_Detail_Name, nvarchar(100),>
      ,[In_Qty] = <In_Qty, int,>
      ,[Upload_Flag] = <Upload_Flag, nchar(1),>
      ,[Update_YN] = <Update_YN, nchar(1),>
      ,[F_In_Qty] = <F_In_Qty, int,>
      ,[Closed_Time] = <Closed_Time, datetime,>
      ,[Cancel_Time] = <Cancel_Time, datetime,>
      ,[Print_Date] = <Print_Date, datetime,>
      ,[In_YN] = <In_YN, nchar(1),>
      ,[Remark] = <Remark, nvarchar(100),>
      ,[Ins_Date] = <Ins_Date, datetime,>
      ,[Ins_Emp] = <Ins_Emp, nvarchar(20),>
      ,[Up_Date] = <Up_Date, datetime,>
      ,[Up_Emp] = <Up_Emp, nvarchar(20),>
 WHERE <검색 조건,,>
 */
 DELETE FROM [Goods_In_History]
      WHERE <검색 조건,,>

/*금형*/
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
,mold.Ins_Date
,mold.Ins_Emp
,mold.Up_Date
,mold.Up_Emp
FROM Mold_Master as mold

/*사용자*/
SELECT 
	um.User_ID
	, um.User_Name
	, um.User_PW
	, um.Customer_Code
	, um.DefaultLanguage
	, um.User_Type
	, um.Price_Visible_YN
	, um.IP_Security_YN
	, um.Pw_Reset_Count
	, um.Default_Screen_Code
	, um.Default_Process_Code
	, um.Monitoring_YN
	, um.Use_YN
	, um.S01
	, um.S02
	, um.S03
	, um.S04
	, um.S05
	, um.S06
	, um.S07
	, um.S08
	, um.S09
	, um.S10
	, um.S11
	, um.S12
	, um.Ins_Date
	, um.Ins_Emp
	, um.Up_Date
	, um.Up_Emp
FROM User_Master AS um

/*공정조건*/
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
	, csm.Ins_Date
	, csm.Ins_Emp
	, csm.Up_Date
	, csm.Up_Emp
	FROM Condition_Spec_Master	AS csm
INSERT Condition_Spec_Master (
	Item_Code
	,Wc_Code
	,Condition_Code
	,Condition_Name
	,Spec_Desc
	,SL 
	,USL 
	,LSL 
	,Condition_Unit
	,Condition_Group
	,Remark
	,Ins_Date
	,Ins_Emp
	,Up_Date
	,Up_Emp
	)
	VALUES(
	Item_Code
	,Wc_Code
	,Condition_Code
	,Condition_Name
	,Spec_Desc
	,SL 
	,USL 
	,LSL 
	,Condition_Unit
	,Condition_Group
	,Remark
	,Ins_Date
	,Ins_Emp
	,Up_Date
	,Up_Emp
	)

/*공정조건 이력*/
SELECT 
	cmh.Condition_measure_seq
	, cmh.Item_code
	, cmh.Wc_Code
	, cmh.Condition_Code
	, cmh.Condition_Date
	, cmh.Condition_Datetime
	, cmh.Condition_Val
	, cmh.Workorderno
	, cmh.Ins_Date
	, cmh.Ins_Emp
	, cmh.Up_Date
	, cmh.Up_Emp
	FROM Condition_Measure_History AS cmh
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
DELETE FROM Condition_Measure_History
WHERE Condition_measure_seq = @Condition_measure_seq
/*검사항목규격설정*/
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
	, ism.Ins_Date
	, ism.Ins_Emp
	, ism.Up_Date
	, ism.Up_Emp
	FROM Inspect_Spec_Master	AS ism
INSERT INTO Inspect_Spec_Master (	
	Item_Code
	,Process_code
	,Inspect_code
	,Inspect_name
	,Spec_Desc
	,USL 
	,SL
	,LSL 
	,Sample_size
	,Inspect_Unit
	,Use_YN
	,Remark
	,Ins_Date
	,Ins_Emp
	,Up_Date
	,Up_Emp
	)
	VALUES (	
	Item_Code
	,Process_code
	,Inspect_code
	,Inspect_name
	,Spec_Desc
	,USL 
	,SL
	,LSL 
	,Sample_size
	,Inspect_Unit
	,Use_YN
	,Remark
	,Ins_Date
	,Ins_Emp
	,Up_Date
	,Up_Emp
	)
/*공정검사 측정이력*/
SELECT 
	 imh,Inspect_measure_seq
	, imh,Item_code
	, imh,Process_code
	, imh,Inspect_code
	, imh,Inspect_date
	, imh,Inspect_datetime
	, imh,Inspect_val
	, imh,Workorderno
	, imh,Ins_Date
	, imh,Ins_Emp
	, imh,Up_Date
	, imh,Up_Emp
	FROM Inspect_Measure_History AS imh
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
DELETE FROM Inspect_Measure_History 
WHERE Inspect_measure_seq = @Inspect_measure_seq

/*비가동 대분류*/
SELECT 	
	nam.Nop_Ma_Code
	,nam.Nop_Ma_Name
	,nam.Use_YN
	,nam.Ins_Date
	,nam.Ins_Emp
	,nam.Up_Date
	,nam.Up_Emp
	FROM Nop_Ma_Master AS nam
/*상세분류*/
SELECT 	
	nim.Nop_Mi_Code
	, nim.Nop_Mi_Name
	, nim.Nop_Ma_Code
	, nim.Use_YN
	, nim.Remark
	, nim.Ins_Date
	, nim.Ins_Emp
	, nim.Up_Date
	, nim.Up_Emp
	FROM Nop_Mi_Master AS nim
/*비가동 발생이력*/
SELECT 	
	 nh.Nop_Seq
	, nh.Nop_Date
	, nh.Nop_Happentime
	, nh.Nop_Canceltime
	, nh.Wc_Code
	, nh.Nop_Mi_Code
	, nh.Nop_Type
	, nh.Nop_Time
	, nh.Remark
	, nh.Ins_Date
	, nh.Ins_Emp
	, nh.Up_Date
	, nh.Up_Emp
FROM Nop_History as nh




