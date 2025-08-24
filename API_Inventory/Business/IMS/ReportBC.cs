using API_Inventory.Interface.IMS;
using API_Inventory.Models.Entities.IMS;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace API_Inventory.Business.IMS
{
    public class ReportBC : IReport
    {
        private readonly IConfiguration configuration;
        private readonly string? connectionString;

        public ReportBC(IConfiguration config)
        {
            configuration = config;
            connectionString = configuration.GetConnectionString("MSSQLInventoryConnection");
        }

        DailyReportRes IReport.GetDailyReportBC(DailyReportReq req) 
        {
            DailyReportRes dailyReportRes = new DailyReportRes();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {

      //              string strSQL = @"
      //                  SET NOCOUNT ON;
      //                  /* Drop temporary tables if they exist */
      //                  DECLARE @tempTables TABLE (TableName NVARCHAR(4000));
      //                  INSERT INTO @tempTables (TableName)
      //                  VALUES 
      //                      ('#dataProducts'),
      //                      ('#dataSummaryProducts'),
      //                      ('#dataLastDay'),
      //                      ('#dataCheckingQty'),
      //                      ('#dataLastCheckingQty'),
      //                      ('#dataLastBroughtSumTack'),
      //                      ('#overallSummaryProduct');
      //                  DECLARE @strSQL NVARCHAR(MAX) = '';
      //                  SELECT @strSQL = @strSQL + 'IF OBJECT_ID(''tempdb..' + TableName + ''') IS NOT NULL DROP TABLE ' + TableName + '; '
      //                  FROM @tempTables;
      //                  EXEC sp_executesql @strSQL;                                      

      //                  DECLARE @RefDate DATE = (
      //                      SELECT MinDate
      //                      FROM [dbo].[TbTDocumntFirstDate] (NOLOCK)
      //                      WHERE StorehouseListID = {0}
      //                  );

      //                  /* STEP 1: เตรียมข้อมูลสินค้า */
      //                  WITH CTE_dataProductsPrice AS (
						//	SELECT ProductCode, Price, IsPremium
						//	FROM (
						//		SELECT b.ProductCode, b.Price, b.IsPremium,
						//			ROW_NUMBER() OVER (PARTITION BY b.ProductCode
						//								ORDER BY COALESCE(a.CreatedDate, a.UpdatedDate) DESC) AS rn
						//		FROM [dbo].[TbDocuments] a 
						//		INNER JOIN [dbo].[TbProductTransactions] b WITH (NOLOCK) ON a.DocID = b.DocID
						//		WHERE DocType = 9 
						//		AND b.Price IS NOT NULL
						//		AND b.StorehouseListID = {0}
						//	) x
						//	WHERE rn = 1
						//)

      //                  SELECT g.WarehouseID, g.WarehouseCode, g.WarehouseName, b.StorehouseListID, e.StorehouseID, 
      //                      f.StorehouseCode, f.StorehouseName, l.StorehouseTypeName, k.BusinessUnitName, m.BrandHoldingID, 
      //                      n.BrandHoldingName, a.BrandID, a.BrandCode, a.BrandName, a.CategoryID, a.CategoryName, a.SubCategoryID,
      //                      a.SubCategoryCode, a.SubCategoryName, a.ProductCode, a.ProductName, a.BaseUnit, a.BaseUnitName,
      //                      a.SalesUnit, a.SaleUnitName, UnitID = COALESCE(a.SalesUnit, a.BaseUnit), a.ConversionID, a.Conversion,
      //                      Price = SUM(COALESCE(prod.Price, 0)), COALESCE(prod.IsPremium,0) AS IsPremium
      //                  INTO #dataProducts
      //                  FROM  [dbo].[UVW_ProducstInfo] a WITH (NOLOCK)
      //                  LEFT JOIN [dbo].[TbProductTransactions] b WITH (NOLOCK) ON b.ProductCode = a.ProductCode
      //                  LEFT JOIN CTE_dataProductsPrice prod ON b.ProductCode = prod.ProductCode
      //                  LEFT JOIN [dbo].[TbDocuments] c WITH (NOLOCK) ON c.DocID = b.DocID
      //                  LEFT JOIN [dbo].[TbDocumentTypes] d WITH (NOLOCK) ON d.TypeID = c.DocType
      //                  LEFT JOIN [dbo].[TbStorehouseList] e WITH (NOLOCK) ON b.StorehouseListID = e.StorehouseListID
      //                  LEFT JOIN [dbo].[TbStorehouse] f WITH (NOLOCK) ON e.StorehouseID = f.StorehouseID
      //                  LEFT JOIN [dbo].[TbWarehouse] g WITH (NOLOCK) ON g.WarehouseID = e.WarehouseID
      //                  LEFT JOIN [dbo].[TbBusinessUnit] k WITH (NOLOCK) ON k.BusinessUnitID = e.BusinessUnitID
      //                  LEFT JOIN [dbo].[TbStorehouseType] l WITH (NOLOCK) ON l.StorehouseTypeID = e.StorehouseTypeID
      //                  LEFT JOIN [dbo].[TbMetaBrandHolding] m WITH (NOLOCK) ON a.BrandID = m.BrandID
      //                  LEFT JOIN [dbo].[TbBrandHolding] n WITH (NOLOCK) ON m.BrandHoldingID = n.BrandHoldingID
      //                  WHERE COALESCE(c.IsActive,0) <> 0
      //                      AND COALESCE(b.IsActive,0) <> 0
      //                      AND (COALESCE(b.ReceQty,0) - COALESCE(b.ExpoQty,0)) <> 0
      //                  AND e.StorehouseListID = {0}
      //                      [@BrandID] [@CategoryID] 
      //                      [@IsPremium] [@BrandHolding]
      //                  GROUP BY g.WarehouseID, g.WarehouseCode, g.WarehouseName, a.BrandID, a.BrandCode, a.BrandName,
      //                      a.ConversionID, a.Conversion, b.StorehouseListID, e.StorehouseID, f.StorehouseCode, f.StorehouseName, 
      //                      prod.IsPremium, a.CategoryID, a.CategoryName, a.SubCategoryID, a.SubCategoryCode, 
      //                      a.SubCategoryName, a.ProductCode, a.ProductName, a.BaseUnit, a.SalesUnit, a.BaseUnitName, 
      //                      a.SaleUnitName, l.StorehouseTypeName, k.BusinessUnitName, m.BrandHoldingID, n.BrandHoldingName;
      //                  CREATE NONCLUSTERED INDEX idx_dataProducts ON #dataProducts ([ProductCode]) INCLUDE ([Price],[IsPremium]);
                                    
      //                  /* STEP 2: สรุปยอดสินค้า */
      //                  WITH CTE_dataSummaryProducts AS (
      //                      SELECT g.WarehouseID ,g.WarehouseCode ,g.WarehouseName ,l.StorehouseTypeName ,k.BusinessUnitName
      //                      ,prod.BrandID ,prod.BrandCode ,prod.BrandName ,prod.CategoryID ,prod.CategoryName ,prod.SubCategoryID ,prod.SubCategoryName
      //                      ,DocDate = CONVERT(CHAR(10), c.UpdatedDate,126), a.ProductCode ,a.ProductName
      //                      ,UnitID = CASE WHEN a.SalesUnit is not NULL THEN a.SalesUnit ELSE a.BaseUnit END
      //                      ,a.SalesUnit ,a.BaseUnit ,a.ConversionID, BroughtForwardQty = 0, ReceQty = SUM(COALESCE(b.ReceQty,0))
      //                      ,ExpoQty = (CASE WHEN c.DocType <> 14 THEN SUM(COALESCE(b.ExpoQty,0)) ELSE 0 END)
      //                      ,BrokenQty = (CASE WHEN c.DocType = 14 THEN SUM(COALESCE(b.ExpoQty,0)) ELSE 0 END)
      //                      ,Price= SUM(COALESCE(prod.Price, 0)), prod.IsPremium
      //                      FROM [dbo].[TbProducts] a (NOLOCK)
      //                      LEFT JOIN [dbo].[TbProductTransactions] b (NOLOCK) ON b.ProductCode = a.ProductCode
      //                      LEFT JOIN #dataProducts prod (NOLOCK) ON b.ProductCode = prod.ProductCode
      //                      LEFT JOIN [dbo].[TbDocuments] c (NOLOCK) ON  c.DocID = b.DocID
      //                      LEFT JOIN [dbo].[TbDocumentTypes] d (NOLOCK) ON d.TypeID = c.DocType
      //                      LEFT JOIN [dbo].[TbStorehouseList] e (NOLOCK) ON b.StorehouseListID = e.StorehouseListID
      //                      LEFT JOIN [dbo].[TbStorehouse] f (NOLOCK) ON e.StorehouseID = f.StorehouseID
      //                      LEFT JOIN [dbo].[TbWarehouse] g (NOLOCK) ON g.WarehouseID = e.WarehouseID
      //                      LEFT JOIN [dbo].[TbBusinessUnit] k (NOLOCK) ON k.BusinessUnitID = e.BusinessUnitID
      //                      LEFT JOIN [dbo].[TbStorehouseType] l (NOLOCK) ON l.StorehouseTypeID = e.StorehouseTypeID
      //                      WHERE c.IsAdvancePay <> 1 
      //                      AND COALESCE(c.IsActive, 0) <> 0 
      //                      AND COALESCE(b.IsActive, 0) <> 0
      //                      AND e.StorehouseListID = {0}
      //                      /*AND CAST(c.UpdatedDate AS DATE) = '{1}'*/
      //                      AND c.UpdatedDate >= '{1}' AND c.UpdatedDate < DATEADD(DAY, 1, '{1}')
      //                      GROUP BY g.WarehouseID, g.WarehouseCode, g.WarehouseName, prod.BrandID, prod.BrandCode, prod.BrandName, 
      //                      prod.CategoryID, c.DocType,c.UpdatedDate, prod.IsPremium, prod.CategoryName, prod.SubCategoryID, 
      //                      prod.SubCategoryName, a.ProductCode, a.ProductName, a.SalesUnit, a.BaseUnit, a.ConversionID, 
      //                      l.StorehouseTypeName, k.BusinessUnitName
      //                  )

      //                  SELECT a.WarehouseID, a.WarehouseCode, a.WarehouseName, a.StorehouseTypeName, a.BusinessUnitName, a.BrandID 
      //                      ,a.BrandCode ,a.BrandName ,a.CategoryID ,a.CategoryName ,a.SubCategoryID ,a.SubCategoryName, a.DocDate
      //                      ,a.ProductCode ,a.ProductName ,a.UnitID ,a.SalesUnit ,a.BaseUnit ,a.ConversionID
      //                      ,BroughtForwardQty = SUM(COALESCE(a.BroughtForwardQty,0))
      //                      ,ReceQty = SUM(COALESCE(a.ReceQty,0))
      //                      ,ExpoQty = SUM(COALESCE(a.ExpoQty,0))
      //                      ,BrokenQty = SUM(COALESCE(a.BrokenQty,0))
      //                      ,Price = SUM(COALESCE(Price, 0))
      //                      ,IsPremium
      //                  INTO #dataSummaryProducts
      //                  FROM CTE_dataSummaryProducts a
      //                  GROUP BY a.WarehouseID ,a.WarehouseCode ,a.WarehouseName ,a.BrandID ,a.BrandCode ,a.BrandName ,a.CategoryID,
      //                  a.CategoryName, a.SubCategoryID, IsPremium, a.SubCategoryName, a.DocDate, a.ProductCode ,a.ProductName,
      //                  a.UnitID, a.SalesUnit ,a.BaseUnit, a.ConversionID, a.StorehouseTypeName, a.BusinessUnitName;
                                      
      //                  CREATE INDEX idx_dataSummaryProducts_ProductCode ON #dataSummaryProducts (ProductCode);

      //                  /* STEP 3: คำนวณยอดยกมาตามวันก่อนหน้า */
      //                  WITH CTE_dataLastDay AS (
      //                      SELECT f.WarehouseID, g.WarehouseCode, g.WarehouseName, k.BusinessUnitName, l.StorehouseTypeName,
      //                          e.StorehouseListID, h.StorehouseID, h.StorehouseCode, h.StorehouseName, prod.BrandID, prod.BrandCode, 
      //                          prod.BrandName, prod.CategoryID, prod.CategoryName, prod.SubCategoryID,  prod.SubCategoryCode, prod.SubCategoryName, 
      //                          prod.BrandHoldingID, prod.BrandHoldingName, prod.ProductCode, prod.ProductName, prod.IsPremium,
      //                          BroughtForwardQty = SUM(COALESCE(e.ReceQty, 0) - COALESCE(e.ExpoQty, 0)),
      //                          ReceQty = 0, ExpoQty = 0, BrokenQty = 0, Price = SUM(COALESCE(prod.Price, 0)),
      //                          prod.UnitID, prod.SalesUnit, prod.SaleUnitName,  prod.BaseUnit, prod.BaseUnitName,
      //                          prod.ConversionID, prod.Conversion
      //                      FROM #dataProducts prod WITH (NOLOCK)
      //                      LEFT JOIN [dbo].[TbProductTransactions] e WITH (NOLOCK) ON prod.ProductCode = e.ProductCode
      //                      LEFT JOIN [dbo].[TbStorehouseList] f WITH (NOLOCK) ON e.StorehouseListID = f.StorehouseListID
      //                      LEFT JOIN [dbo].[TbWarehouse] g WITH (NOLOCK) ON f.WarehouseID = g.WarehouseID
      //                      LEFT JOIN [dbo].[TbStorehouse] h WITH (NOLOCK) ON f.StorehouseID = h.StorehouseID
      //                      LEFT JOIN [dbo].[TbDocuments] i WITH (NOLOCK) ON e.DocID = i.DocID
      //                      LEFT JOIN [dbo].[TbBusinessUnit] k WITH (NOLOCK) ON k.BusinessUnitID = f.BusinessUnitID
      //                      LEFT JOIN [dbo].[TbStorehouseType] l WITH (NOLOCK) ON l.StorehouseTypeID = f.StorehouseTypeID
      //                      WHERE i.IsAdvancePay <> 1
      //                              AND COALESCE(e.IsActive, 0) = 1
      //                              AND COALESCE(i.IsActive, 0) = 1
      //                              AND (COALESCE(e.ReceQty, 0) - COALESCE(e.ExpoQty, 0)) <> 0                            
      //                              AND f.StorehouseListID = {0}
      //                              AND CAST(i.UpdatedDate AS DATE) < '{1}'
      //                      GROUP BY f.WarehouseID, g.WarehouseCode, g.WarehouseName, k.BusinessUnitName, l.StorehouseTypeName, 
      //                          prod.BrandID, prod.BrandCode, prod.BrandName, prod.BrandHoldingID, prod.BrandHoldingName, prod.CategoryID, 
      //                          prod.CategoryName, prod.SubCategoryCode, prod.SubCategoryID, prod.SubCategoryName, prod.ProductCode, 
      //                          prod.ProductName, prod.IsPremium, e.StorehouseListID, h.StorehouseID, h.StorehouseCode, h.StorehouseName,
      //                          prod.UnitID, prod.SalesUnit, prod.SaleUnitName,  prod.BaseUnit, prod.BaseUnitName, prod.ConversionID, prod.Conversion
      //                  )

      //                  SELECT 
      //                      WarehouseCode        = COALESCE(a.WarehouseCode, dn.WarehouseCode),
      //                      WarehouseName        = COALESCE(a.WarehouseName, dn.WarehouseName),
      //                      BusinessUnitName     = COALESCE(a.BusinessUnitName, dn.BusinessUnitName),
      //                      StorehouseTypeName   = COALESCE(a.StorehouseTypeName, dn.StorehouseTypeName),
      //                      StorehouseID		 = COALESCE(a.StorehouseID, dn.StorehouseID),
      //                      StorehouseCode		 = COALESCE(a.StorehouseCode, dn.StorehouseCode),
      //                      StorehouseName		 = COALESCE(a.StorehouseName, dn.StorehouseName),
      //                      StorehouseListID     = COALESCE(a.StorehouseListID, dn.StorehouseListID),
      //                      BrandID              = COALESCE(a.BrandID, dn.[BrandID]),
      //                      BrandCode            = COALESCE(a.BrandCode, dn.BrandCode),
      //                      BrandName            = COALESCE(a.BrandName, dn.BrandName),
      //                      BrandHoldingID		 = COALESCE(a.BrandHoldingID, dn.BrandHoldingID),
      //                      BrandHoldingName     = COALESCE(a.BrandHoldingName, dn.BrandHoldingName),
      //                      CategoryID           = COALESCE(a.CategoryID, dn.CategoryID),
      //                      CategoryName         = COALESCE(a.CategoryName, dn.CategoryName),
      //                      SubCategoryID        = COALESCE(a.SubCategoryID, dn.SubCategoryID),
      //                      SubCategoryCode      = COALESCE(a.SubCategoryCode, dn.SubCategoryCode),
      //                      SubCategoryName      = COALESCE(a.SubCategoryName, dn.SubCategoryName),
      //                      ProductCode          = COALESCE(a.ProductCode, dn.ProductCode),
      //                      ProductName          = COALESCE(a.ProductName, dn.ProductName),	
      //                      IsPremium            = COALESCE(a.IsPremium, 0),    
      //                      /*BroughtForwardQty = SUM(COALESCE(a.BroughtForwardQty, dn.[BroughtForwardQty])),*/
      //                      BroughtForwardQty = SUM(COALESCE(a.BroughtForwardQty, 0) + COALESCE(dn.[BroughtForwardQty], 0)),
      //                      ReceQty           = SUM(COALESCE(a.ReceQty, dn.[ReceQty])),
      //                      ExpoQty           = SUM(COALESCE(a.ExpoQty, dn.[ExpoQty])),
      //                      BrokenQty         = SUM(COALESCE(a.BrokenQty, dn.[BreakQty])),
      //                      Price             = SUM(COALESCE(a.Price, 0) * (COALESCE(dn.[BroughtForwardQty], 0) + COALESCE(dn.[ReceQty], 0) + COALESCE(dn.[ExpoQty], 0) + COALESCE(dn.[BreakQty], 0))),
      //                      BaseUnit		  = COALESCE(a.BaseUnit, dn.BaseUnit),
      //                      SalesUnit		  = COALESCE(a.SalesUnit, dn.SalesUnit),
      //                      UnitID			  = COALESCE(a.UnitID, dn.UnitID)
      //                  INTO #dataLastDay
      //                  FROM CTE_dataLastDay a
      //                  FULL JOIN (
      //                      SELECT pb.WarehouseID, pb.WarehouseCode, pb.[WarehouseName], pb.[BusinessUnitName], pb.StorehouseTypeName, pb.StorehouseID, pb.StorehouseCode, pb.StorehouseName,
						//		pb.[StorehouseListID], pb.[ProductCode], pb.[ProductName], pb.[BrandID], pb.[BrandCode], pb.[BrandName], pb.[BrandHoldingID], pb.[BrandHoldingName], 
						//		pb.[CategoryID], pb.[CategoryCode], pb.[CategoryName], pb.[SubCategoryID], pb.[SubCategoryCode], pb.[SubCategoryName], pb.[BroughtForwardQty], pb.[ReceQty], 
      //                          pb.[ExpoQty], pb.[BreakQty], pb.[BalanceQty], pb.[ConversionID], pb.[Conversion], pb.[SalesUnit], 
      //                          pb.[SaleUnitName], pb.[BaseUnit], pb.[BaseUnitName], pb.UnitID, pb.[LastUpdate]
      //                      FROM [dbo].[UVW_ProductRegionalBroughtForward] pb
      //                      WHERE pb.StorehouseListID = {0}
      //                      AND YEAR(pb.LastUpdate) = YEAR(DATEADD(DAY, -1 , @RefDate)) 
      //                      AND CAST(pb.LastUpdate AS DATE) = DATEADD(DAY, -1 , @RefDate)
      //                      /*AND pb.LastUpdate >= '{1}' AND pb.LastUpdate < DATEADD(DAY, 1, '{1}')*/
      //                  ) dn 
      //                  ON a.StorehouseListID = dn.StorehouseListID 
      //                  AND a.WarehouseID = dn.WarehouseID
      //                  AND a.ProductCode = dn.ProductCode
      //                  GROUP BY 
      //                      COALESCE(a.WarehouseCode, dn.WarehouseCode),
      //                      COALESCE(a.WarehouseName, dn.WarehouseName),
      //                      COALESCE(a.BusinessUnitName, dn.BusinessUnitName),
      //                      COALESCE(a.StorehouseTypeName, dn.StorehouseTypeName),
      //                      COALESCE(a.StorehouseID, dn.StorehouseID),
      //                      COALESCE(a.StorehouseCode, dn.StorehouseCode), 
      //                      COALESCE(a.StorehouseName, dn.StorehouseName),
      //                      COALESCE(a.StorehouseListID, dn.StorehouseListID),
      //                      COALESCE(a.BrandID, dn.BrandID),
      //                      COALESCE(a.BrandCode, dn.BrandCode),
      //                      COALESCE(a.BrandName, dn.BrandName),
      //                      COALESCE(a.BrandHoldingID, dn.BrandHoldingID),
      //                      COALESCE(a.BrandHoldingName, dn.BrandHoldingName),
      //                      COALESCE(a.CategoryID, dn.CategoryID),
      //                      COALESCE(a.CategoryName, dn.CategoryName),
      //                      COALESCE(a.SubCategoryID, dn.SubCategoryID),
      //                      COALESCE(a.SubCategoryCode, dn.SubCategoryCode),
      //                      COALESCE(a.SubCategoryName, dn.SubCategoryName),
      //                      COALESCE(a.ProductCode, dn.ProductCode),
      //                      COALESCE(a.ProductName, dn.ProductName),
      //                      COALESCE(a.BaseUnit, dn.BaseUnit),
      //                      COALESCE(a.SalesUnit, dn.SalesUnit),
      //                      COALESCE(a.IsPremium, 0),
      //                      COALESCE(a.UnitID, dn.UnitID)
      //                  HAVING  SUM(COALESCE(a.BroughtForwardQty, 0) + COALESCE(dn.[BroughtForwardQty], 0)) != 0 
      //                      OR (SUM(COALESCE(a.ReceQty,0) + COALESCE(dn.[ReceQty], 0)) != 0 OR SUM(COALESCE(a.ExpoQty,0) + COALESCE(dn.[ExpoQty],0)) != 0 OR SUM(COALESCE(a.BrokenQty, 0) + COALESCE(dn.[BreakQty], 0)) != 0)
                        
      //                  CREATE INDEX idx_dataLastDay_ProductCode_WarehouseCode ON #dataLastDay (ProductCode, WarehouseCode);

      //                  /* STEP 4: ตรวจสอบสินค้าคงเหลือจากการตรวจนับ (End Of Day Checking) */
      //                  /* ตรวจนับรายวัน (รวมการ GROUP BY ตามสินค้า) */
      //                  SELECT a.BrandHoldingID, a.BrandHoldingName, a.BrandID, a.BrandCode, a.BrandName,	
      //                      a.StorehouseListID, a.StorehouseTypeName, a.BusinessUnitName, a.ProductCode, a.ProductName, 
      //                      a.CategoryID, a.CategoryName, a.SubCategoryID, a.SubCategoryName, a.WarehouseCode, a.WarehouseName,
      //                      CheckingQty = COALESCE(e.ProductQty, 0), a.Price, a.IsPremium 
      //                  INTO #dataCheckingQty
      //                  FROM #dataProducts a
      //                  LEFT JOIN 
      //                      (
      //                          SELECT a.ProductCode,
      //                              ProductQty = SUM(COALESCE(a.ProductQty, 0))
      //                          FROM [dbo].[TbEndOfDayChecking] a WITH (NOLOCK)
      //                          INNER JOIN [dbo].[TbStorehouseList] b WITH (NOLOCK) ON a.StorehouseListID = b.StorehouseListID
      //                          WHERE COALESCE(a.IsActive, 0) <> 0
      //                          AND b.StorehouseListID = {0}
      //                          /*AND (CAST(a.CreatedDate AS DATE) >= '{1}' AND CAST(a.CreatedDate AS DATE) < '{2}')*/
      //                          AND a.CreatedDate >= '{1}' AND a.CreatedDate < DATEADD(DAY, 1, '{1}')
      //                          GROUP BY a.ProductCode
      //                      ) e ON a.ProductCode = e.ProductCode
      //                  LEFT JOIN 
      //                      (
      //                          SELECT a.ProductCode, a.Remark 
      //                          FROM [dbo].[TbEndOfDayChecking] a WITH (NOLOCK)
      //                          INNER JOIN [dbo].[TbStorehouseList] b WITH (NOLOCK) ON a.StorehouseListID = b.StorehouseListID
      //                          WHERE COALESCE(a.IsActive, 0) <> 0
      //                          AND b.StorehouseListID = {0}
      //                          /*AND (CAST(a.CreatedDate AS DATE) >= '{1}' AND CAST(a.CreatedDate AS DATE) < '{2}')*/
      //                          AND a.CreatedDate >= '{1}' AND a.CreatedDate < DATEADD(DAY, 1, '{2}')
      //                      ) b ON a.ProductCode = b.ProductCode
      //                  GROUP BY a.BrandHoldingID, a.BrandHoldingName, a.BrandID, a.BrandCode, 
      //                  a.BrandName, a.StorehouseListID, a.StorehouseTypeName, a.BusinessUnitName, 
      //                  a.ProductCode, a.ProductName, a.CategoryID, a.CategoryName, a.SubCategoryID, 
      //                  a.SubCategoryName, a.WarehouseCode, a.WarehouseName, e.ProductQty, a.Price, a.IsPremium;
                                      
      //                  CREATE INDEX idx_dataCheckingQty_ProductCode_WarehouseCode ON #dataCheckingQty (ProductCode, WarehouseCode);

      //                  /* ตรวจสอบสินค้าล่าสุดตามวัน (Row_Number สำหรับแยกสินค้าล่าสุดแต่ละรายการ) */
      //                  WITH CTE_ProductQty AS (
      //                      SELECT a.StorehouseListID, a.ProductCode, a.ProductQty, a.CreatedDate,
      //                          ROW_NUMBER() OVER (PARTITION BY a.ProductCode ORDER BY a.CreatedDate DESC) AS RowID
      //                      FROM [dbo].[TbEndOfDayChecking] a (NOLOCK)
      //                      INNER JOIN [dbo].[TbStorehouseList] b (NOLOCK) ON a.StorehouseListID = b.StorehouseListID
      //                      WHERE COALESCE(a.IsActive, 0) <> 0
      //                      AND b.StorehouseListID = {0}
      //                      /*AND (CAST(a.CreatedDate AS DATE) >= '{1}' AND CAST(a.CreatedDate AS DATE) < '{2}')*/
      //                      AND a.CreatedDate >= '{1}' AND a.CreatedDate < DATEADD(DAY, 1, '{2}')
      //                  )

      //                  SELECT a.BrandHoldingID, a.BrandHoldingName, a.BrandID, a.BrandCode, a.BrandName, 
      //                      a.StorehouseTypeName, a.BusinessUnitName, a.ProductCode, a.ProductName, a.CategoryName,
      //                      a.StorehouseListID, a.SubCategoryID, a.SubCategoryName, a.WarehouseCode, a.WarehouseName,
      //                      COALESCE(e.ProductQty, 0) AS CheckingQty, a.Price, a.IsPremium
      //                  INTO #dataLastCheckingQty
      //                  FROM #dataProducts a
      //                  LEFT JOIN (
      //                      SELECT ProductCode, ProductQty
      //                      FROM CTE_ProductQty
      //                      WHERE RowID = 1
      //                  ) e ON a.ProductCode = e.ProductCode;

      //                  /* STEP 5: ข้อมูลการส่งสินค้าแบบชำระล่วงหน้า (Advance Payment) */
      //                  WITH CTE_AdvancePayment AS (
      //                      SELECT g.WarehouseID ,g.WarehouseCode ,g.WarehouseName, e.StorehouseListID, l.StorehouseTypeName ,k.BusinessUnitName
      //                          ,prod.BrandID ,prod.BrandCode ,prod.BrandName ,prod.CategoryID ,prod.CategoryName ,prod.SubCategoryID
      //                      ,prod.SubCategoryName, DocDate = CONVERT(CHAR(10), c.UpdatedDate,126), a.ProductCode ,a.ProductName
      //                          ,UnitID = CASE WHEN a.SalesUnit is not NULL THEN a.SalesUnit ELSE a.BaseUnit END
      //                          ,a.SalesUnit ,a.BaseUnit, a.ConversionID
      //                          ,AdvanceQty = SUM(COALESCE(b.ExpoQty,0))
      //                          ,Price= SUM(COALESCE(prod.Price, 0))
      //                      ,prod.IsPremium
      //                      FROM [dbo].[TbProducts] a (NOLOCK)
      //                          LEFT JOIN [dbo].[TbProductTransactions] b (NOLOCK) ON b.ProductCode = a.ProductCode
      //                          LEFT JOIN #dataProducts prod (NOLOCK) ON b.ProductCode = prod.ProductCode
      //                          LEFT JOIN [dbo].[TbDocuments] c (NOLOCK) ON  c.DocID = b.DocID
      //                          LEFT JOIN [dbo].[TbDocumentTypes] d (NOLOCK) ON d.TypeID = c.DocType
      //                          LEFT JOIN [dbo].[TbStorehouseList] e (NOLOCK) ON b.StorehouseListID = e.StorehouseListID
      //                          LEFT JOIN [dbo].[TbStorehouse] f (NOLOCK) ON e.StorehouseID = f.StorehouseID
      //                          LEFT JOIN [dbo].[TbWarehouse] g (NOLOCK) ON g.WarehouseID = e.WarehouseID
      //                          LEFT JOIN [dbo].[TbBusinessUnit] k (NOLOCK) ON k.BusinessUnitID = e.BusinessUnitID
      //                          LEFT JOIN [dbo].[TbStorehouseType] l (NOLOCK) ON l.StorehouseTypeID = e.StorehouseTypeID
      //                      WHERE c.DocType = 11
      //                          AND COALESCE(c.IsActive, 0) <> 0 
      //                          AND COALESCE(b.IsActive, 0) <> 0
      //                          AND e.StorehouseListID = {0}
      //                          /*AND CAST(c.UpdatedDate AS DATE) = '{1}'*/
      //                          AND a.UpdatedDate >= '{1}' AND a.UpdatedDate < DATEADD(DAY, 1, '{1}')
      //                      GROUP BY g.WarehouseID, g.WarehouseCode, g.WarehouseName, e.StorehouseListID, prod.BrandID, prod.BrandCode, 
      //                      prod.BrandName, prod.CategoryID, c.DocType, CONVERT(CHAR(10), c.UpdatedDate,126), prod.IsPremium, prod.CategoryName, 
      //                      prod.SubCategoryID, prod.SubCategoryName, a.ProductCode, a.ProductName, a.SalesUnit, a.BaseUnit, a.ConversionID, 
      //                      l.StorehouseTypeName, k.BusinessUnitName
      //                  )

      //                  /* STEP 6: รวมข้อมูลภาพรวมคงเหลือ */
      //                  SELECT BrandHoldingID = COALESCE(a.BrandHoldingID, b.BrandHoldingID),
      //                      BrandHoldingName = COALESCE(a.BrandHoldingName, b.BrandHoldingName),
      //                      BrandID = COALESCE(a.BrandID, b.BrandID),
      //                          BrandCode = COALESCE(a.BrandCode, b.BrandCode), 
      //                      BrandName = COALESCE(a.BrandName, b.BrandName),
      //                      StorehouseTypeName = COALESCE(a.StorehouseTypeName, b.StorehouseTypeName), 
      //                      BusinessUnitName = COALESCE(a.BusinessUnitName, b.BusinessUnitName),
      //                          ProductCode = COALESCE(a.ProductCode, b.ProductCode),
      //                      ProductName = COALESCE(a.ProductName, b.ProductName),
      //                      CategoryID = COALESCE(c.CategoryID, b.CategoryID),
      //                      CategoryName = COALESCE(a.CategoryName, b.CategoryName),
      //                      SubCategoryID = COALESCE(a.SubCategoryID, b.SubCategoryID),
      //                          SubCategoryName  = COALESCE(a.SubCategoryName, b.SubCategoryName),
      //                      BaseUnit = COALESCE(a.BaseUnit, b.BaseUnit),
      //                      SalesUnit = COALESCE(a.SalesUnit, b.SalesUnit), 
      //                      UnitID = COALESCE(a.UnitID, b.UnitID), 
      //                      a.ConversionID, 
      //                          StorehouseListID = COALESCE(a.StorehouseListID,  b.StorehouseListID),
      //                      StorehouseID = COALESCE(a.StorehouseID, b.StorehouseID),
      //                      StorehouseCode = COALESCE(a.StorehouseCode, b.StorehouseCode),
      //                      StorehouseName = COALESCE(a.StorehouseName, b.StorehouseName),
      //                      WarehouseCode = COALESCE(a.WarehouseCode, b.WarehouseCode),
      //                      WarehouseName = COALESCE(a.WarehouseName, b.WarehouseName),
      //                          COALESCE(b.BroughtForwardQty, 0) AS BroughtForwardBalanceQty,
      //                          COALESCE(m.ReceQty, 0) AS ReceQty,
      //                          (COALESCE(m.ExpoQty, 0) - COALESCE(adv.AdvanceQty, 0)) AS ExpoQty,
      //                          COALESCE(adv.AdvanceQty, 0) AS AdvanceQty,
      //                          COALESCE(m.BrokenQty, 0) AS BrokenQty,
      //                          COALESCE(b.BroughtForwardQty, 0) + (COALESCE(m.ReceQty, 0) - (COALESCE(m.ExpoQty, 0) + COALESCE(m.BrokenQty, 0))) AS BalanceStored,
      //                          COALESCE(c.CheckingQty, 0) AS TackingProd, 
      //                      Price = COALESCE(a.Price, b.Price), 
      //                      IsPremium = COALESCE(a.IsPremium, 0), 
      //                      m.DocDate
      //                  INTO #dataLastBroughtSumTack
      //                  FROM #dataProducts a
      //                  LEFT JOIN #dataSummaryProducts m ON a.ProductCode = m.ProductCode
      //                  FULL OUTER JOIN #dataLastDay b ON a.ProductCode = b.ProductCode AND a.StorehouseListID = b.StorehouseListID
      //                  LEFT JOIN #dataCheckingQty c ON a.ProductCode = c.ProductCode AND a.StorehouseListID = c.StorehouseListID
      //                  LEFT JOIN CTE_AdvancePayment adv ON a.ProductCode = adv.ProductCode AND a.StorehouseListID = adv.StorehouseListID
      //                  ORDER BY a.BrandCode, a.CategoryName, a.ProductCode;
                                      
      //                  CREATE INDEX idx_dataLastBroughtSumTack_ProductCode ON #dataLastBroughtSumTack (ProductCode);

      //                  /* STEP 7: สรุปผลรวมภาพรวมสินค้า */
      //                  SELECT a.WarehouseCode, a.WarehouseName, a.StorehouseListID, a.StorehouseID, a.StorehouseCode, a.StorehouseName, 
      //                      a.StorehouseTypeName, a.BusinessUnitName, a.BrandHoldingID, a.BrandHoldingName, a.BrandID, a.BrandCode, a.BrandName, 
      //                      a.CategoryID, a.CategoryName, a.SubCategoryID, a.SubCategoryName, a.ProductCode, a.ProductName, 
      //                      a.BaseUnit, a.SalesUnit,  a.UnitID, a.ConversionID, a.DocDate, a.BroughtForwardBalanceQty, 
      //                      a.ReceQty, a.ExpoQty, a.AdvanceQty, a.BrokenQty, a.BalanceStored, a.TackingProd,
      //                      Diff = CASE 
      //                          WHEN COALESCE(a.TackingProd, 0) <> 0 
      //                          THEN (COALESCE(a.TackingProd, 0) - COALESCE(a.BalanceStored, 0)) ELSE 0 END,
      //                      a.Price, a.IsPremium
      //                  INTO #overallSummaryProduct
      //                  FROM #dataLastBroughtSumTack a
      //                  INNER JOIN (
      //                      SELECT ProductCode, MAX(BalanceStored) AS BalanceStored
      //                      FROM #dataLastBroughtSumTack
      //                      GROUP BY ProductCode
      //                  ) b ON a.ProductCode = b.ProductCode
      //                  ORDER BY a.BrandCode, a.CategoryName, a.ProductCode;

      //                  CREATE INDEX idx_overallSummaryProduct_UnitID ON #overallSummaryProduct (UnitID);
      //                  CREATE INDEX idx_overallSummaryProduct_ConversionID ON #overallSummaryProduct (ConversionID);

      //                  /* Final Step */
      //                  SELECT a.BrandHoldingID, a.BrandHoldingName, a.BrandID, a.BrandCode, a.BrandName, 
      //                      a.StorehouseTypeName, a.BusinessUnitName, a.ProductCode, a.ProductName, 
      //                      a.CategoryID, a.CategoryName, a.SubCategoryName, a.WarehouseCode, a.WarehouseName, 
      //                      a.StorehouseListID, a.StorehouseID, a.StorehouseCode, a.StorehouseName,
      //                      BroughtForwardUnit = CASE 
      //                          WHEN c.Conversion > 1 THEN CONCAT(
      //                              CONVERT(VARCHAR(100), (a.BroughtForwardBalanceQty / c.Conversion)), '/', CONVERT(VARCHAR(100), a.BroughtForwardBalanceQty % c.Conversion)
      //                          ) ELSE CONVERT(VARCHAR(100), a.BroughtForwardBalanceQty) END,
      //                      BroughtForwardBalanceQty = COALESCE(a.BroughtForwardBalanceQty, 0),
      //                      ReceUnit = CASE 
      //                          WHEN c.Conversion > 1 THEN CONCAT(
      //                              CONVERT(VARCHAR(100), (a.ReceQty / c.Conversion)), '/', CONVERT(VARCHAR(100), a.ReceQty % c.Conversion)
      //                          ) ELSE CONVERT(VARCHAR(100), a.ReceQty) END,
      //                      a.ReceQty,
      //                      ExpoUnit = CASE 
      //                          WHEN c.Conversion > 1 THEN CONCAT(
      //                              CONVERT(VARCHAR(100), (a.ExpoQty / c.Conversion)), '/', CONVERT(VARCHAR(100), a.ExpoQty % c.Conversion)
      //                          ) ELSE CONVERT(VARCHAR(100), a.ExpoQty) END,
      //                      a.ExpoQty,
      //                      AdvanceUnit = CASE 
      //                          WHEN c.Conversion > 1 THEN CONCAT(
      //                              CONVERT(VARCHAR(100), (a.AdvanceQty / c.Conversion)), '/', CONVERT(VARCHAR(100), a.AdvanceQty % c.Conversion)
      //                          ) ELSE CONVERT(VARCHAR(100), a.AdvanceQty) END,
      //                      a.AdvanceQty,
      //                      BrokenUnit = CASE 
      //                          WHEN c.Conversion > 1 THEN CONCAT(
      //                              CONVERT(VARCHAR(100), (a.BrokenQty / c.Conversion)), '/', CONVERT(VARCHAR(100), a.BrokenQty % c.Conversion)
      //                          ) ELSE CONVERT(VARCHAR(100), a.BrokenQty) END,
      //                      a.BrokenQty,
      //                      BalanceStoredUnit = CASE 
      //                          WHEN c.Conversion > 1 THEN CONCAT(
      //                              CONVERT(VARCHAR(100), (a.BalanceStored / c.Conversion)), '/', CONVERT(VARCHAR(100), a.BalanceStored % c.Conversion)
      //                          ) ELSE CONVERT(VARCHAR(100), a.BalanceStored) END,
      //                      BalanceStoredQty = COALESCE(a.BalanceStored, 0),
      //                      CheckingUnit = CASE 
      //                          WHEN c.Conversion > 1 THEN CONCAT(
      //                              CONVERT(VARCHAR(100), (a.TackingProd / c.Conversion)), '/', CONVERT(VARCHAR(100), a.TackingProd % c.Conversion)
      //                          ) ELSE CONVERT(VARCHAR(100), a.TackingProd) END,
      //                      CheckingQty = a.TackingProd,
      //                      DiffUnit = CASE 
      //                          WHEN c.Conversion > 1 THEN CONCAT(
      //                              CONVERT(VARCHAR(100), (a.Diff / c.Conversion)), '/', CONVERT(VARCHAR(100), a.Diff % c.Conversion)
      //                          ) ELSE CONVERT(VARCHAR(100), a.Diff) END,
      //                      DiffQty = a.Diff,
      //                      ProductPrice = COALESCE(a.Price, 0),
      //                      TotalPrice = COALESCE(a.BalanceStored, 0) * a.Price,
      //                      StockUnitName = CONCAT(b.StockUnitName, CASE 
      //                          WHEN c.Conversion > 1 THEN CONCAT('-', c.Conversion) ELSE '' END),
      //                      DocDate = COALESCE(a.DocDate, '{1}'), CAST(a.IsPremium AS BIT) AS IsPremium, c.Conversion,
      //                      CONCAT('[@productImage]','GetImgServ?codeImg=',a.ProductCode,'&typeAsset=',CASE WHEN a.CategoryID = 9 THEN 1 ELSE 2 END) as productImage
      //                  FROM #overallSummaryProduct a
      //                  LEFT JOIN [dbo].[TbStockUnit] b ON a.UnitID = b.StockUnitID
      //                  LEFT JOIN [dbo].[TbConversion] c ON a.ConversionID = c.ConversionID 
      //                  WHERE ((COALESCE(a.BroughtForwardBalanceQty, 0) + (COALESCE(a.ReceQty, 0) - (COALESCE(a.ExpoQty, 0) + COALESCE(a.BrokenQty, 0)))) <> 0 
      //                      OR (COALESCE(a.ReceQty, 0) <> 0 OR COALESCE(a.ExpoQty, 0) <> 0 OR COALESCE(a.BrokenQty, 0) <> 0))
      //                  ORDER BY CAST(a.ReceQty AS INT) DESC, CAST(a.ExpoQty AS INT) DESC, CAST(a.BrokenQty AS INT) DESC;

      //                  DROP TABLE #dataProducts;
      //                  DROP TABLE #dataSummaryProducts;
      //                  DROP TABLE #dataLastDay;
      //                  DROP TABLE #dataCheckingQty;
      //                  DROP TABLE #dataLastCheckingQty;
      //                  DROP TABLE #dataLastBroughtSumTack;
      //                  DROP TABLE #overallSummaryProduct;
      //              ";


                }
                catch (Exception ex)
                {

                    throw;
                }
            }

            return dailyReportRes;
        }

        MovementReportRes IReport.GetMovementReportBC(MovementReportReq req)
        {
            MovementReportRes movementReportRes = new MovementReportRes();  
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {

      //              string strSQL = @"                        
      //                   SET NOCOUNT ON;
      //                   /* Drop temporary tables if they exist */
      //                   DECLARE @tempTables TABLE (TableName NVARCHAR(4000));
      //                   INSERT INTO @tempTables (TableName)
      //                   VALUES 
						//	 ('#dataProductInfoMaster'),
      //                       ('#dataProductsInfo'),
						//	 ('#dataProductsMovement'),
						//	 ('#dataAdvanceReturn'),
      //                       ('#dataLastCurrentDay'),
      //                       ('#dataCheckingQty'),
      //                       ('#dataLastCheckingQty'),
      //                       ('#dataLastBroughtSumTack');
      //                   DECLARE @strSQL NVARCHAR(MAX) = '';
      //                   SELECT @strSQL = @strSQL + 'IF OBJECT_ID(''tempdb..' + TableName + ''') IS NOT NULL DROP TABLE ' + TableName + '; '
      //                   FROM @tempTables;
      //                   EXEC sp_executesql @strSQL;

      //                  DECLARE @RefDate DATE = (
						//    SELECT MinDate
						//    FROM [dbo].[TbTDocumntFirstDate] (NOLOCK)
						//    WHERE StorehouseListID = {0}
					 //   );

      //                  /* STEP 1: เตรียมข้อมูลสินค้า */
						//WITH CTE_dataProductsPrice AS (
						//	SELECT ProductCode, Price, IsPremium
						//	FROM (
						//		SELECT b.ProductCode, b.Price, b.IsPremium,
						//			ROW_NUMBER() OVER (PARTITION BY b.ProductCode
						//								ORDER BY COALESCE(a.CreatedDate, a.UpdatedDate) DESC) AS rn
						//		FROM [dbo].[TbDocuments] a 
						//		INNER JOIN [dbo].[TbProductTransactions] b WITH (NOLOCK) ON a.DocID = b.DocID
						//		WHERE DocType = 9 
						//		AND b.Price IS NOT NULL
						//		AND b.StorehouseListID = {0}
						//	) x
						//	WHERE rn = 1
						//)
						//SELECT a.ProductCode, a.ProductName, a.CategoryID, b.CategoryName,
						//	a.SubCategoryID, d.SubCategoryCode, d.SubCategoryName,
						//	a.BrandID, c.BrandCode, c.BrandName,a.BaseUnit, a.SalesUnit,
						//	CASE WHEN a.SalesUnit IS NOT NULL THEN a.SalesUnit ELSE a.BaseUnit END AS UnitID,
						//	a.ConversionID, f.WarehouseID, g.WarehouseCode, g.WarehouseName,
						//	f.StorehouseListID, h.StorehouseID, h.StorehouseCode, h.StorehouseName,
						//	l.StorehouseTypeName, k.BusinessUnitName, COALESCE(prod.Price, 0) AS Price
						//INTO #dataProductInfoMaster
						//FROM [dbo].[TbProducts] a WITH (NOLOCK)
						//LEFT JOIN [dbo].[TbCategories] b WITH (NOLOCK) ON a.CategoryID = b.CategoryID
						//LEFT JOIN [dbo].[TbBrands] c WITH (NOLOCK) ON a.BrandID = c.BrandID
						//LEFT JOIN [dbo].[TbSubCategories] d WITH (NOLOCK) ON a.SubCategoryID = d.SubCategoryID
						//LEFT JOIN [dbo].[TbProductTransactions] e WITH (NOLOCK) ON a.ProductCode = e.ProductCode
						//LEFT JOIN [dbo].[TbStorehouseList] f WITH (NOLOCK) ON e.StorehouseListID = f.StorehouseListID
						//LEFT JOIN [dbo].[TbWarehouse] g WITH (NOLOCK) ON f.WarehouseID = g.WarehouseID
						//LEFT JOIN [dbo].[TbStorehouse] h WITH (NOLOCK) ON f.StorehouseID = h.StorehouseID
						//LEFT JOIN [dbo].[TbBusinessUnit] k (NOLOCK) ON k.BusinessUnitID = f.BusinessUnitID
						//LEFT JOIN [dbo].[TbStorehouseType] l (NOLOCK) ON l.StorehouseTypeID = f.StorehouseTypeID
						//LEFT JOIN CTE_dataProductsPrice prod WITH (NOLOCK) ON a.ProductCode = prod.ProductCode
						//WHERE f.StorehouseListID = {0}
						//[@whereCategoryID]
						//GROUP BY 
						//	a.ProductCode, a.ProductName, a.CategoryID, b.CategoryName, a.SubCategoryID, 
						//	d.SubCategoryCode, d.SubCategoryName, a.BrandID, c.BrandCode, c.BrandName, a.BaseUnit, 
						//	a.SalesUnit, a.ConversionID, f.WarehouseID, g.WarehouseCode, g.WarehouseName, f.StorehouseListID, 
						//	h.StorehouseID, h.StorehouseCode, h.StorehouseName, prod.Price, l.StorehouseTypeName, k.BusinessUnitName;                                 
	  
						//SELECT  mPro.BusinessUnitName, mPro.StorehouseTypeName, mPro.BrandID, mPro.BrandCode, mPro.BrandName, a.ProductCode, a.ProductName,
		    //                a.CategoryID, mPro.CategoryName, a.SubCategoryID, mPro.SubCategoryCode, mPro.SubCategoryName, a.BaseUnit, a.SalesUnit, 
						//	CASE WHEN a.SalesUnit IS NOT NULL THEN a.SalesUnit ELSE a.BaseUnit END AS UnitID, a.ConversionID, f.WarehouseID, 
						//	mPro.WarehouseCode, mPro.WarehouseName, f.StorehouseListID, mPro.StorehouseID, mPro.StorehouseCode, mPro.StorehouseName, e.IsActive, 
						//	i.FromStorehouseListID, i.ToStorehouseListID, i.Remark, ReceQty = COALESCE(e.ReceQty, 0), 
      //                      CASE WHEN i.DocType <> 14 THEN COALESCE(e.ExpoQty, 0) ELSE 0 END AS ExpoQty,
      //                      CASE WHEN i.DocType = 14 THEN COALESCE(e.ExpoQty, 0) ELSE 0 END AS BrokenQty, 
      //                      COALESCE(mPro.Price, 0) AS Price,        
      //                      CONVERT(char(10), i.UpdatedDate, 126) AS TranDate,
      //                      CONVERT(char(10), i.UpdatedDate, 126) AS DocDate,
						//	e.DocID, i.DocCode, i.RefCode, i.DocType, dt.TypeName, i.IsAdvancePay
						//INTO #dataProductsInfo
      //                  FROM [dbo].[TbProducts] a (NOLOCK)
      //                  LEFT JOIN [dbo].[TbProductTransactions] e (NOLOCK) ON a.ProductCode = e.ProductCode
      //                  LEFT JOIN [dbo].[TbStorehouseList] f (NOLOCK) ON e.StorehouseListID = f.StorehouseListID
      //                  LEFT JOIN [dbo].[TbDocuments] i (NOLOCK) ON e.DocID = i.DocID
						//LEFT JOIN [dbo].[TbDocumentTypes] dt (NOLOCK) ON i.DocType = dt.TypeID
      //                  LEFT JOIN #dataProductInfoMaster mPro (NOLOCK) ON e.ProductCode = mPro.ProductCode
      //                  WHERE COALESCE(i.IsAdvancePay, 0) <> 1
      //                  AND COALESCE(i.IsActive, 0) <> 0
      //                  AND COALESCE(e.IsActive, 0) <> 0
      //                  AND f.StorehouseListID = {0}
      //                  AND i.UpdatedDate >= '{2}' AND i.UpdatedDate < DATEADD(DAY, 1, '{2}');          

						//SELECT a.WarehouseID, a.StorehouseListID, a.StorehouseCode, a.StorehouseName, a.ProductCode, a.ProductName,                          
						//	SUM(COALESCE(a.ReceQty, 0)) AS ReceQty,
      //                      SUM(COALESCE(a.ExpoQty, 0)) AS ExpoQty,
      //                      SUM(COALESCE(a.BrokenQty, 0)) AS BrokenQty, 
      //                      SUM(COALESCE(a.Price, 0)) AS Price
      //                  INTO #dataProductsMovement
      //                  FROM #dataProductsInfo a
						//WHERE a.DocType != 6
      //                  GROUP BY 
      //                      a.WarehouseID, a.WarehouseCode, a.StorehouseListID, a.StorehouseCode, a.StorehouseName, a.ProductCode, a.ProductName;

						//WITH CTE_AdvanceReturn AS (
						//	SELECT WarehouseID, StorehouseListID, StorehouseCode, StorehouseName,
						//		DocID, DocCode, RefCode, DocType, TypeName ,ProductCode, ProductName, 
						//		CategoryID, BaseUnit, SalesUnit, ConversionID, AdvanceReQty = COALESCE(ReceQty, 0), Price = COALESCE(Price, 0)
						//	FROM #dataProductsInfo
						//	WHERE DocType = 6
						//)
						//SELECT aRet.WarehouseID, aRet.StorehouseListID, aRet.StorehouseCode, aRet.StorehouseName, pt.ProductCode, aRet.ProductName,
						//	AdvanceQty = SUM(COALESCE(pt.ExpoQty, 0)),
						//	AdvanceReQty = SUM(COALESCE(aRet.AdvanceReQty, 0)),
						//	AdvancePeQty = SUM(COALESCE(pt.ExpoQty, 0)) - SUM(COALESCE(aRet.AdvanceReQty, 0)),
						//	Price = SUM(COALESCE(aRet.Price, 0))
						//INTO #dataAdvanceReturn
						//FROM [dbo].[TbDocuments] doc
						//INNER JOIN [dbo].[TbProductTransactions] pt ON doc.DocID = pt.DocID
						//INNER JOIN CTE_AdvanceReturn aRet ON doc.DocCode = aRet.RefCode 
						//	AND pt.ProductCode = aRet.ProductCode
						//GROUP BY aRet.WarehouseID, aRet.StorehouseListID, aRet.StorehouseCode, aRet.StorehouseName, pt.ProductCode, aRet.ProductName;
                        
      //                  /* Step 3: CTE สำหรับข้อมูลสินค้าที่มีการเคลื่อนไหวก่อนวันปัจจุบัน */
      //                  WITH CTE_dataLastCurrentDay AS (
      //                     SELECT g.WarehouseID, e.StorehouseListID, h.StorehouseCode, h.StorehouseName, a.ProductCode, a.ProductName, 
      //                          SUM(COALESCE(e.ReceQty, 0)) - SUM(COALESCE(e.ExpoQty, 0)) AS BroughtForwardQty,
      //                          NULL AS ReceQty, NULL AS ExpoQty, NULL AS BrokenQty, Price = SUM(NULLIF(e.Price, 0))
      //                      FROM [dbo].[TbProducts] a (NOLOCK)
      //                      LEFT JOIN [dbo].[TbProductTransactions] e (NOLOCK) ON a.ProductCode = e.ProductCode
      //                      LEFT JOIN [dbo].[TbStorehouseList] f (NOLOCK) ON e.StorehouseListID = f.StorehouseListID
      //                      LEFT JOIN [dbo].[TbWarehouse] g (NOLOCK) ON f.WarehouseID = g.WarehouseID
      //                      LEFT JOIN [dbo].[TbStorehouse] h (NOLOCK) ON f.StorehouseID = h.StorehouseID
      //                      LEFT JOIN [dbo].[TbDocuments] i (NOLOCK) ON e.DocID = i.DocID
      //                      WHERE COALESCE(e.IsActive, 0) <> 0
      //                          AND COALESCE(i.IsActive, 0) <> 0
      //                          AND i.IsAdvancePay <> 1
      //                          AND (COALESCE(e.ReceQty, 0) - COALESCE(e.ExpoQty, 0)) <> 0
      //                          AND f.StorehouseListID = {0}
      //                          AND i.UpdatedDate < '{2}'
      //                          [@whereCategoryID]
      //                      GROUP BY 
      //                          g.WarehouseID, e.StorehouseListID, h.StorehouseCode, h.StorehouseName, a.ProductCode, a.ProductName
      //                  )
      //                  /* Step 3: การเลือกข้อมูลจาก CTE ที่สร้างขึ้น */
      //                  SELECT 
      //                      a.WarehouseID, a.StorehouseListID, a.StorehouseCode, a.StorehouseName, a.ProductCode, a.ProductName,
      //                      BroughtForwardQty = SUM(a.BroughtForwardQty) + COALESCE(dn.BroughtForwardQty, 0),
						//    ReceQty = COALESCE(a.ReceQty, dn.ReceQty),
						//    ExpoQty = COALESCE(a.ExpoQty, dn.ExpoQty),
						//    BrokenQty = COALESCE(a.BrokenQty, dn.BreakQty),
						//	Price = COALESCE(a.Price, 0)
      //                  INTO #dataLastCurrentDay
      //                  FROM CTE_dataLastCurrentDay a
					 //   FULL JOIN (
						//    SELECT pb.WarehouseID, pb.[StorehouseListID], pb.[ProductCode], pb.[CategoryID], pb.[SubCategoryID], 
						//	    pb.[BroughtForwardQty], pb.[ReceQty], pb.[ExpoQty], pb.[BreakQty], pb.[BalanceQty], pb.[LastUpdate]
						//    FROM [dbo].[UVW_ProductRegionalBroughtForward] pb
						//    WHERE pb.StorehouseListID = {0}
						//	    AND YEAR(pb.LastUpdate) = YEAR(DATEADD(DAY, -1 , @RefDate)) 
      //                          AND CAST(pb.LastUpdate AS DATE) = DATEADD(DAY, -1 , @RefDate)
					 //   ) dn 
					 //   ON a.StorehouseListID = dn.StorehouseListID 
					 //   AND a.WarehouseID = dn.WarehouseID
					 //   AND a.ProductCode = dn.ProductCode
      //                  GROUP BY 
      //                      a.WarehouseID,  a.StorehouseListID, a.StorehouseCode, a.StorehouseName, a.ProductCode, a.ProductName, COALESCE(a.ReceQty, dn.ReceQty),
						//    COALESCE(a.ExpoQty, dn.ExpoQty), COALESCE(a.BrokenQty, dn.BreakQty), COALESCE(a.Price, 0), dn.BroughtForwardQty;

      //                  /* Step 4: CTE สำหรับข้อมูลการตรวจสอบสินค้าสิ้นวัน */
      //                  WITH CTE_EndOfDayChecking AS (
      //                      SELECT a.ProductCode, ProductQty = SUM(COALESCE(a.ProductQty, 0)), CreatedDate = CONVERT(NVARCHAR(10), a.CreatedDate, 25)
      //                      FROM [dbo].[TbEndOfDayChecking] a (NOLOCK)
      //                      INNER JOIN [dbo].[TbStorehouseList] b (NOLOCK) ON a.StorehouseListID = b.StorehouseListID
      //                      WHERE COALESCE(a.IsActive, 0) <> 0
      //                      AND b.StorehouseListID = {0} 
      //                      AND a.CreatedDate >= '{2}' AND a.CreatedDate <  DATEADD(DAY, 1, '{2}')
      //                      GROUP BY a.ProductCode, CONVERT(NVARCHAR(10), a.CreatedDate, 25)
      //                  ),
      //                  /* CTE สำหรับข้อมูลหมายเหตุการตรวจสอบสินค้าสิ้นวัน */
      //                  CTE_EndOfDayRemarks AS (
      //                      SELECT 
      //                          ProductCode, Remark = MAX(a.Remark), CreatedDate = CONVERT(NVARCHAR(10), a.CreatedDate, 25)
      //                      FROM [dbo].[TbEndOfDayChecking] a (NOLOCK)
      //                      INNER JOIN [dbo].[TbStorehouseList] b (NOLOCK) ON a.StorehouseListID = b.StorehouseListID
      //                      WHERE COALESCE(a.IsActive, 0) <> 0
      //                      AND b.StorehouseListID = {0}
      //                      AND a.CreatedDate >= '{2}' AND a.CreatedDate <  DATEADD(DAY, 1, '{2}')
      //                      GROUP BY a.ProductCode, CONVERT(NVARCHAR(10), a.CreatedDate, 25)
      //                  ),
						//CTE_CheckingQty AS (
						//	SELECT 
						//		a.WarehouseID, 
						//		a.StorehouseListID, 
						//		a.StorehouseCode, 
						//		a.StorehouseName, 
						//		a.ProductCode, 
						//		a.ProductName, 
						//		CheckingQty = COALESCE(e.ProductQty, 0), 
						//		RemarkTacking = b.Remark,
						//		ROW_NUMBER() OVER(PARTITION BY a.ProductCode ORDER BY e.CreatedDate DESC) AS RowID
						//	FROM #dataProductsInfo a
						//	LEFT JOIN CTE_EndOfDayChecking e ON a.ProductCode = e.ProductCode
						//	LEFT JOIN CTE_EndOfDayRemarks b ON a.ProductCode = b.ProductCode
						//)
						//SELECT WarehouseID,	StorehouseListID, StorehouseCode,	StorehouseName,	ProductCode, ProductName, CheckingQty, RemarkTacking, RowID
						//INTO #dataCheckingQty
						//FROM CTE_CheckingQty
						//WHERE RowID = 1;

      //                  /* Step 5: CTE สำหรับข้อมูลการตรวจสอบสินค้าวันก่อนหน้า */
      //                  WITH CTE_LastDayChecking AS (
      //                      SELECT a.StorehouseListID, a.ProductCode,
      //                          COALESCE(a.ProductQty, 0) AS ProductQty, a.CreatedDate,
      //                          ROW_NUMBER() OVER(PARTITION BY a.ProductCode ORDER BY a.CreatedDate DESC) AS RowID
      //                      FROM [dbo].[TbEndOfDayChecking] a (NOLOCK)
      //                      INNER JOIN [dbo].[TbStorehouseList] b (NOLOCK) ON a.StorehouseListID = b.StorehouseListID
      //                      WHERE COALESCE(a.IsActive, 0) <> 0
      //                      AND b.StorehouseListID = {0}
      //                      AND a.CreatedDate >= '{1}' AND a.CreatedDate < '{2}'
      //                  )
      //                  /* การเลือกข้อมูลจาก CTEs และการกรองด้วย RowID */
      //                  SELECT a.WarehouseID, a.StorehouseListID, a.StorehouseCode, a.StorehouseName, a.ProductCode, a.ProductName,
      //                      CheckingQty = COALESCE(e.ProductQty, 0)
      //                  INTO #dataLastCheckingQty
      //                  FROM #dataProductsInfo a
      //                  LEFT JOIN CTE_LastDayChecking e ON a.ProductCode = e.ProductCode
      //                  WHERE e.RowID = 1;

						//WITH CTE_AdvancePayment AS (
						//	SELECT e.WarehouseID , e.StorehouseListID, pro.StorehouseCode, pro.StorehouseName 
						//		,DocDate = CONVERT(CHAR(10), a.UpdatedDate,126), pro.ProductCode, pro.ProductName
						//		,AdvanceQty = SUM(COALESCE(b.ExpoQty,0))
						//		,Price = SUM(COALESCE(b.Price, 0))
						//	FROM [dbo].[TbDocuments] a (NOLOCK)
						//		LEFT JOIN [dbo].[TbProductTransactions] b (NOLOCK) ON b.DocID = a.DocID
						//		LEFT JOIN [dbo].[TbDocumentTypes] d (NOLOCK) ON a.DocType = d.TypeID
						//		LEFT JOIN [dbo].[TbStorehouseList] e (NOLOCK) ON b.StorehouseListID = e.StorehouseListID
						//		LEFT JOIN #dataProductsInfo pro ON b.ProductCode = pro.ProductCode
						//	WHERE a.DocType = 11 AND pro.DocType = 11
						//		AND COALESCE(a.IsActive, 0) <> 0 
						//		AND COALESCE(b.IsActive, 0) <> 0
						//		AND e.StorehouseListID = {0}
						//		AND a.UpdatedDate >= '{2}' AND a.UpdatedDate < DATEADD(DAY, 1, '{2}')
						//	GROUP BY e.WarehouseID , e.StorehouseListID, pro.StorehouseCode, pro.StorehouseName,
						//		CONVERT(CHAR(10), a.UpdatedDate,126), pro.ProductCode, pro.ProductName
						//)
      //                  /* Step 6: CTE สำหรับสร้าง #dataLastBroughtSumTack */
      //                  SELECT 
						//	a.WarehouseID, a.StorehouseListID, a.StorehouseCode, a.StorehouseName, a.ProductCode, a.ProductName,
      //                      BroughtForwardBalanceQty = SUM(COALESCE(b.BroughtForwardQty, 0)), 
						//	ReceQty = SUM(COALESCE(a.ReceQty, 0)), 
						//	AdvanceReQty = SUM(COALESCE(ar.AdvanceReQty, 0)), 
						//	AdvancePeQty = SUM(COALESCE(ar.AdvancePeQty, 0)), 
						//	ExpoQty = SUM(COALESCE(a.ExpoQty, 0)) - SUM(COALESCE(adv.AdvanceQty, 0)),
						//	AdvanceQty = SUM(COALESCE(adv.AdvanceQty, 0)), 
						//	BrokenQty = SUM(COALESCE(a.BrokenQty, 0)), 
						//	BalanceQty = (SUM(COALESCE(b.BroughtForwardQty, 0)) + SUM(COALESCE(a.ReceQty, 0)) + SUM(COALESCE(ar.AdvanceReQty, 0))) - (SUM(COALESCE(a.ExpoQty, 0)) + SUM(COALESCE(a.BrokenQty, 0))),
      //                      CheckingQty = SUM(COALESCE(c.CheckingQty, 0)),
      //                      DiffQty = (SUM(COALESCE(c.CheckingQty, 0)) - (SUM(COALESCE(b.BroughtForwardQty, 0)) + ((SUM(COALESCE(a.ReceQty, 0)) + SUM(COALESCE(ar.AdvanceReQty, 0))) - (SUM(COALESCE(a.ExpoQty, 0)) + SUM(COALESCE(a.BrokenQty, 0)))))),
      //                      CarryForwardQty = CASE 
      //                          WHEN SUM(COALESCE(c.CheckingQty, 0)) <> 0 THEN 
      //                              ((SUM(COALESCE(b.BroughtForwardQty, 0)) + SUM(COALESCE(a.ReceQty, 0)) + SUM(COALESCE(ar.AdvanceReQty, 0))) - (SUM(COALESCE(a.ExpoQty, 0)) + SUM(COALESCE(a.BrokenQty, 0)))) + 
      //                              (SUM(COALESCE(c.CheckingQty, 0)) - ((SUM(COALESCE(b.BroughtForwardQty, 0)) + SUM(COALESCE(a.ReceQty, 0))) - (SUM(COALESCE(a.ExpoQty, 0)) + SUM(COALESCE(a.BrokenQty, 0)))))
      //                          ELSE 
      //                              ((SUM(COALESCE(b.BroughtForwardQty, 0)) + SUM(COALESCE(a.ReceQty, 0)) + SUM(COALESCE(ar.AdvanceReQty, 0))) - (SUM(COALESCE(a.ExpoQty, 0)) + SUM(COALESCE(a.BrokenQty, 0))))
      //                      END,
      //                      Price = SUM(a.Price), RemarkTacking = c.RemarkTacking
      //                  INTO #dataLastBroughtSumTack
      //                  FROM #dataProductsMovement a
      //                  LEFT JOIN #dataLastCurrentDay b ON a.ProductCode = b.ProductCode AND a.StorehouseListID = b.StorehouseListID
						//LEFT JOIN #dataAdvanceReturn ar ON a.ProductCode = ar.ProductCode AND a.StorehouseListID = ar.StorehouseListID
      //                  LEFT JOIN #dataCheckingQty c ON a.ProductCode = c.ProductCode AND a.StorehouseListID = c.StorehouseListID 
      //                  LEFT JOIN #dataLastCheckingQty d ON a.ProductCode = d.ProductCode AND a.StorehouseListID = d.StorehouseListID
						//LEFT JOIN CTE_AdvancePayment adv ON a.ProductCode = adv.ProductCode AND a.StorehouseListID = adv.StorehouseListID
						//GROUP BY a.WarehouseID, a.StorehouseListID, a.StorehouseCode, a.StorehouseName, a.ProductCode, a.ProductName, c.RemarkTacking

      //                  /* Step 7: Final select */
      //                  SELECT 
						//    prd.WarehouseCode, prd.WarehouseName, prd.BusinessUnitName, prd.StorehouseTypeName, 
						//    a.StorehouseListID, prd.StorehouseID, a.StorehouseCode, a.StorehouseName, 
						//    prd.BrandCode, prd.BrandName, prd.CategoryName, prd.SubCategoryCode, 
						//    prd.SubCategoryName, a.ProductCode, a.ProductName,
						//    BroughtForwardUnit = dbo.fn_FormatUnit(a.BroughtForwardBalanceQty, c.Conversion),
						//    BroughtForwardBalanceQty = COALESCE(a.BroughtForwardBalanceQty, 0),
						//    BroughtForwardBalanceDiv = CAST(COALESCE(a.BroughtForwardBalanceQty, 0) AS DECIMAL) / NULLIF(CAST(c.Conversion AS DECIMAL), 0),
						//    ReceUnit = dbo.fn_FormatUnit(a.ReceQty, c.Conversion),
						//    a.ReceQty,
						//    ReceDiv = CAST(COALESCE(a.ReceQty, 0) AS DECIMAL) / NULLIF(CAST(c.Conversion AS DECIMAL), 0),
						//    ExpoUnit = dbo.fn_FormatUnit(a.ExpoQty, c.Conversion),
						//    a.ExpoQty,
						//    ExpoDiv = CAST(COALESCE(a.ExpoQty, 0) AS DECIMAL) / NULLIF(CAST(c.Conversion AS DECIMAL), 0),
						//    AdvanceReUnit = dbo.fn_FormatUnit(a.AdvanceReQty, c.Conversion),
						//    a.AdvanceReQty,
						//    AdvanceReDiv = CAST(COALESCE(a.AdvanceReQty, 0) AS DECIMAL) / NULLIF(CAST(c.Conversion AS DECIMAL), 0),
						//    AdvancePeUnit = dbo.fn_FormatUnit(a.AdvancePeQty, c.Conversion),
						//    a.AdvancePeQty,
						//    AdvancePeDiv = CAST(COALESCE(a.AdvancePeQty, 0) AS DECIMAL) / NULLIF(CAST(c.Conversion AS DECIMAL), 0),
						//    BrokenUnit = dbo.fn_FormatUnit(a.BrokenQty, c.Conversion),
						//    a.BrokenQty,
						//    BrokenDiv = CAST(COALESCE(a.BrokenQty, 0) AS DECIMAL) / NULLIF(CAST(c.Conversion AS DECIMAL), 0),
						//    AdvanceUnit = dbo.fn_FormatUnit(a.AdvanceQty, c.Conversion),
						//    a.AdvanceQty,
						//    AdvanceDiv = CAST(COALESCE(a.AdvanceQty, 0) AS DECIMAL) / NULLIF(CAST(c.Conversion AS DECIMAL), 0),
						//    BalanceUnit = dbo.fn_FormatUnit(a.BalanceQty, c.Conversion),
						//    BalanceQty = COALESCE(a.BalanceQty, 0),
						//    BalanceDiv = CAST(COALESCE(a.BalanceQty, 0) AS DECIMAL) / NULLIF(CAST(c.Conversion AS DECIMAL), 0),
						//    CheckingUnit = dbo.fn_FormatUnit(a.CheckingQty, c.Conversion),
						//    CheckingQty = a.CheckingQty,
						//    CheckingDiv = CAST(COALESCE(a.CheckingQty, 0) AS DECIMAL) / NULLIF(CAST(c.Conversion AS DECIMAL), 0),
						//    DiffUnit = dbo.fn_FormatUnit(a.DiffQty, c.Conversion),
						//    DiffQty = a.DiffQty,
						//    DiffDiv = CAST(COALESCE(a.DiffQty, 0) AS DECIMAL) / NULLIF(CAST(c.Conversion AS DECIMAL), 0),
						//    CarryForwardUnit = dbo.fn_FormatUnit(a.CarryForwardQty, c.Conversion),
						//    CarryForwardQty,
						//    CarryForwardDiv = CAST(COALESCE(a.CarryForwardQty, 0) AS DECIMAL) / NULLIF(CAST(c.Conversion AS DECIMAL), 0),
						//    c.Conversion,
						//    ProductPrice = a.Price,
						//    StockUnitName = CONCAT(b.StockUnitName, CASE WHEN c.Conversion > 1 THEN CONCAT('-', c.Conversion) ELSE '' END),
						//    a.RemarkTacking
					 //   FROM #dataLastBroughtSumTack a
					 //   INNER JOIN #dataProductInfoMaster prd ON a.ProductCode = prd.ProductCode AND a.StorehouseListID = prd.StorehouseListID
					 //   INNER JOIN [dbo].[TbStockUnit] b ON prd.UnitID = b.StockUnitID
					 //   INNER JOIN [dbo].[TbConversion] c ON prd.ConversionID = c.ConversionID 
					 //   ORDER BY 
						//    CAST(a.ReceQty AS INT) DESC, CAST(a.ExpoQty AS INT) DESC, CAST(a.BrokenQty AS INT) DESC;                   
      //              ";


                }
                catch (Exception ex)
                {

                    throw;
                }
            }

            return movementReportRes;   
        }

        AdvanceReportRes IReport.GetAdvanceReportBC(AdvanceReportReq req)
        {
            AdvanceReportRes advanceReportRes = new AdvanceReportRes();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {

      //              string strSQL = @"
      //                  SET NOCOUNT ON;

      //                  /* Drop temporary tables if they exist */
      //                  DECLARE @tempTables TABLE (TableName NVARCHAR(4000));
      //                  INSERT INTO @tempTables (TableName)
      //                  VALUES 
      //                      ('#dataAccessControl'),
      //                      ('#dataFromStorehouse'),
      //                      ('#dataToStorehouse'),
      //                      ('#dataWorkFlowTransactions'),
      //                      ('#dataDocumentAdvancePayment'),
      //                      ('#dataReceiptAdvancePayAmount'),
      //                      ('#dataReceiptReturnPayment'),
      //                      ('#dataDocumentReturnPayment'),
      //                      ('#dataDocumentOrderPayment'),
      //                      ('#dataSumAdvancePayAmount'),
      //                      ('#dataAdvancePaymentWorkflow');
      //                  DECLARE @strSQL NVARCHAR(MAX) = '';
      //                  SELECT @strSQL = @strSQL + 'IF OBJECT_ID(''tempdb..' + TableName + ''') IS NOT NULL DROP TABLE ' + TableName + '; '
      //                  FROM @tempTables;
      //                  EXEC sp_executesql @strSQL;

      //                  /* Create temporary table for access control data */
      //                  SELECT a.UserID, e.CompCode, d.CompID, a.GroupID, f.GroupName, a.WarehouseID, a.StorehouseListID, b.StorehouseTypeID, 
      //                      bh.BranchName, b.BusinessUnitID, d.IsActive 
      //                  INTO #dataAccessControl
      //                  FROM [dbo].[TbMetaUser] a (NOLOCK) 
      //                  INNER JOIN [dbo].[TbStorehouseList] b (NOLOCK) on a.StorehouseListID = b.StorehouseListID
      //                  INNER JOIN [dbo].[TbStorehouse] c (NOLOCK) on b.StorehouseID = c.StorehouseID
      //                  INNER JOIN [dbo].[TbWarehouse] d (NOLOCK) on b.WarehouseID = d.WarehouseID
						//LEFT JOIN [dbo].[TbBranchs] bh (NOLOCK) ON d.BranchID = bh.BranchID
      //                  INNER JOIN [dbo].[TbCompanyProfile] e (NOLOCK) on d.CompID = e.CompID
      //                  INNER JOIN [dbo].[TbCompanyGroups] f (NOLOCK) on e.GroupID = f.GroupID
      //                  INNER JOIN [dbo].[TbUsers] g (NOLOCK) on a.UserID = g.UserID
      //                  WHERE g.IsActive = 1						
      //                  AND e.CompCode= '{0}'
      //                  AND a.UserID = {1};
      //                  /* Create index on #dataAccessControl table */
      //                  CREATE NONCLUSTERED INDEX idx_dataAccessControl ON #dataAccessControl (StorehouseListID, CompID, UserID)
      //                  INCLUDE (BusinessUnitID, IsActive);

      //                  WITH CTE_dataAdvancePaymentByTransaction AS (
      //                          SELECT a.DocID, c.DocCode, a.WorkFlowStatusId, UserID = a.UpdatedBy,
		    //                        AdvPayApprover = CONCAT (d.FirstName,' ',d.LastName),
      //                              WorkFlowStatusName = CASE
      //                                  WHEN a.WorkFlowStatusId IS NULL OR a.WorkFlowStatusId = 2 THEN 'Pending'
      //                                  WHEN a.WorkFlowStatusId = 1 THEN 'Approve'
      //                                  WHEN a.WorkFlowStatusId = 3 THEN 'Cancel'
      //                                  WHEN a.WorkFlowStatusId = 4 THEN 'Reject'
      //                                  ELSE 'N/A'
      //                              END,
      //                              ROW_NUMBER() OVER (PARTITION BY a.DocID ORDER BY a.WorkFlowTransactionsId DESC) AS RowID
      //                      FROM [dbo].[TbWorkFlowTransactions] a(NOLOCK)
	     //                   LEFT JOIN [dbo].[TbWorkFlowStatus] b(NOLOCK) ON a.WorkFlowStatusId = b.WorkFlowStatusId
	     //                   INNER JOIN [dbo].[TbDocuments] c(NOLOCK) ON a.DocId = c.DocID
	     //                   LEFT JOIN [dbo].[TbUsers] d(NOLOCK) ON a.UpdatedBy = d.UserID
	     //                   LEFT JOIN [dbo].[TbWorkFlow] e(NOLOCK) ON a.WorkFlowId = e.WorkFlowId
	     //                   LEFT JOIN [dbo].[TbStorehouseList] f(NOLOCK) ON e.StorehouseListID = f.StorehouseListID
	     //                   LEFT JOIN [dbo].[TbWarehouse] g(NOLOCK) ON f.WarehouseID = g.WarehouseID
	     //                   INNER JOIN #dataAccessControl h(NOLOCK) ON c.FromStorehouseListID = h.StorehouseListID
      //                      WHERE c.DocType = {2}
      //                      AND CAST(c.CreatedDate AS DATE) >= '{3}' AND  CAST(c.CreatedDate AS DATE) <= '{4}'
      //                  )
      //                  SELECT DocID, DocCode, UserID, AdvPayApprover, WorkFlowStatusId, WorkFlowStatusName
      //                  INTO #dataAdvancePaymentWorkflow
      //                  FROM CTE_dataAdvancePaymentByTransaction
      //                  WHERE RowID = 1;
 
      //                  SELECT StorehouseListID = a.FromStorehouseListID
	     //                   ,a.DocID, a.DocCode, a.DocType
	     //                   ,ExpoQty = sum(COALESCE(c.ExpoQty, 0))
	     //                   ,IsDocStatusAdvancePay = CASE 
		    //                    WHEN a.DocStatusID = 1 AND a.IsActive = 0 THEN 'New'
		    //                    WHEN a.DocStatusID = 2 AND a.IsActive = 0 THEN 'In-Progress'
		    //                    WHEN a.DocStatusID = 3 AND a.IsActive = 0 THEN 'Cancel'
		    //                    WHEN a.DocStatusID = 4 AND a.IsActive = 0 THEN 'Reject'
		    //                    WHEN a.DocStatusID = 5 AND a.IsActive = 1 THEN 'Success'
	     //                   END
      //                  INTO #dataDocumentAdvancePayment
      //                  FROM [dbo].[TbDocuments] a (NOLOCK)
      //                  LEFT JOIN (
	     //                   SELECT sl.StorehouseListID, sh.StorehouseID, sh.StorehouseCode, sh.StorehouseName
	     //                   FROM [dbo].[TbStorehouse] sh(NOLOCK)
	     //                   INNER JOIN (
		    //                    SELECT a.StorehouseListID, a.StorehouseID
		    //                    FROM [dbo].[TbStorehouseList] a(NOLOCK)
		    //                    INNER JOIN #dataAccessControl h(NOLOCK) ON a.StorehouseListID = h.StorehouseListID
	     //                   ) sl ON sl.StorehouseID = sh.StorehouseID
      //                  ) shaa ON (shaa.StorehouseListID = a.FromStorehouseListID)
      //                  INNER JOIN (
	     //                   SELECT a.WarehouseID, a.WarehouseCode, a.CompID
	     //                   FROM [dbo].[TbWarehouse] a (NOLOCK)	                        
      //                  ) b ON a.WarehouseID = b.WarehouseID
      //                  INNER JOIN (
	     //                   SELECT a.DocID, a.ProductCode, a.ExpoQty
	     //                   FROM TbProductTransactions a (NOLOCK)
	     //                   INNER JOIN #dataAccessControl h (NOLOCK) ON a.StorehouseListID = h.StorehouseListID
      //                  ) c ON a.DocID = c.DocID
      //                  INNER JOIN #dataAccessControl h(NOLOCK) ON shaa.StorehouseListID = h.StorehouseListID
      //                  WHERE 1=1
      //                  AND a.DocType = 11 /*ใบทดรองจ่าย*/
      //                  AND CAST(a.CreatedDate AS DATE) >= '{3}' AND CAST(a.CreatedDate AS DATE) <= '{4}'
      //                  GROUP BY a.DocID, a.DocCode, a.DocType, a.FromStorehouseListID, a.DocStatusID, a.IsActive; 
      //                  /* Create indices to improve the performance of queries on the related temporary tables */
      //                  CREATE NONCLUSTERED INDEX idx_dataDocumentAdvancePayStatus ON #dataDocumentAdvancePayment (StorehouseListID, DocCode);

      //                  /* เริ่ม รายการอ้างอิงจากการทดรองจ่าย รายการคืน */
      //                  WITH CTE_AdvanceReceipt AS (
      //                      SELECT a.StorehouseListID, b.DocCode, b.RefCode, b.DocType,
      //                          ReceQty = CASE WHEN b.DocStatusID = 5 THEN SUM(COALESCE(a.ReceQty, 0)) ELSE 0 END
      //                      FROM [dbo].[TbProductTransactions] a (NOLOCK)
      //                      LEFT JOIN (
      //                          SELECT a.DocID, a.DocCode, a.RefCode, a.DocType, a.DocStatusID, a.WarehouseID, a.CompID, 
			   //                     DocDate = CAST(a.DocDate AS DATE), CreatedDate = CAST(a.CreatedDate AS DATE)
      //                          FROM [dbo].[TbDocuments] a (NOLOCK)
		    //                    INNER JOIN #dataAccessControl acc ON a.ToStorehouseListID = acc.StorehouseListID
      //                          WHERE DocType = 6
			   //                     AND CAST(a.CreatedDate AS DATE) >= '{3}'
      //                      ) b ON a.DocID = b.DocID
      //                      INNER JOIN [dbo].[TbWarehouse] c (NOLOCK) ON b.WarehouseID = c.WarehouseID
      //                      INNER JOIN #dataDocumentAdvancePayment dt ON dt.DocCode = b.RefCode
      //                      INNER JOIN [dbo].[TbDocumentTypes] dm (NOLOCK) ON dm.TypeID = b.DocType 
		    //                    AND dm.IsReceiver = 1 
		    //                    AND COALESCE(dm.IsActive, 0) <> 0
      //                      GROUP BY a.StorehouseListID, b.DocCode, b.RefCode, b.DocType, b.DocStatusID
      //                  ), 
      //                  CTE_DocumentStatus AS (
      //                      SELECT 
      //                          a.StorehouseListID, b.DocCode, b.RefCode, b.DocType,
      //                          AdvanceReceiptIsDocStatus = b.DocStatus
      //                      FROM [dbo].[TbProductTransactions] a (NOLOCK)
      //                      LEFT JOIN (
      //                          SELECT a.DocID, a.DocCode, a.RefCode, a.DocType, a.DocStatus, a.WarehouseID, a.CompID, 
			   //                     DocDate = CAST(a.DocDate AS DATE), CreatedDate = CAST(a.CreatedDate AS DATE), a.IsActive
      //                          FROM [dbo].[TbDocuments] a (NOLOCK)
		    //                    INNER JOIN #dataAccessControl acc ON a.ToStorehouseListID = acc.StorehouseListID
      //                          WHERE a.DocType = 6 
			   //                     AND COALESCE(a.IsActive, 0) <> 0
			   //                     AND CAST(a.CreatedDate AS DATE) >= '{3}'
      //                      ) b ON a.DocID = b.DocID
      //                      INNER JOIN [dbo].[TbWarehouse] c (NOLOCK) ON b.WarehouseID = c.WarehouseID
      //                      INNER JOIN #dataDocumentAdvancePayment dt ON dt.DocCode = b.RefCode
      //                      INNER JOIN [dbo].[TbDocumentTypes] dm (NOLOCK) ON dm.TypeID = b.DocType 
		    //                    AND dm.IsReceiver = 1 
		    //                    AND COALESCE(dm.IsActive, 0) <> 0
      //                      INNER JOIN #dataAccessControl h (NOLOCK) ON a.StorehouseListID = h.StorehouseListID
      //                      WHERE COALESCE(a.IsActive, 0) <> 0
      //                      GROUP BY a.StorehouseListID, b.DocCode, b.RefCode, b.DocType, b.DocStatus
      //                  )
      //                  SELECT a.StorehouseListID, a.DocCode, a.RefCode, a.DocType, a.ReceQty,
      //                      AdvanceReceiptIsDocStatus = COALESCE(b.AdvanceReceiptIsDocStatus, 'Cancel')
      //                  INTO #dataReceiptAdvancePayAmount
      //                  FROM CTE_AdvanceReceipt a
      //                  LEFT JOIN CTE_DocumentStatus b ON a.DocCode = b.DocCode AND a.StorehouseListID = b.StorehouseListID;
      //                  CREATE NONCLUSTERED INDEX idx_dataReceiptAdvancePayAmount ON [dbo].[#dataReceiptAdvancePayAmount] ([StorehouseListID],[DocCode])
      //                  INCLUDE ([RefCode],[DocType],[ReceQty],[AdvanceReceiptIsDocStatus])

      //                  /* สร้าง temp table #dataReceiptReturnPayment */
      //                  SELECT 
      //                      DocID = convert(VARCHAR(20), b.DocID),
      //                      b.DocCode, RefCode = a.RefCode, a.DocType,
      //                      StorehouseListID = b.ToStorehouseListID,
      //                      a.AdvanceReceiptIsDocStatus,
      //                      ReceQty = CASE WHEN b.DocStatusID = 5 AND b.IsActive = 1 THEN COALESCE(a.ReceQty, 0) ELSE 0 END,
	     //                   DocStatusID = CASE 
      //                          WHEN b.DocStatusID = 1 AND b.IsActive = 0 THEN 1
      //                          WHEN b.DocStatusID = 2 AND b.IsActive = 0 THEN 2
      //                          WHEN b.DocStatusID = 3 AND b.IsActive = 0 THEN 3
      //                          WHEN b.DocStatusID = 4 AND b.IsActive = 0 THEN 4
      //                          WHEN b.DocStatusID = 5 AND b.IsActive = 1 THEN 5
      //                      END,
      //                      IsDocStatus = CASE 
      //                          WHEN b.DocStatusID = 1 AND b.IsActive = 0 THEN 'New'
      //                          WHEN b.DocStatusID = 2 AND b.IsActive = 0 THEN 'In-Progress'
      //                          WHEN b.DocStatusID = 3 AND b.IsActive = 0 THEN 'Cancel'
      //                          WHEN b.DocStatusID = 4 AND b.IsActive = 0 THEN 'Reject'
      //                          WHEN b.DocStatusID = 5 AND b.IsActive = 1 THEN 'Success'
      //                      END,
      //                      ROW_NUMBER() OVER (PARTITION BY a.StorehouseListID, a.RefCode ORDER BY a.RefCode DESC) AS RowID
      //                  INTO #dataReceiptReturnPayment
      //                  FROM #dataReceiptAdvancePayAmount a
      //                  LEFT JOIN (
      //                      SELECT a.DocID, a.DocCode, a.TranferCode, a.DocType, a.DocStatusID, a.WarehouseID, a.CompID, 
		    //                    h.CompCode, a.CreatedDate, a.DocDate, a.IsActive, a.ToStorehouseListID
      //                      FROM [dbo].[TbDocuments] a (NOLOCK)
      //                      INNER JOIN #dataAccessControl h (NOLOCK) ON ToStorehouseListID = h.StorehouseListID
      //                      WHERE CAST(CreatedDate AS DATE) >= '{3}'
      //                  ) b ON a.DocCode = b.DocCode 
	     //                   AND b.ToStorehouseListID = a.StorehouseListID
      //                  WHERE b.DocType = 6;
      //                  CREATE NONCLUSTERED INDEX idx_dataReceiptReturnPayment ON #dataReceiptReturnPayment (StorehouseListID, RefCode);

      //                  WITH CTE_ReceiptReturnPayment AS (
      //                      SELECT 
      //                          StorehouseListID, 
      //                          RefCode,
      //                          DocID,
      //                          DocCode,
      //                          DocStatusID,
      //                          IsDocStatus,
      //                          ReceQty,
      //                          RowID
      //                      FROM #dataReceiptReturnPayment							
      //                  )
      //                  SELECT
      //                      RefDocID = STUFF(
      //                          (SELECT ', ' + CAST(sub.DocID AS NVARCHAR(MAX))
      //                           FROM CTE_ReceiptReturnPayment sub
      //                           WHERE sub.StorehouseListID = main.StorehouseListID 
      //                             AND sub.RefCode = main.RefCode
      //                           ORDER BY sub.DocCode  /* เรียงลำดับ DocCode ให้ถูกต้อง */
      //                           FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, ''),    
      //                      RefReturnPayment = STUFF(
      //                          (SELECT ', ' + sub.DocCode
      //                           FROM CTE_ReceiptReturnPayment sub
      //                           WHERE sub.StorehouseListID = main.StorehouseListID 
      //                             AND sub.RefCode = main.RefCode
      //                           ORDER BY sub.DocCode  /* เรียงลำดับ DocCode ให้ถูกต้อง */
      //                           FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, ''),   
      //                      DocStatusID = STUFF(
      //                          (SELECT ', ' + CAST(sub.DocStatusID AS NVARCHAR(MAX))
      //                           FROM CTE_ReceiptReturnPayment sub
      //                           WHERE sub.StorehouseListID = main.StorehouseListID 
      //                             AND sub.RefCode = main.RefCode
      //                           ORDER BY sub.DocCode  /* เรียงลำดับตาม DocCode */
      //                           FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, ''),  
      //                      IsDocStatus = STUFF(
      //                          (SELECT ', ' + sub.IsDocStatus
      //                           FROM CTE_ReceiptReturnPayment sub
      //                           WHERE sub.StorehouseListID = main.StorehouseListID 
      //                             AND sub.RefCode = main.RefCode
      //                           ORDER BY sub.DocCode  /* เรียงลำดับตาม DocCode */
      //                           FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, ''),
      //                      ReceQty = (SELECT SUM(sub.ReceQty)
      //                                 FROM CTE_ReceiptReturnPayment sub
      //                                 WHERE sub.StorehouseListID = main.StorehouseListID 
      //                                   AND sub.RefCode = main.RefCode),
      //                      main.DocType, 
      //                      main.StorehouseListID, 
      //                      main.RefCode,    
      //                      RowCountx = STUFF(
      //                          (SELECT ', ' + CAST(sub.RowID AS NVARCHAR(10))
      //                           FROM CTE_ReceiptReturnPayment sub
      //                           WHERE sub.StorehouseListID = main.StorehouseListID 
      //                             AND sub.RefCode = main.RefCode                                 
      //                           FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, '')    
      //                  INTO #dataDocumentReturnPayment
      //                  FROM #dataReceiptReturnPayment main
      //                  WHERE main.RowID = 1;

      //                  /* สร้างดัชนีเพื่อเพิ่มประสิทธิภาพการค้นหา */
      //                  CREATE NONCLUSTERED INDEX idx_dataDocumentReturnPaymentRefCode ON #dataDocumentReturnPayment (RefCode);
      //                  CREATE NONCLUSTERED INDEX idx_dataDocumentReturnPayment ON #dataDocumentReturnPayment (RefCode) INCLUDE (RefDocID, RefReturnPayment, IsDocStatus, RowCountx, ReceQty);
      //                  /* สิ้นสุด รายการอ้างอิงจากการทดรองจ่าย รายการคืน */

      //                  /* เริ่ม รายการอ้างอิงจากการทดรองจ่าย รายการคืน */
      //                  WITH CTE_AdvancePayAmount AS (
      //                      SELECT 
      //                          a.StorehouseListID, b.RefCode, b.DocType,
      //                          DocID = CONVERT(VARCHAR(20), b.DocID),
      //                          Description = COALESCE(b.Description, b.DocCode),
      //                          ExpoQty = CASE 
      //                              WHEN b.DocStatusID = 5 AND b.IsActive = 1 THEN SUM(COALESCE(a.ExpoQty, 0)) ELSE 0 END,
		    //                    IsDocStatusID = CASE
						//                        WHEN b.DocStatusID = 1 AND b.IsActive = 0 THEN 1
						//                        WHEN b.DocStatusID = 2 AND b.IsActive = 0 THEN 2
						//                        WHEN b.DocStatusID = 3 AND b.IsActive = 0 THEN 3
						//                        WHEN b.DocStatusID = 4 AND b.IsActive = 0 THEN 4
						//                        WHEN b.DocStatusID = 5 AND b.IsActive = 1 THEN 5
						//                        ELSE NULL
					 //                       END,
		    //                    IsDocStatusName = CASE
						//                        WHEN b.DocStatusID = 1 AND b.IsActive = 0 THEN 'New'
						//                        WHEN b.DocStatusID = 2 AND b.IsActive = 0 THEN 'In-Progress'
						//                        WHEN b.DocStatusID = 3 AND b.IsActive = 0 THEN 'Cancel'
						//                        WHEN b.DocStatusID = 4 AND b.IsActive = 0 THEN 'Reject'
						//                        WHEN b.DocStatusID = 5 AND b.IsActive = 1 THEN 'Success'
						//                        ELSE NULL
					 //                       END,
      //                          ROW_NUMBER() OVER (PARTITION BY a.StorehouseListID, b.RefCode, b.Description ORDER BY b.RefCode) AS RowID
      //                      FROM [dbo].[TbProductTransactions] a(NOLOCK)
      //                      INNER JOIN (
      //                          SELECT a.DocID, a.DocCode, a.RefCode, a.DocType, a.DocStatusID, a.WarehouseID, a.CompID, 
			   //                     a.DocDate, a.IsActive, a.Description
      //                          FROM [dbo].[TbDocuments] a(NOLOCK)
      //                          INNER JOIN #dataAccessControl b (NOLOCK) ON a.FromStorehouseListID = b.StorehouseListID
      //                          WHERE CAST(a.CreatedDate AS DATE) >= '{3}'
      //                      ) b ON a.DocID = b.DocID
      //                      AND b.DocType <> 11
      //                      INNER JOIN [dbo].[TbWarehouse] c(NOLOCK) ON b.WarehouseID = c.WarehouseID
      //                      INNER JOIN #dataDocumentAdvancePayment dt ON dt.DocCode = b.RefCode
      //                      INNER JOIN [dbo].[TbDocumentTypes] dm(NOLOCK) ON dm.TypeID = b.DocType
      //                          AND dm.IsReceiver = 0
      //                          AND COALESCE(dm.IsActive, 0) <> 0
      //                      INNER JOIN #dataAccessControl h(NOLOCK) ON a.StorehouseListID = h.StorehouseListID
      //                      WHERE 1 = 1
      //                          AND CAST(a.CreatedDate AS DATE) >= '{3}'
      //                      GROUP BY a.StorehouseListID, b.RefCode, b.DocType, b.DocCode, b.Description, b.DocStatusID, b.IsActive, b.DocID
      //                  )
      //                  /* สร้าง temp table #dataDocumentOrderPayment */
      //                  SELECT 
      //                      main.StorehouseListID, main.RefCode, main.DocType,
      //                      RefDocID = STUFF((SELECT ', ' + sub.DocID
      //                                          FROM CTE_AdvancePayAmount sub
      //                                          WHERE sub.StorehouseListID = main.StorehouseListID AND sub.RefCode = main.RefCode 
      //                                          FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, ''),
      //                      RefCodeOrderPayment = STUFF((SELECT DISTINCT ', ' + Description
      //                                          FROM CTE_AdvancePayAmount sub
      //                                          WHERE sub.StorehouseListID = main.StorehouseListID AND sub.RefCode = main.RefCode 
      //                                          FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, ''),
	     //                   DocStatusID = STUFF((SELECT ', ' + CAST(IsDocStatusID AS NVARCHAR(MAX))
      //                                              FROM CTE_AdvancePayAmount sub
      //                                              WHERE sub.StorehouseListID = main.StorehouseListID AND sub.RefCode = main.RefCode 
      //                                              FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, ''),
      //                      IsDocStatus = STUFF((SELECT ', ' + IsDocStatusName
      //                                              FROM CTE_AdvancePayAmount sub
      //                                              WHERE sub.StorehouseListID = main.StorehouseListID AND sub.RefCode = main.RefCode 
      //                                              FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, ''),
      //                      RowCountx = STUFF((SELECT ', ' + CAST(RowID AS NVARCHAR(10))
      //                                          FROM CTE_AdvancePayAmount sub
      //                                          WHERE sub.StorehouseListID = main.StorehouseListID AND sub.RefCode = main.RefCode 
      //                                          FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)'), 1, 2, ''),
      //                      ExpoQty = SUM(COALESCE(main.ExpoQty, 0)) 
      //                  INTO #dataDocumentOrderPayment
      //                  FROM CTE_AdvancePayAmount main
      //                  WHERE main.RowID = 1  /* เลือกแถวที่ RowID = 1 เพื่อหลีกเลี่ยงข้อมูลที่ซ้ำกัน */
      //                  GROUP BY main.StorehouseListID, main.RefCode, main.DocType;
      //                  /* สร้างดัชนีเพื่อเพิ่มประสิทธิภาพการค้นหา */
      //                  CREATE NONCLUSTERED INDEX idx_dataDocumentOrderPayment ON #dataDocumentOrderPayment (RefCode)
      //                  INCLUDE (RefDocID, RefCodeOrderPayment, IsDocStatus, RowCountx, ExpoQty);
      //                  /*สิ้นสุด รายการอ้างอิงจากการจ่ายหรือเผยแพร่ รายการตัด*/

      //                  SELECT a.StorehouseListID, a.DocCode, a.DocType, a.RefCodeOrderPayment, a.RefDocID, a.IsDocStatus, a.ExpoQty,	
	     //                   a.Receipt, a.SumAdvancePayAmount, a.AdvanceReceiptDocID, a.AdvanceReceiptDocCode, a.AdvanceReceiptIsDocStatus,	
	     //                   a.AdvanceReceiptRowCountx, a.RowID
      //                  INTO #dataSumAdvancePayAmount
      //                  FROM (
	     //                   SELECT a.StorehouseListID, a.DocCode, a.DocType, dtexpose.RefCodeOrderPayment
		    //                    ,dtexpose.RefDocID, dtexpose.IsDocStatus
		    //                    ,ExpoQty = SUM(a.ExpoQty), Receipt = SUM(dtreceipt.ReceQty)
		    //                    ,SumAdvancePayAmount = (SUM(a.ExpoQty) - (SUM(COALESCE(dtreceipt.ReceQty, 0)) + SUM(COALESCE(dtexpose.ExpoQty, 0))))
		    //                    ,AdvanceReceiptDocID = dtreceipt.RefDocID
		    //                    ,AdvanceReceiptDocCode = dtreceipt.RefReturnPayment
		    //                    ,AdvanceReceiptIsDocStatus = dtreceipt.IsDocStatus
		    //                    ,AdvanceReceiptRowCountx = dtreceipt.RowCountx
		    //                    ,ROW_NUMBER() OVER (PARTITION BY a.StorehouseListID, a.DocCode ORDER BY a.DocCode DESC) AS RowID
	     //                   FROM #dataDocumentAdvancePayment a
	     //                   LEFT JOIN #dataDocumentReturnPayment dtreceipt ON dtreceipt.RefCode = a.DocCode
	     //                   LEFT JOIN #dataDocumentOrderPayment dtexpose ON dtexpose.RefCode = a.DocCode
	     //                   LEFT JOIN #dataAccessControl h(NOLOCK) ON a.StorehouseListID = h.StorehouseListID
	     //                   WHERE 1 = 1
	     //                   GROUP BY a.StorehouseListID, a.DocCode, a.DocType, dtexpose.RefCodeOrderPayment, dtexpose.RefDocID,
		    //                    dtexpose.IsDocStatus, dtreceipt.RefDocID, dtreceipt.RefReturnPayment, dtreceipt.IsDocStatus, dtreceipt.RowCountx
      //                  ) a
      //                  WHERE a.RowID = 1;
      //                  CREATE NONCLUSTERED INDEX idx_dataSumAdvancePayAmount ON [dbo].[#dataSumAdvancePayAmount] ([StorehouseListID],[DocCode])
      //                  INCLUDE ([RefCodeOrderPayment],[RefDocID],[IsDocStatus],[SumAdvancePayAmount],[AdvanceReceiptDocID],[AdvanceReceiptDocCode],[AdvanceReceiptIsDocStatus],[AdvanceReceiptRowCountx]);

      //                  /* Create Temporary for Source Storehouse  */
      //                  SELECT sl.StorehouseListID, sh.StorehouseID, sh.StorehouseCode, sh.StorehouseName, sl.StorehouseTypeID, st.StorehouseTypeName, h.BranchName,
	     //                   sl.BusinessUnitID, bu.BusinessUnitName, sh.GoodsTypeID, gt.GoodsTypeName, sh.IsFlagTBL, sh.IsProvince, sh.IsCentre, sh.IsFactories
      //                  INTO #dataFromStorehouse
      //                  FROM [dbo].[TbStorehouse] sh(NOLOCK)
      //                  INNER JOIN [dbo].[TbStorehouseList] sl(NOLOCK) ON sl.StorehouseID = sh.StorehouseID
      //                  INNER JOIN [dbo].[TbStorehouseType] st(NOLOCK) ON sl.StorehouseTypeID = st.StorehouseTypeID
      //                  INNER JOIN [dbo].[TbBusinessUnit] bu(NOLOCK) ON sl.BusinessUnitID = bu.BusinessUnitID
      //                  INNER JOIN [dbo].[TbGoodsTypes] gt(NOLOCK) ON sh.GoodsTypeID = gt.GoodsTypeID
      //                  INNER JOIN #dataAccessControl h(NOLOCK) ON sl.StorehouseListID = h.StorehouseListID;

      //                  CREATE NONCLUSTERED INDEX idx_dataFromStorehouse
						//ON [dbo].[#dataFromStorehouse] ([StorehouseListID])
						//INCLUDE ([StorehouseCode],[StorehouseName],[BranchName],[GoodsTypeID],[GoodsTypeName],[IsFlagTBL],[IsProvince],[IsCentre],[IsFactories])

      //                  /* Create Temporary for Destination Storehouse */
      //                  SELECT sl.StorehouseListID, sh.StorehouseID, sh.StorehouseCode, sh.StorehouseName, sl.StorehouseTypeID, st.StorehouseTypeName, bh.BranchName,
	     //                   sl.BusinessUnitID, bu.BusinessUnitName, sh.GoodsTypeID, gt.GoodsTypeName, sh.IsFlagTBL, sh.IsProvince, sh.IsCentre, sh.IsFactories
      //                  INTO #dataToStorehouse
      //                  FROM [dbo].[TbStorehouse] sh(NOLOCK)
      //                  INNER JOIN [dbo].[TbStorehouseList] sl(NOLOCK) ON sl.StorehouseID = sh.StorehouseID
      //                  INNER JOIN [dbo].[TbStorehouseType] st(NOLOCK) ON sl.StorehouseTypeID = st.StorehouseTypeID
      //                  INNER JOIN [dbo].[TbBusinessUnit] bu(NOLOCK) ON sl.BusinessUnitID = bu.BusinessUnitID
      //                  INNER JOIN [dbo].[TbGoodsTypes] gt(NOLOCK) ON sh.GoodsTypeID = gt.GoodsTypeID
      //                  LEFT JOIN [dbo].[TbWarehouse] wh (NOLOCK) ON sl.WarehouseID = wh.WarehouseID
						//LEFT JOIN [dbo].[TbBranchs] bh (NOLOCK) ON wh.BranchID = bh.BranchID;

      //                  CREATE NONCLUSTERED INDEX idx_dataToStorehouse
						//ON [dbo].[#dataToStorehouse] ([StorehouseListID])
						//INCLUDE ([StorehouseCode],[StorehouseName],[BranchName],[GoodsTypeID],[GoodsTypeName],[IsFlagTBL],[IsProvince],[IsCentre],[IsFactories])

      //                  /* สำหรับการจัดการกับ TbWorkFlowTransactions */
      //                  SELECT a.DocID, a.WorkFlowId, a.WorkFlowStatusId, a.WorkFlowStatusName, 
	     //                   a.UpdatedDate, a.Signature, a.UserName, a.ApproveListId, a.RowID
      //                  INTO #dataWorkFlowTransactions
      //                  FROM (
      //                      SELECT a.DocID, a.WorkFlowId, a.WorkFlowStatusId, c.WorkFlowStatusName,
      //                          UpdatedDate = CASE 
      //                                              WHEN a.ApproveListId = 2 THEN CONVERT(VARCHAR(10), CONVERT(DATETIME, e.UpdatedDate, 102), 126) 
      //                                              ELSE CONVERT(VARCHAR(10), CONVERT(DATETIME, a.UpdatedDate, 102), 126) 
      //                                          END,
      //                          UserName = CASE 
      //                                          WHEN a.ApproveListId = 2 THEN f.FirstName + ' ' + f.LastName 
      //                                          ELSE d.FirstName + ' ' + d.LastName 
      //                                      END,
      //                          Signature = CASE 
      //                                          WHEN a.ApproveListId = 2 THEN e.Signature 
      //                                          ELSE d.Signature 
      //                                      END,
      //                          a.ApproveListId,
      //                          ROW_NUMBER() OVER (PARTITION BY a.DocID ORDER BY a.WorkFlowTransactionsId DESC) AS RowID
      //                      FROM [dbo].[TbWorkFlowTransactions] a (NOLOCK)
      //                      INNER JOIN [dbo].[TbWorkFlow] b (NOLOCK) ON a.WorkFlowId = b.WorkFlowId
      //                      LEFT JOIN [dbo].[TbWorkFlowStatus] c (NOLOCK) ON a.WorkFlowStatusId = c.WorkFlowStatusId
      //                      LEFT JOIN [dbo].[TbUsers] d (NOLOCK) ON a.UpdatedBy = d.UserID
      //                      INNER JOIN [dbo].[TbDocuments] e (NOLOCK) ON a.DocID = e.DocID
      //                      LEFT JOIN (
      //                          SELECT a.DocID, a.UpdatedDate, c.FirstName, c.LastName, c.Signature,
      //                              ROW_NUMBER() OVER (PARTITION BY a.DocID ORDER BY a.WorkFlowStatusId DESC) AS RowID
      //                          FROM [dbo].[TbWorkFlowTransactions] a (NOLOCK)
      //                          LEFT JOIN [dbo].[TbDocuments] b (NOLOCK) ON a.DocID = b.DocID
      //                          INNER JOIN [dbo].[TbUsers] c (NOLOCK) ON a.UpdatedBy = c.UserID
      //                      ) f ON a.DocID = f.DocID AND f.RowID = 1
      //                      LEFT JOIN [dbo].[TbStorehouseList] g (NOLOCK) ON b.StorehouseListID = g.StorehouseListID
      //                      LEFT JOIN [dbo].[TbWarehouse] h (NOLOCK) ON g.WarehouseID = h.WarehouseID
      //                      INNER JOIN #dataAccessControl i (NOLOCK) ON g.StorehouseListID = i.StorehouseListID
      //                      WHERE e.DocType = 11
      //                  ) a
      //                  WHERE a.RowID = 1;

      //                  /* Create CTE for Document Change Requests */
      //                  WITH CTE_DocumentChangeRequest AS (
      //                      SELECT a.RequestId, a.DocID, a.RequestTypeId, b.RequestTypeName,
      //                          RequestFrom = CASE 
			   //                     WHEN a.RequestTypeId = 1 THEN CONVERT(VARCHAR(10), CONVERT(DATETIME, a.RequestFrom, 102), 126) ELSE a.RequestFrom END,
      //                          RequestTo = CASE 
			   //                     WHEN a.RequestTypeId = 1 THEN CONVERT(VARCHAR(10), CONVERT(DATETIME, a.RequestTo, 102), 126) ELSE a.RequestTo END,
      //                          a.RequestReason, a.IsActive, c.WorkFlowStatusId, d.WorkFlowStatusName,
		    //                    ROW_NUMBER() OVER (PARTITION BY a.DocID ORDER BY c.WorkFlowTransactionsId DESC) AS RowID
      //                      FROM [dbo].[TbDocumentChangeRequestDetail] a (NOLOCK)
      //                      INNER JOIN [dbo].[TbChangeRequestType] b (NOLOCK) ON a.RequestTypeId = b.RequestTypeId
      //                      INNER JOIN [dbo].[TbWorkFlowTransactions] c(NOLOCK) ON a.DocID = c.DocID
	     //                   INNER JOIN [dbo].[TbWorkFlowStatus] d(NOLOCK) ON c.WorkFlowStatusId = d.WorkFlowStatusId
	     //                   INNER JOIN [dbo].[TbWorkFlow] e(NOLOCK) ON c.WorkFlowId = e.WorkFlowId
	     //                   INNER JOIN [dbo].[TbDocuments] doc (NOLOCK) ON a.DocID = doc.DocID
      //                      INNER JOIN #dataAccessControl h (NOLOCK) ON e.StorehouseListID = h.StorehouseListID
	     //                   WHERE doc.DocType = 11
	     //                       AND CAST(doc.CreatedDate AS DATE) >= '{3}' AND CAST(doc.CreatedDate AS DATE) <= '{4}'
      //                  ),
      //                  /* Create CTE for Document Advance Payment Amount */
      //                  CTE_DocumentAdvancePaymentAmount AS (
      //                      SELECT a.DocID, a.DocCode
	     //                   ,RefCode = CASE 
		    //                    WHEN a.DocType IN (2, 3, 4, 12) THEN a.RefCode
		    //                    WHEN a.DocType = 5 THEN COALESCE(a.RefCode, a.DocCode)
		    //                    WHEN a.DocType IN (11, 18) THEN a.CustomerName
		    //                    WHEN a.DocType = 14 THEN a.OwnerName
	     //                   END
	     //                   ,fromStorehouseListID = shaa.StorehouseListID
	     //                   ,fromStorehouseName = CASE 
		    //                    WHEN a.DocType IN (3, 4, 11, 12, 18) THEN CONCAT('[', shaa.StorehouseCode, '] ', shaa.StorehouseName, ' ', shaa.BranchName)
		    //                    WHEN a.DocType = 5
			   //                     THEN (
					 //                       CASE 
						//                        WHEN shab.StorehouseCode IS NOT NULL THEN CONCAT('[', shab.StorehouseCode, '] ', shab.StorehouseName, ' ', shab.BranchName) ELSE a.Remark END
				  //                      )
		    //                    WHEN a.DocType = 14 THEN CONCAT('[', shaa.StorehouseCode, '] ', shaa.StorehouseName, ' ', shaa.BranchName)
		    //                    ELSE CONCAT('[', shaa.StorehouseCode, '] ', shaa.StorehouseName, ' ', shaa.BranchName)
	     //                   END
	     //                   ,fromStorehouseTypeID = shaa.StorehouseTypeID, fromStorehouseCode = shaa.StorehouseCode
	     //                   ,fromStorehouseTypeName = shaa.StorehouseTypeName, fromGoodsTypeID = shaa.GoodsTypeID
	     //                   ,fromGoodsTypeName = shaa.GoodsTypeName, fromIsTBL = shaa.IsFlagTBL
	     //                   ,fromIsProvince = shaa.IsProvince, fromIsCentre = shaa.IsCentre, fromIsFactories = shaa.IsFactories
	     //                   ,toStorehouseListID = shab.StorehouseListID, toStorehouseCode = shab.StorehouseCode
	     //                   ,toStorehouseName = CASE 
		    //                    WHEN a.DocType IN (2, 5) THEN CONCAT('[', shab.StorehouseCode, '] ', shab.StorehouseName, ' ', shab.BranchName)
		    //                    WHEN a.DocType = 14 THEN a.Remark
		    //                    WHEN a.DocType = 4 OR a.TranferType = 'SAL' THEN a.SaleName
		    //                    WHEN a.DocType IN (3, 11, 18) OR a.TranferType = 'CUS' THEN COALESCE(a.CustomerName, a.SaleName)
		    //                    WHEN a.DocType = 12 THEN a.Description
	     //                   END
	     //                   ,toGoodsTypeID = shab.GoodsTypeID, toGoodsTypeName = shab.GoodsTypeName
	     //                   ,toIsTBL = shab.IsFlagTBL, toIsProvince = shab.IsProvince
	     //                   ,toIsCentre = shab.IsCentre, toIsFactories = shab.IsFactories
	     //                   ,CreatedDate = CONVERT(CHAR(10), CONVERT(DATETIME, a.CreatedDate, 103), 126)
	     //                   ,UpdatedDate = CONVERT(CHAR(10), CONVERT(DATETIME, a.UpdatedDate, 103), 126)
	     //                   ,IsDocStatus = CASE 
		    //                    WHEN a.DocStatusID = 1 AND a.IsActive = 0 THEN 'New'
		    //                    WHEN a.DocStatusID = 2 AND a.IsActive = 0 THEN 'In-Progress'
		    //                    WHEN a.DocStatusID = 3 AND a.IsActive = 0 THEN 'Cancel'
		    //                    WHEN a.DocStatusID = 4 AND a.IsActive = 0 THEN 'Reject'
		    //                    WHEN a.DocStatusID = 5 AND a.IsActive = 1 THEN 'Success'
	     //                   END
	     //                   ,a.IsActive, a.DocType, c.TypeName
	     //                   ,DocDate = CONVERT(CHAR(10), CONVERT(DATETIME, a.DocDate, 103), 126)
	     //                   ,IsAttachedFile = (
		    //                    CASE 
			   //                     WHEN a.AttFiles IS NOT NULL OR a.AttFiles = '' THEN 1 ELSE 0 END
		    //                    )
	     //                   ,a.AttFiles, a.IsFormEntry, d.GroupID, e.GroupName, a.DocStatusID
	     //                   ,a.Approvers, shaa.BusinessUnitID, shaa.BusinessUnitName, a.DelivName
	     //                   ,f.RequestId, f.RequestTypeId, f.RequestTypeName, RequestStatus = f.IsActive
	     //                   ,f.WorkFlowStatusId, f.WorkFlowStatusName, f.RequestFrom, f.RequestTo, f.RequestReason
	     //                   ,DueDate = CONVERT(VARCHAR(10), CONVERT(DATETIME, a.DueDate, 103), 126)
      //                  FROM [dbo].[TbDocuments] a(NOLOCK)
      //                  LEFT JOIN #dataFromStorehouse shaa ON shaa.StorehouseListID = a.FromStorehouseListID
      //                  LEFT JOIN #dataToStorehouse shab ON shab.StorehouseListID = a.ToStorehouseListID
      //                  INNER JOIN [dbo].[TbWarehouse] b(NOLOCK) ON a.WarehouseID = b.WarehouseID
      //                  INNER JOIN [dbo].[TbDocumentTypes] c(NOLOCK) ON a.DocType = c.TypeID
      //                  INNER JOIN [dbo].[TbCompanyProfile] d(NOLOCK) ON b.CompID = d.CompID
      //                  INNER JOIN [dbo].[TbCompanyGroups] e(NOLOCK) ON d.GroupID = e.GroupID
      //                  LEFT JOIN CTE_DocumentChangeRequest f ON a.DocID = f.DocID
	     //                   AND f.RowID = 1
      //                  INNER JOIN #dataAccessControl g ON shaa.StorehouseListID = g.StorehouseListID
	     //                   AND a.CompID = g.CompID
      //                  WHERE 1=1
	     //                   AND a.DocType = 11
      //                      AND CAST(a.CreatedDate AS DATE) >= '{3}' AND CAST(a.CreatedDate AS DATE) <= '{4}'
      //                  )

      //                  SELECT a.DocID, a.DocCode, a.RefCode, a.DocType, a.TypeName, e.WorkFlowId,
      //                      WorkFlowStatusId = COALESCE(a.WorkFlowStatusId, d.WorkFlowStatusId),
      //                      WorkFlowStatusName = COALESCE(a.WorkFlowStatusName, d.WorkFlowStatusName),
      //                      AdvPayApprovedDate = CASE
      //                                              WHEN d.WorkFlowStatusId = 1 THEN e.UpdatedDate
      //                                              WHEN d.WorkFlowStatusId = 3 THEN e.UpdatedDate
      //                                              WHEN d.WorkFlowStatusId = 4 THEN e.UpdatedDate
      //                                              ELSE NULL
      //                                          END,
      //                      AdvPayApprover = CASE 
      //                                          WHEN d.WorkFlowStatusId = 1 THEN d.AdvPayApprover
      //                                          WHEN d.WorkFlowStatusId = 3 THEN d.AdvPayApprover
      //                                          WHEN d.WorkFlowStatusId = 4 THEN d.AdvPayApprover
      //                                          ELSE NULL
      //                                      END,
      //                      SignatureApprove = CASE 
      //                                          WHEN d.WorkFlowStatusId = 1 THEN e.Signature
      //                                          WHEN d.WorkFlowStatusId = 3 THEN e.Signature
      //                                          WHEN d.WorkFlowStatusId = 4 THEN e.Signature
      //                                          ELSE NULL
      //                                          END,
	     //                   a.fromStorehouseListID, a.fromStorehouseName, a.fromStorehouseTypeID, a.fromStorehouseCode, a.fromStorehouseTypeName,	
	     //                   a.fromGoodsTypeID, a.fromGoodsTypeName, a.fromIsTBL, a.fromIsProvince, a.fromIsCentre, a.fromIsFactories,	
	     //                   a.toStorehouseListID, a.toStorehouseCode, a.toStorehouseName, a.toGoodsTypeID, a.toGoodsTypeName,
	     //                   a.toIsTBL, a.toIsProvince, a.toIsCentre, a.toIsFactories,	
	     //                   a.DocDate, a.DueDate, a.CreatedDate, a.UpdatedDate,
	     //                   c.RefCodeOrderPayment, c.RefDocID, refIsDocStatus = c.IsDocStatus,
      //                      c.AdvanceReceiptDocID, c.AdvanceReceiptDocCode, 
	     //                   c.AdvanceReceiptRowCountx, a.Approvers,
      //                      AdvPayAction = CASE 
      //                                      WHEN d.WorkFlowStatusName = 'Pending' THEN 
      //                                          CASE WHEN a.IsDocStatus != 'Cancel' THEN 'รออนุมัติ' END
      //                                      WHEN d.WorkFlowStatusName = 'Cancel' THEN 
      //                                          CASE WHEN a.IsDocStatus != 'Cancel' THEN 'ยังไม่ขออนุมัติ' END
      //                                      WHEN d.WorkFlowStatusName = 'Reject' THEN 
      //                                          CASE WHEN a.IsDocStatus != 'Cancel' THEN 'เอกสารตีกลับ' END
      //                                      WHEN d.WorkFlowStatusName = 'Approve' THEN a.Approvers
      //                                      END,
	     //                   a.DelivName, a.IsAttachedFile, a.AttFiles, a.IsFormEntry, a.GroupID, a.GroupName, a.BusinessUnitID, 
      //                      a.BusinessUnitName, a.IsActive, a.DocStatusID, a.IsDocStatus, c.AdvanceReceiptIsDocStatus,  
	     //                   AdvActionStatus = CASE 
      //                                          WHEN d.WorkFlowStatusName IS NULL OR d.WorkFlowStatusName = 'Pending' THEN 
      //                                              CASE 
      //                                                  WHEN c.IsDocStatus = 'New' THEN 'New'
      //                                                  WHEN c.IsDocStatus = 'Cancel' THEN 'Cancel'
      //                                                  WHEN c.IsDocStatus = 'Reject' THEN 'Reject'
      //                                                  ELSE 'In-progress' 
      //                                              END
      //                                          WHEN d.WorkFlowStatusName = 'Cancel' THEN 'Cancel'
      //                                          ELSE 
      //                                              CASE 
      //                                                  WHEN c.IsDocStatus = 'Cancel' THEN 'Cancel'
      //                                                  WHEN (c.RefCodeOrderPayment IS NULL OR c.SumAdvancePayAmount > 0) THEN 
      //                                                      CASE 
      //                                                          WHEN c.SumAdvancePayAmount = 0 THEN 
      //                                                              CASE 
      //                                                                  WHEN a.DocStatusID = 1 AND a.IsActive = 0 THEN 'New'
      //                                                                  WHEN a.DocStatusID = 2 AND a.IsActive = 0 THEN 'In-Progress'
      //                                                                  WHEN a.DocStatusID = 3 AND a.IsActive = 0 THEN 'Cancel'
      //                                                                  WHEN a.DocStatusID = 4 AND a.IsActive = 0 THEN 'Reject'
      //                                                                  WHEN a.DocStatusID = 5 AND a.IsActive = 1 THEN 
      //                                                                      CASE WHEN (c.SumAdvancePayAmount > 0) THEN 'In-Progress' ELSE 'Success' END
      //                                                              END
      //                                                          ELSE 
      //                                                              CASE 
      //                                                                  WHEN c.IsDocStatus = 'New' THEN 'New'
      //                                                                  WHEN c.IsDocStatus = 'In-progress' THEN 'In-progress'
      //                                                                  WHEN c.IsDocStatus = 'Cancel' THEN 'Cancel'
      //                                                                  WHEN c.IsDocStatus = 'Reject' THEN 'Reject' 
      //                                                                  ELSE 'Success' 
      //                                                              END
      //                                                      END
      //                                                  ELSE 
      //                                                      CASE 
      //                                                          WHEN c.IsDocStatus = 'New' THEN 'New'
      //                                                          WHEN c.IsDocStatus = 'In-progress' THEN 'In-progress'
      //                                                          WHEN c.IsDocStatus = 'Cancel' THEN 'Cancel'
      //                                                          WHEN c.IsDocStatus = 'Reject' THEN 'Reject'
      //                                                          ELSE 'Success' 
      //                                                      END
      //                                              END
      //                                      END,
      //                      c.SumAdvancePayAmount, e.ApproveListId, a.RequestId,	a.RequestTypeId, a.RequestTypeName,	
	     //                   a.RequestStatus, a.RequestFrom, a.RequestTo, a.RequestReason	
      //                  FROM CTE_DocumentAdvancePaymentAmount a
      //                  LEFT JOIN #dataSumAdvancePayAmount c ON a.DocCode = c.DocCode AND a.fromStorehouseListID = c.StorehouseListID
      //                  LEFT JOIN #dataAdvancePaymentWorkflow d ON a.DocID = d.DocID
      //                  LEFT JOIN #dataWorkFlowTransactions e ON a.DocID = e.DocID
      //                  WHERE 1=1
      //                  [@whereStatus]	   
      //                  ORDER BY a.DocDate DESC;

      //                  DROP TABLE #dataAccessControl;
      //                  DROP TABLE #dataFromStorehouse;
      //                  DROP TABLE #dataToStorehouse;
      //                  DROP TABLE #dataWorkFlowTransactions;
      //                  DROP TABLE #dataDocumentAdvancePayment;
      //                  DROP TABLE #dataReceiptAdvancePayAmount;
      //                  DROP TABLE #dataReceiptReturnPayment;
      //                  DROP TABLE #dataDocumentReturnPayment;
      //                  DROP TABLE #dataDocumentOrderPayment;
      //                  DROP TABLE #dataSumAdvancePayAmount;
      //                  DROP TABLE #dataAdvancePaymentWorkflow;
      //              ";


                }
                catch (Exception ex)
                {

                    throw;
                }
            }

            return advanceReportRes;
        }
    }
}
