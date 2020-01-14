/*금일 입고 팔레트 목록*/
SELECT gih.[Workorderno]
      ,gih.[Pallet_No]
      ,gih.[In_Date]
      ,gih.[Grade_Code]
      ,gih.[Grade_Detail_Code]
      ,gih.[In_Qty]
      ,gih.[In_YN]
      ,wo.[Workorderno]
      ,wo.[Item_Code]
      ,wo.[Wc_Code]
  FROM [WorkOrder] as wo
  JOIN [Goods_In_History] as gih ON gih.[Workorderno] = wo.[Workorderno]
  WHERE gih.[In_Date] = CAST(GETDATE() AS DATE) AND gih.[In_YN] = 'Y'

/*입고*/


-- TODO : 팔레트