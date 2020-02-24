delete from workorder;
delete from GV_Current_Status;
delete from GV_History;
delete from Inspect_Measure_History;
delete from Condition_Measure_History;
delete from Time_Production_History_Day;
delete from Goods_In_History;
delete from Emp_Allocation_History_Detail;
delete from Emp_Allocation_History;
delete from Emp_Wc_Allocation;
delete from Mold_Use_History;
update Mold_Master set Cum_Shot_Cnt = 0
						,Cum_Prd_Qty	=0
						,Cum_Time	=0
						;
delete from Work_History;