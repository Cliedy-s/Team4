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



 



