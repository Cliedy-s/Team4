select * from Condition_Measure_History;

select * from Inspect_Spec_Master;

INSERT INTO Inspect_Spec_Master
VALUES
('IC0004'	,'PC10002'	,'ES20002'	,'�����ʺ�'		,NULL	,15.0000	,10.0000	,3.0000	,10	,'mm'		,'Y','�����ʺ�˻�'		,NULL,	NULL,	NULL,	NULL	 ),
('IC0004'	,'PC10002'	,'ES20003'	,'�����β�'		,NULL	,14.0000	,12.0000	,3.0000	,10	,'mm'		,'Y','�����β��˻�'		,NULL,	NULL,	NULL,	NULL	 ),
('IC0004'	,'PC10002'	,'ES20004'	,'����������'	,NULL	,21.0000	,11.0000	,3.0000	,10	,'atm'		,'Y','���������а˻�'	,NULL,	NULL,	NULL,	NULL	),
('IC0004'	,'PC10002'	,'ES20005'	,'����������'	,NULL	,23.0000	,16.0000	,3.0000	,10	,'atm'		,'Y','���������а˻�'	,NULL,	NULL,	NULL,	NULL	),
('IC0004'	,'PC10003'	,'ES30001'	,'��������'		,NULL	,10.0000	,5.0000		,3.0000	,10	,'mm'		,'Y','�������̰˻�'		,NULL,	NULL,	NULL,	NULL	 ),
('IC0004'	,'PC10003'	,'ES30002'	,'�����ʺ�'		,NULL	,12.0000	,6.0000		,3.0000	,10	,'mm'		,'Y','�����ʺ�˻�'		,NULL,	NULL,	NULL,	NULL	 ),
('IC0004'	,'PC10003'	,'ES30003'	,'�����β�'		,NULL	,16.0000	,7.0000		,3.0000	,10	,'mm'		,'Y','�����β��˻�'		,NULL,	NULL,	NULL,	NULL	 ),
('IC0004'	,'PC10004'	,'ES40001'	,'�Ҽ�����'		,NULL	,19.0000	,10.0000	,3.0000	,10	,'mm'		,'Y','�Ҽ����̰˻�'		,NULL,	NULL,	NULL,	NULL	 ),
('IC0004'	,'PC10004'	,'ES40002'	,'�Ҽ��ʺ�'		,NULL	,12.0000	,10.0000	,3.0000	,10	,'mm'		,'Y','�Ҽ��ʺ�˻�'		,NULL,	NULL,	NULL,	NULL	 ),
('IC0004'	,'PC10004'	,'ES40003'	,'�Ҽ��β�'		,NULL	,11.0000	,10.0000	,3.0000	,10	,'mm'		,'Y','�Ҽ��β��˻�'		,NULL,	NULL,	NULL,	NULL	 ),
('IC0004'	,'PC10005'	,'ES50001'	,'����ʺ�'		,NULL	,100.0000	,50.0000	,3.0000	,10	,'mm'		,'Y','����ʺ�˻�'		,NULL,	NULL,	NULL,	NULL	 ),
('IC0004'	,'PC10005'	,'ES50002'	,'�������'		,NULL	,15.0000	,8.0000		,3.0000	,10	,'mm'		,'Y','������̰˻�'		,NULL,	NULL,	NULL,	NULL	 ),
('IC0004'	,'PC10005'	,'ES50003'	,'����β�'		,NULL	,17.0000	,6.0000		,3.0000	,10	,'mm'		,'Y','����β��˻�'		,NULL,	NULL,	NULL,	NULL	 );
																											   
																											   DELETE FROM Inspect_Spec_Master WHERE Item_Code = 'IC0004'

SELECT * FROM WorkOrder;

INSERT INTO Inspect_Measure_History
SELECT 'IC0001', 'PC10003', Inspect_code, GETDATE(), GETDATE(), 10, 'WK200220010443', GETDATE(), 'master', getdate(), 'master'  FROM Inspect_Spec_Master WHERE Inspect_name LIKE '����%';

SELECT * FROM Inspect_Measure_History;

select * from Item_Master;


update GV_Master set GV_Status = '�����' where GV_Code= 'GV30001'
select * from GV_Master;
EXEC GetGVCurrentStatus;