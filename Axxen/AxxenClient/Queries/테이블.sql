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
  FROM wcm.[WorkCenter_Master] as wcm

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
  FROM [dbo].[Goods_In_History]
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
 DELETE FROM [dbo].[Goods_In_History]
      WHERE <검색 조건,,>

















