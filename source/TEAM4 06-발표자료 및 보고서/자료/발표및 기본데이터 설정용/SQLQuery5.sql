select * from Condition_Measure_History;

select * from Inspect_Spec_Master;

INSERT INTO Inspect_Spec_Master
VALUES
('IC0004'	,'PC10002'	,'ES20002'	,'성형너비'		,NULL	,15.0000	,10.0000	,3.0000	,10	,'mm'		,'Y','성형너비검사'		,NULL,	NULL,	NULL,	NULL	 ),
('IC0004'	,'PC10002'	,'ES20003'	,'성형두께'		,NULL	,14.0000	,12.0000	,3.0000	,10	,'mm'		,'Y','성형두께검사'		,NULL,	NULL,	NULL,	NULL	 ),
('IC0004'	,'PC10002'	,'ES20004'	,'성형진공압'	,NULL	,21.0000	,11.0000	,3.0000	,10	,'atm'		,'Y','성형진공압검사'	,NULL,	NULL,	NULL,	NULL	),
('IC0004'	,'PC10002'	,'ES20005'	,'성형성형압'	,NULL	,23.0000	,16.0000	,3.0000	,10	,'atm'		,'Y','성형성형압검사'	,NULL,	NULL,	NULL,	NULL	),
('IC0004'	,'PC10003'	,'ES30001'	,'건조길이'		,NULL	,10.0000	,5.0000		,3.0000	,10	,'mm'		,'Y','건조길이검사'		,NULL,	NULL,	NULL,	NULL	 ),
('IC0004'	,'PC10003'	,'ES30002'	,'건조너비'		,NULL	,12.0000	,6.0000		,3.0000	,10	,'mm'		,'Y','건조너비검사'		,NULL,	NULL,	NULL,	NULL	 ),
('IC0004'	,'PC10003'	,'ES30003'	,'건조두께'		,NULL	,16.0000	,7.0000		,3.0000	,10	,'mm'		,'Y','건조두께검사'		,NULL,	NULL,	NULL,	NULL	 ),
('IC0004'	,'PC10004'	,'ES40001'	,'소성길이'		,NULL	,19.0000	,10.0000	,3.0000	,10	,'mm'		,'Y','소성길이검사'		,NULL,	NULL,	NULL,	NULL	 ),
('IC0004'	,'PC10004'	,'ES40002'	,'소성너비'		,NULL	,12.0000	,10.0000	,3.0000	,10	,'mm'		,'Y','소성너비검사'		,NULL,	NULL,	NULL,	NULL	 ),
('IC0004'	,'PC10004'	,'ES40003'	,'소성두께'		,NULL	,11.0000	,10.0000	,3.0000	,10	,'mm'		,'Y','소성두께검사'		,NULL,	NULL,	NULL,	NULL	 ),
('IC0004'	,'PC10005'	,'ES50001'	,'포장너비'		,NULL	,100.0000	,50.0000	,3.0000	,10	,'mm'		,'Y','포장너비검사'		,NULL,	NULL,	NULL,	NULL	 ),
('IC0004'	,'PC10005'	,'ES50002'	,'포장길이'		,NULL	,15.0000	,8.0000		,3.0000	,10	,'mm'		,'Y','포장길이검사'		,NULL,	NULL,	NULL,	NULL	 ),
('IC0004'	,'PC10005'	,'ES50003'	,'포장두께'		,NULL	,17.0000	,6.0000		,3.0000	,10	,'mm'		,'Y','포장두께검사'		,NULL,	NULL,	NULL,	NULL	 );
																											   
																											   DELETE FROM Inspect_Spec_Master WHERE Item_Code = 'IC0004'

SELECT * FROM WorkOrder;

INSERT INTO Inspect_Measure_History
SELECT 'IC0001', 'PC10003', Inspect_code, GETDATE(), GETDATE(), 10, 'WK200220010443', GETDATE(), 'master', getdate(), 'master'  FROM Inspect_Spec_Master WHERE Inspect_name LIKE '건조%';

SELECT * FROM Inspect_Measure_History;

select * from Item_Master;


update GV_Master set GV_Status = '빈대차' where GV_Code= 'GV30001'
select * from GV_Master;
EXEC GetGVCurrentStatus;