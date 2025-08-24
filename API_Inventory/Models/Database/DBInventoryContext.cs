using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API_Inventory.Models.Database;

public partial class DBInventoryContext : DbContext
{
    public DBInventoryContext()
    {
    }

    public DBInventoryContext(DbContextOptions<DBInventoryContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TbAccountingType> TbAccountingTypes { get; set; }

    public virtual DbSet<TbAct> TbActs { get; set; }

    public virtual DbSet<TbAuditLog> TbAuditLogs { get; set; }

    public virtual DbSet<TbBarcode> TbBarcodes { get; set; }

    public virtual DbSet<TbBarcodeMapping> TbBarcodeMappings { get; set; }

    public virtual DbSet<TbBranch> TbBranchs { get; set; }

    public virtual DbSet<TbBranchsCode> TbBranchsCodes { get; set; }

    public virtual DbSet<TbBranchsType> TbBranchsTypes { get; set; }

    public virtual DbSet<TbBrand> TbBrands { get; set; }

    public virtual DbSet<TbBrandHolding> TbBrandHoldings { get; set; }

    public virtual DbSet<TbBroughtForwardDaily> TbBroughtForwardDailies { get; set; }

    public virtual DbSet<TbBroughtForwardMonthly> TbBroughtForwardMonthlies { get; set; }

    public virtual DbSet<TbBroughtForwardYearly> TbBroughtForwardYearlies { get; set; }

    public virtual DbSet<TbBusinessUnit> TbBusinessUnits { get; set; }

    public virtual DbSet<TbCar> TbCars { get; set; }

    public virtual DbSet<TbCarType> TbCarTypes { get; set; }

    public virtual DbSet<TbCategory> TbCategories { get; set; }

    public virtual DbSet<TbChangeRequestType> TbChangeRequestTypes { get; set; }

    public virtual DbSet<TbCompanyGroup> TbCompanyGroups { get; set; }

    public virtual DbSet<TbCompanyProfile> TbCompanyProfiles { get; set; }

    public virtual DbSet<TbConversion> TbConversions { get; set; }

    public virtual DbSet<TbCustomer> TbCustomers { get; set; }

    public virtual DbSet<TbDocument> TbDocuments { get; set; }

    public virtual DbSet<TbDocumentChangeRequestDetail> TbDocumentChangeRequestDetails { get; set; }

    public virtual DbSet<TbDocumentStatus> TbDocumentStatuses { get; set; }

    public virtual DbSet<TbDocumentType> TbDocumentTypes { get; set; }

    public virtual DbSet<TbDocumentsAdvPayment> TbDocumentsAdvPayments { get; set; }

    public virtual DbSet<TbDocumentsBackup> TbDocumentsBackups { get; set; }

    public virtual DbSet<TbDocumentsDummy> TbDocumentsDummies { get; set; }

    public virtual DbSet<TbDriver> TbDrivers { get; set; }

    public virtual DbSet<TbEndOfDayChecking> TbEndOfDayCheckings { get; set; }

    public virtual DbSet<TbFactoriesAreaCode> TbFactoriesAreaCodes { get; set; }

    public virtual DbSet<TbFactory> TbFactories { get; set; }

    public virtual DbSet<TbGoodsType> TbGoodsTypes { get; set; }

    public virtual DbSet<TbGroupHolding> TbGroupHoldings { get; set; }

    public virtual DbSet<TbLocation> TbLocations { get; set; }

    public virtual DbSet<TbMetaBrandHolding> TbMetaBrandHoldings { get; set; }

    public virtual DbSet<TbMetaCategoriesHolding> TbMetaCategoriesHoldings { get; set; }

    public virtual DbSet<TbMetaGroupHolding> TbMetaGroupHoldings { get; set; }

    public virtual DbSet<TbMetaPermission> TbMetaPermissions { get; set; }

    public virtual DbSet<TbMetaUser> TbMetaUsers { get; set; }

    public virtual DbSet<TbPermission> TbPermissions { get; set; }

    public virtual DbSet<TbProduct> TbProducts { get; set; }

    public virtual DbSet<TbProductBroughtForward> TbProductBroughtForwards { get; set; }

    public virtual DbSet<TbProductBroughtForwardCurrent> TbProductBroughtForwardCurrents { get; set; }

    public virtual DbSet<TbProductManufacturedDate> TbProductManufacturedDates { get; set; }

    public virtual DbSet<TbProductReginalSummary> TbProductReginalSummaries { get; set; }

    public virtual DbSet<TbProductRegionalBroughtForward> TbProductRegionalBroughtForwards { get; set; }

    public virtual DbSet<TbProductRegionalStock> TbProductRegionalStocks { get; set; }

    public virtual DbSet<TbProductStatus> TbProductStatuses { get; set; }

    public virtual DbSet<TbProductTransaction> TbProductTransactions { get; set; }

    public virtual DbSet<TbProductTransactionsBackup> TbProductTransactionsBackups { get; set; }

    public virtual DbSet<TbProductType> TbProductTypes { get; set; }

    public virtual DbSet<TbProductWarehouseStock> TbProductWarehouseStocks { get; set; }

    public virtual DbSet<TbProvince> TbProvinces { get; set; }

    public virtual DbSet<TbRegion> TbRegions { get; set; }

    public virtual DbSet<TbReportTransaction> TbReportTransactions { get; set; }

    public virtual DbSet<TbSale> TbSales { get; set; }

    public virtual DbSet<TbSaleAccessList> TbSaleAccessLists { get; set; }

    public virtual DbSet<TbSaleUnitGroupType> TbSaleUnitGroupTypes { get; set; }

    public virtual DbSet<TbSaleUnitMaster> TbSaleUnitMasters { get; set; }

    public virtual DbSet<TbSalesArea> TbSalesAreas { get; set; }

    public virtual DbSet<TbStockTrackingChangeRequestDetail> TbStockTrackingChangeRequestDetails { get; set; }

    public virtual DbSet<TbStockUnit> TbStockUnits { get; set; }

    public virtual DbSet<TbStorehouse> TbStorehouses { get; set; }

    public virtual DbSet<TbStorehouseList> TbStorehouseLists { get; set; }

    public virtual DbSet<TbStorehouseType> TbStorehouseTypes { get; set; }

    public virtual DbSet<TbSubCategory> TbSubCategories { get; set; }

    public virtual DbSet<TbSummaryExposeDatum> TbSummaryExposeData { get; set; }

    public virtual DbSet<TbTadvanceDeflect> TbTadvanceDeflects { get; set; }

    public virtual DbSet<TbTadvanceDeflectAmount> TbTadvanceDeflectAmounts { get; set; }

    public virtual DbSet<TbTadvanceDocument> TbTadvanceDocuments { get; set; }

    public virtual DbSet<TbTadvanceDocumentCode> TbTadvanceDocumentCodes { get; set; }

    public virtual DbSet<TbTadvancePaymentDocument> TbTadvancePaymentDocuments { get; set; }

    public virtual DbSet<TbTadvanceProductBalance> TbTadvanceProductBalances { get; set; }

    public virtual DbSet<TbTdocumentNumber> TbTdocumentNumbers { get; set; }

    public virtual DbSet<TbTdocumntFirstDate> TbTdocumntFirstDates { get; set; }

    public virtual DbSet<TbTypeOfApprovedWorkflow> TbTypeOfApprovedWorkflows { get; set; }

    public virtual DbSet<TbTypeOfApprovedWorkflowList> TbTypeOfApprovedWorkflowLists { get; set; }

    public virtual DbSet<TbUser> TbUsers { get; set; }

    public virtual DbSet<TbUserAuthen> TbUserAuthens { get; set; }

    public virtual DbSet<TbUserGroup> TbUserGroups { get; set; }

    public virtual DbSet<TbUserRole> TbUserRoles { get; set; }

    public virtual DbSet<TbWarehouse> TbWarehouses { get; set; }

    public virtual DbSet<TbWorkFlow> TbWorkFlows { get; set; }

    public virtual DbSet<TbWorkFlowBackup> TbWorkFlowBackups { get; set; }

    public virtual DbSet<TbWorkFlowStatus> TbWorkFlowStatuses { get; set; }

    public virtual DbSet<TbWorkFlowTransaction> TbWorkFlowTransactions { get; set; }

    public virtual DbSet<TbWorkFlowTransactionsBackup> TbWorkFlowTransactionsBackups { get; set; }

    public virtual DbSet<TbWorkFlowType> TbWorkFlowTypes { get; set; }

    public virtual DbSet<UvwGetSalespersonRequestDocument> UvwGetSalespersonRequestDocuments { get; set; }

    public virtual DbSet<UvwProducstInfo> UvwProducstInfos { get; set; }

    public virtual DbSet<UvwProductBroughtForward> UvwProductBroughtForwards { get; set; }

    public virtual DbSet<UvwProductRegionalBroughtForward> UvwProductRegionalBroughtForwards { get; set; }

    public virtual DbSet<VProducstInfo> VProducstInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=10.5.56.35;Database=DBInventory;User ID=ims;Password=RtmIms@2024; Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Thai_CI_AS");

        modelBuilder.Entity<TbAccountingType>(entity =>
        {
            entity.HasKey(e => e.AccountingTypeId);

            entity.ToTable("TbAccountingType");

            entity.Property(e => e.AccountingTypeId).HasColumnName("AccountingTypeID");
            entity.Property(e => e.AccountingTypeName).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbAct>(entity =>
        {
            entity.HasKey(e => e.ActId);

            entity.ToTable("TbAct");

            entity.Property(e => e.ActId).HasColumnName("ActID");
            entity.Property(e => e.ActName).HasMaxLength(255);
        });

        modelBuilder.Entity<TbAuditLog>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IpAddress).HasMaxLength(50);
            entity.Property(e => e.LogData).HasColumnType("text");
            entity.Property(e => e.MethodeType).HasMaxLength(50);
            entity.Property(e => e.PageUrl)
                .HasMaxLength(255)
                .HasColumnName("PageURL");
            entity.Property(e => e.UserCode).HasMaxLength(8);
        });

        modelBuilder.Entity<TbBarcode>(entity =>
        {
            entity.HasKey(e => e.BarcodeId);

            entity.ToTable("TbBarcode");

            entity.Property(e => e.BarcodeId).HasColumnName("BarcodeID");
            entity.Property(e => e.Barcode).HasMaxLength(255);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UnitSize).HasColumnName("unitSize");
            entity.Property(e => e.UnitSizeName)
                .HasMaxLength(255)
                .HasColumnName("unitSizeName");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbBarcodeMapping>(entity =>
        {
            entity.HasKey(e => e.MappingId).HasName("PK_TbMappingBarcode");

            entity.ToTable("TbBarcodeMapping");

            entity.HasIndex(e => new { e.BarcodeId, e.ProductId }, "index_BarcodeMapping");

            entity.Property(e => e.MappingId).HasColumnName("MappingID");
            entity.Property(e => e.BarcodeId).HasColumnName("BarcodeID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Barcode).WithMany(p => p.TbBarcodeMappings)
                .HasForeignKey(d => d.BarcodeId)
                .HasConstraintName("FK__TbBarcode__Barco__05D8E0BE");

            entity.HasOne(d => d.Product).WithMany(p => p.TbBarcodeMappings)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__TbBarcode__Produ__12C8C788");
        });

        modelBuilder.Entity<TbBranch>(entity =>
        {
            entity.HasKey(e => e.BranchId);

            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.BranchCode).HasMaxLength(50);
            entity.Property(e => e.BranchName).HasMaxLength(255);
            entity.Property(e => e.BranchTypeId).HasColumnName("BranchTypeID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbBranchsCode>(entity =>
        {
            entity.HasKey(e => e.BranchCodeId);

            entity.ToTable("TbBranchsCode");

            entity.Property(e => e.BranchCodeId).HasColumnName("BranchCodeID");
            entity.Property(e => e.BranchCode).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
        });

        modelBuilder.Entity<TbBranchsType>(entity =>
        {
            entity.HasKey(e => e.BranchTypeId);

            entity.ToTable("TbBranchsType");

            entity.Property(e => e.BranchTypeId).HasColumnName("BranchTypeID");
            entity.Property(e => e.BranchTypeName).HasMaxLength(255);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbBrand>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("PK_TbBrand");

            entity.Property(e => e.BrandId).HasColumnName("BrandID");
            entity.Property(e => e.BrandCode).HasMaxLength(8);
            entity.Property(e => e.BrandName).HasMaxLength(255);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbBrandHolding>(entity =>
        {
            entity.HasKey(e => e.BrandHoldingId);

            entity.ToTable("TbBrandHolding");

            entity.Property(e => e.BrandHoldingId).HasColumnName("BrandHoldingID");
            entity.Property(e => e.BrandHoldingName).HasMaxLength(500);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbBroughtForwardDaily>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TbBroughtForwardDaily");

            entity.Property(e => e.BrokenVal).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ExpoVal).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ProductCode).HasMaxLength(16);
            entity.Property(e => e.ReceVal).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.ThisDay).HasColumnName("thisDay");
            entity.Property(e => e.ThisMonth).HasColumnName("thisMonth");
            entity.Property(e => e.ThisYear).HasColumnName("thisYear");
            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
        });

        modelBuilder.Entity<TbBroughtForwardMonthly>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TbBroughtForwardMonthly");

            entity.Property(e => e.BrokenVal).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ExpoVal).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ProductCode).HasMaxLength(16);
            entity.Property(e => e.ReceVal).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.ThisMonth).HasColumnName("thisMonth");
            entity.Property(e => e.ThisYear).HasColumnName("thisYear");
            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
        });

        modelBuilder.Entity<TbBroughtForwardYearly>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TbBroughtForwardYearly");

            entity.Property(e => e.BrokenVal).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ExpoVal).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ProductCode).HasMaxLength(16);
            entity.Property(e => e.ReceVal).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.ThisYear).HasColumnName("thisYear");
            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
        });

        modelBuilder.Entity<TbBusinessUnit>(entity =>
        {
            entity.HasKey(e => e.BusinessUnitId).HasName("PK_TbStorehouseListType");

            entity.ToTable("TbBusinessUnit");

            entity.Property(e => e.BusinessUnitId).HasColumnName("BusinessUnitID");
            entity.Property(e => e.BusinessUnitName).HasMaxLength(255);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbCar>(entity =>
        {
            entity.HasKey(e => e.CarId);

            entity.Property(e => e.CarId).HasColumnName("CarID");
            entity.Property(e => e.CarTypeId).HasColumnName("CarTypeID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LocId).HasColumnName("LocID");
            entity.Property(e => e.NumberPlate).HasMaxLength(12);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.UpdatetedDate).HasColumnType("datetime");

            entity.HasOne(d => d.CarType).WithMany(p => p.TbCars)
                .HasForeignKey(d => d.CarTypeId)
                .HasConstraintName("FK__TbCars__CarTypeI__753864A1");

            entity.HasOne(d => d.Loc).WithMany(p => p.TbCars)
                .HasForeignKey(d => d.LocId)
                .HasConstraintName("FK__TbCars__LocID__4242D080");

            entity.HasOne(d => d.Province).WithMany(p => p.TbCars)
                .HasForeignKey(d => d.ProvinceId)
                .HasConstraintName("FK__TbCars__Province__7167D3BD");

            entity.HasOne(d => d.Region).WithMany(p => p.TbCars)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK__TbCars__RegionID__414EAC47");
        });

        modelBuilder.Entity<TbCarType>(entity =>
        {
            entity.HasKey(e => e.CarTypeId).HasName("PK_TbCarsType");

            entity.Property(e => e.CarTypeId).HasColumnName("CarTypeID");
            entity.Property(e => e.CarTypeName).HasMaxLength(255);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.UpdatetedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryCode).HasMaxLength(8);
            entity.Property(e => e.CategoryName).HasMaxLength(255);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbChangeRequestType>(entity =>
        {
            entity.HasKey(e => e.RequestTypeId);

            entity.ToTable("TbChangeRequestType");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsActive).HasDefaultValue(false);
            entity.Property(e => e.RequestTypeName).HasMaxLength(500);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbCompanyGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId);

            entity.HasIndex(e => e.GroupId, "IDX_CompanyGroups");

            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.GroupName).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbCompanyProfile>(entity =>
        {
            entity.HasKey(e => e.CompId);

            entity.ToTable("TbCompanyProfile");

            entity.HasIndex(e => new { e.CompId, e.GroupId, e.CompCode }, "IDX_CompanyProfile");

            entity.HasIndex(e => e.CompId, "idx_CompID");

            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.AbbreviationCode).HasMaxLength(5);
            entity.Property(e => e.CompAddress).HasMaxLength(500);
            entity.Property(e => e.CompCode).HasMaxLength(8);
            entity.Property(e => e.CompName).HasMaxLength(255);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Group).WithMany(p => p.TbCompanyProfiles)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK__TbCompany__Group__41A3B202");

            entity.HasOne(d => d.Region).WithMany(p => p.TbCompanyProfiles)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK__TbCompany__Regio__0A9D95DB");
        });

        modelBuilder.Entity<TbConversion>(entity =>
        {
            entity.HasKey(e => e.ConversionId);

            entity.ToTable("TbConversion");

            entity.HasIndex(e => e.ConversionId, "idx_ConversionID");

            entity.HasIndex(e => e.ConversionId, "idx_TbConversion_ConversionID");

            entity.Property(e => e.ConversionId).HasColumnName("ConversionID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbCustomer>(entity =>
        {
            entity.HasKey(e => e.CusId);

            entity.Property(e => e.CusId).HasColumnName("CusID");
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Building).HasMaxLength(255);
            entity.Property(e => e.Country).HasMaxLength(255);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CusCode).HasMaxLength(255);
            entity.Property(e => e.CusName).HasMaxLength(255);
            entity.Property(e => e.District).HasMaxLength(255);
            entity.Property(e => e.Fax).HasMaxLength(255);
            entity.Property(e => e.Floor).HasMaxLength(255);
            entity.Property(e => e.Post).HasMaxLength(255);
            entity.Property(e => e.Province).HasMaxLength(255);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.Road).HasMaxLength(255);
            entity.Property(e => e.Soi).HasMaxLength(255);
            entity.Property(e => e.SubDistrict).HasMaxLength(255);
            entity.Property(e => e.TaxId)
                .HasMaxLength(255)
                .HasColumnName("TaxID");
            entity.Property(e => e.Tel).HasMaxLength(255);
            entity.Property(e => e.Unit).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.Village).HasMaxLength(255);
            entity.Property(e => e.VillageName).HasMaxLength(255);

            entity.HasOne(d => d.Region).WithMany(p => p.TbCustomers)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK__TbCustome__Regio__5A846E65");
        });

        modelBuilder.Entity<TbDocument>(entity =>
        {
            entity.HasKey(e => e.DocId);

            entity.HasIndex(e => new { e.DocId, e.UpdatedDate, e.IsActive, e.IsAdvancePay }, "IX_TbDocuments");

            entity.HasIndex(e => new { e.DocId, e.DocStatusId }, "IX_TbDocuments_DocId_StatusId");

            entity.HasIndex(e => new { e.DocType, e.CreatedDate, e.IsActive }, "IX_TbDocuments_DocType_CreatedDate_IsActive");

            entity.HasIndex(e => e.CompId, "idx_CompID");

            entity.HasIndex(e => e.CreatedDate, "idx_CreatedDate");

            entity.HasIndex(e => e.DocCode, "idx_DocCode");

            entity.HasIndex(e => e.DocDate, "idx_DocDate");

            entity.HasIndex(e => e.DocId, "idx_DocID");

            entity.HasIndex(e => e.DocStatus, "idx_DocStatus");

            entity.HasIndex(e => e.DocStatusId, "idx_DocStatusID");

            entity.HasIndex(e => e.DocType, "idx_DocType");

            entity.HasIndex(e => new { e.DocType, e.CreatedDate }, "idx_DocTypeCreatedDateInculde");

            entity.HasIndex(e => new { e.DocId, e.DocCode, e.DocType, e.CompId, e.WarehouseId }, "idx_Document");

            entity.HasIndex(e => new { e.DocDate, e.DocType }, "idx_DocumentByDocDate");

            entity.HasIndex(e => e.DocType, "idx_DocumentByDocType");

            entity.HasIndex(e => e.DocType, "idx_DocumentByDocTypeIncludeDocID");

            entity.HasIndex(e => e.ToStorehouseListId, "idx_DocumentByToStorehouseListID");

            entity.HasIndex(e => e.ToStorehouseListId, "idx_DocumentDashboard");

            entity.HasIndex(e => new { e.WarehouseId, e.DocDate }, "idx_DocumentDashboardWarehouse");

            entity.HasIndex(e => new { e.DocCode, e.DocType, e.DocDate }, "idx_DocumentDocCode");

            entity.HasIndex(e => new { e.DocType, e.RefCode, e.DocDate }, "idx_DocumentDocType");

            entity.HasIndex(e => new { e.DocType, e.DocDate }, "idx_DocumentDocTypeAndDocDate");

            entity.HasIndex(e => e.DocType, "idx_DocumentDocTypePayment");

            entity.HasIndex(e => new { e.DocType, e.UpdatedDate }, "idx_DocumentDocTypeUpdate");

            entity.HasIndex(e => e.DocType, "idx_DocumentDocTypeWithSignature");

            entity.HasIndex(e => new { e.DocType, e.WarehouseId, e.DocDate, e.FromStorehouseListId }, "idx_DocumentFrom");

            entity.HasIndex(e => new { e.FromStorehouseListId, e.DocDate, e.DocType }, "idx_DocumentFromWithDocDate");

            entity.HasIndex(e => new { e.RefCode, e.DocDate }, "idx_DocumentRefCode");

            entity.HasIndex(e => new { e.DocType, e.ToStorehouseListId, e.DocId, e.CreatedDate }, "idx_DocumentToStohouse");

            entity.HasIndex(e => new { e.DocType, e.FromStorehouseListId }, "idx_DocumentsByDocTypeFromStorehouseListID");

            entity.HasIndex(e => e.DocType, "idx_DocumentsByDocTypeIncludeDocCode");

            entity.HasIndex(e => new { e.DocType, e.FromStorehouseListId, e.CompId }, "idx_DocumentsByDocTypeIncludeFromStorehouseListID");

            entity.HasIndex(e => e.DocType, "idx_DocumentsByDocTypeIncludeRefCode");

            entity.HasIndex(e => new { e.DocType, e.IsActive, e.DocStatusId }, "idx_DocumentsByDocTypeIsActiveDocStatusID");

            entity.HasIndex(e => new { e.DocType, e.IsAdvancePay }, "idx_DocumentsByDocTypeIsAdvancePay");

            entity.HasIndex(e => e.DocType, "idx_DocumentsByDocTypeWithInclude");

            entity.HasIndex(e => new { e.DocType, e.ToStorehouseListId }, "idx_DocumentsByDocType_ToStorehouseListID");

            entity.HasIndex(e => e.IsAdvancePay, "idx_DocumentsByIsAdvancePay");

            entity.HasIndex(e => e.ToStorehouseListId, "idx_DocumentsByToStorehouseListID");

            entity.HasIndex(e => new { e.TranferCode, e.Signature, e.SecondSignature, e.UpdatedBy }, "idx_DocumentsByTranferCode");

            entity.HasIndex(e => e.CreatedDate, "idx_DocumentsCreatedDateInclude");

            entity.HasIndex(e => e.DocStatusId, "idx_DocumentsDocStatusID");

            entity.HasIndex(e => e.DocType, "idx_DocumentsDocType");

            entity.HasIndex(e => new { e.DocType, e.ToStorehouseListId }, "idx_DocumentsDocTypeAndToStorehouseListID");

            entity.HasIndex(e => e.DocType, "idx_DocumentsDocTypeInclude");

            entity.HasIndex(e => new { e.IsActive, e.CompId }, "idx_DocumentsIsActiveCompId");

            entity.HasIndex(e => new { e.IsActive, e.DocStatus }, "idx_DocumentsIsActiveDocStatus");

            entity.HasIndex(e => e.IsActive, "idx_DocumentsIsActiveIncludeCompId");

            entity.HasIndex(e => new { e.IsActive, e.CompId }, "idx_DocumentsIsActiveIncludeUpdateDate");

            entity.HasIndex(e => e.IsAdvancePay, "idx_DocumentsIsAcvancePay");

            entity.HasIndex(e => e.IsAdvancePay, "idx_DocumentsIsAdvancePay");

            entity.HasIndex(e => new { e.DocType, e.IsAdvancePay }, "idx_DocumentsIsAdvancePayWarehouseID");

            entity.HasIndex(e => new { e.ToStorehouseListId, e.IsActive, e.DocStatus }, "idx_DocumentsToStorehouseListIDIsActiveDocStatus");

            entity.HasIndex(e => e.DocType, "idx_DocumentsWithDocType");

            entity.HasIndex(e => new { e.DocType, e.FromStorehouseListId }, "idx_DocumentsWithFromStorehouseListID");

            entity.HasIndex(e => e.IsAdvancePay, "idx_DocumentsWithIsAdvancePay");

            entity.HasIndex(e => new { e.DocType, e.IsAdvancePay, e.UpdatedDate }, "idx_Documents_AdvancePay_UpdatedDate");

            entity.HasIndex(e => e.DocType, "idx_Documents_DocType");

            entity.HasIndex(e => new { e.DocType, e.FromStorehouseListId }, "idx_Documents_DocType_FromStorehouseListID");

            entity.HasIndex(e => e.DocType, "idx_Documents_DocType_Include_DocCode");

            entity.HasIndex(e => e.IsAdvancePay, "idx_Documents_IsAdvancePay");

            entity.HasIndex(e => e.DueDate, "idx_DueDate");

            entity.HasIndex(e => e.FromStorehouseListId, "idx_FromStorehouseListID");

            entity.HasIndex(e => e.IsFormEntry, "idx_IsFormEntry");

            entity.HasIndex(e => e.RefCode, "idx_RefCode");

            entity.HasIndex(e => e.SaleAccessListId, "idx_SaleAccessListId");

            entity.HasIndex(e => e.DocId, "idx_TbDocumentsByDocID");

            entity.HasIndex(e => e.CreatedDate, "idx_TbDocuments_CreatedDate");

            entity.HasIndex(e => e.ToStorehouseListId, "idx_TbDocuments_DocCodeToStorehouseListID");

            entity.HasIndex(e => e.DocDate, "idx_TbDocuments_DocDate");

            entity.HasIndex(e => e.DocId, "idx_TbDocuments_DocID");

            entity.HasIndex(e => e.DocStatus, "idx_TbDocuments_DocStatus");

            entity.HasIndex(e => e.DocType, "idx_TbDocuments_DocType");

            entity.HasIndex(e => new { e.DocType, e.CreatedDate }, "idx_TbDocuments_DocType_createdDate");

            entity.HasIndex(e => e.FromStorehouseListId, "idx_TbDocuments_FromStorehouseListID");

            entity.HasIndex(e => e.RefCode, "idx_TbDocuments_RefCode");

            entity.HasIndex(e => e.ToStorehouseListId, "idx_TbDocuments_ToStorehouseListID");

            entity.HasIndex(e => e.WarehouseId, "idx_TbDocuments_WarehouseID");

            entity.HasIndex(e => e.ToStorehouseListId, "idx_ToStorehouseListID");

            entity.HasIndex(e => e.TranferCode, "idx_TranferCode");

            entity.HasIndex(e => e.TranferType, "idx_TranferType");

            entity.HasIndex(e => e.UpdatedDate, "idx_UpdatedDate");

            entity.HasIndex(e => e.WarehouseId, "idx_WarehouseID");

            entity.HasIndex(e => e.DocType, "idx_dataDocumentByDocType");

            entity.HasIndex(e => e.DocType, "idx_dataDocumentByDocTypeInclude");

            entity.HasIndex(e => e.CreatedDate, "idx_tbdocument_createddate");

            entity.HasIndex(e => e.ToStorehouseListId, "idx_tbdocument_tostorehouselistid");

            entity.HasIndex(e => e.DocDate, "idx_transaction_date");

            entity.Property(e => e.DocId).HasColumnName("DocID");
            entity.Property(e => e.AcceptedDate).HasColumnType("datetime");
            entity.Property(e => e.Approvers).HasMaxLength(255);
            entity.Property(e => e.AreaId).HasColumnName("AreaID");
            entity.Property(e => e.AttFiles).HasMaxLength(255);
            entity.Property(e => e.CarLicense).HasMaxLength(255);
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.Consignee).HasMaxLength(1400);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustomerName).HasMaxLength(1400);
            entity.Property(e => e.DelivName).HasMaxLength(255);
            entity.Property(e => e.DocCode).HasMaxLength(22);
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.DocStatusId).HasColumnName("DocStatusID");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.ExposeDate).HasMaxLength(10);
            entity.Property(e => e.ExposeTime).HasMaxLength(10);
            entity.Property(e => e.FirstReviewer).HasMaxLength(255);
            entity.Property(e => e.FromStorehouseListId).HasColumnName("FromStorehouseListID");
            entity.Property(e => e.IsAccepted).HasDefaultValue(false);
            entity.Property(e => e.IsConfirm).HasDefaultValue(false);
            entity.Property(e => e.IsFormEntry).HasDefaultValue(false);
            entity.Property(e => e.IssueType).HasMaxLength(4);
            entity.Property(e => e.OwnerName).HasMaxLength(255);
            entity.Property(e => e.PaymentCode).HasMaxLength(255);
            entity.Property(e => e.ReceiveFrom).HasMaxLength(255);
            entity.Property(e => e.RefCode).HasMaxLength(255);
            entity.Property(e => e.Requester).HasMaxLength(255);
            entity.Property(e => e.SaleName).HasMaxLength(255);
            entity.Property(e => e.SecondReviewer).HasMaxLength(255);
            entity.Property(e => e.SecondSignature).HasMaxLength(255);
            entity.Property(e => e.Signature).HasMaxLength(255);
            entity.Property(e => e.TaxId)
                .HasMaxLength(20)
                .HasColumnName("TaxID");
            entity.Property(e => e.Telephone).HasMaxLength(1400);
            entity.Property(e => e.ToStorehouseListId).HasColumnName("ToStorehouseListID");
            entity.Property(e => e.TranferCode).HasMaxLength(255);
            entity.Property(e => e.TranferType).HasMaxLength(250);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

            entity.HasOne(d => d.Comp).WithMany(p => p.TbDocuments)
                .HasForeignKey(d => d.CompId)
                .HasConstraintName("FK__TbDocumen__CompI__0D7A0286");

            entity.HasOne(d => d.DocTypeNavigation).WithMany(p => p.TbDocuments)
                .HasForeignKey(d => d.DocType)
                .HasConstraintName("FK__TbDocumen__DocTy__0C85DE4D");

            entity.HasOne(d => d.SaleAccessList).WithMany(p => p.TbDocuments)
                .HasForeignKey(d => d.SaleAccessListId)
                .HasConstraintName("FK__TbDocumen__SaleA__1B7E091A");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.TbDocuments)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK__TbDocumen__Wareh__29CC2871");
        });

        modelBuilder.Entity<TbDocumentChangeRequestDetail>(entity =>
        {
            entity.HasKey(e => e.RequestId);

            entity.ToTable("TbDocumentChangeRequestDetail");

            entity.HasIndex(e => new { e.DocId, e.RequestTypeId, e.RequestFrom, e.RequestTo }, "idx_TbDocumentChangeRequestDetail_DocID");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocId).HasColumnName("DocID");
            entity.Property(e => e.RequestFrom).HasMaxLength(500);
            entity.Property(e => e.RequestReason).HasMaxLength(500);
            entity.Property(e => e.RequestTo).HasMaxLength(500);
            entity.Property(e => e.RequestTypeId).HasDefaultValue(1);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Doc).WithMany(p => p.TbDocumentChangeRequestDetails)
                .HasForeignKey(d => d.DocId)
                .HasConstraintName("FK__TbDocumen__DocID__58DC1D15");

            entity.HasOne(d => d.RequestType).WithMany(p => p.TbDocumentChangeRequestDetails)
                .HasForeignKey(d => d.RequestTypeId)
                .HasConstraintName("FK__TbDocumen__Reque__4CAB505A");
        });

        modelBuilder.Entity<TbDocumentStatus>(entity =>
        {
            entity.HasKey(e => e.DocStatusId);

            entity.ToTable("TbDocumentStatus");

            entity.Property(e => e.DocStatusId).HasColumnName("DocStatusID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocStatus).HasMaxLength(50);
            entity.Property(e => e.DocStatusTh).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbDocumentType>(entity =>
        {
            entity.HasKey(e => e.TypeId);

            entity.HasIndex(e => e.TypeId, "IX_TbDocumentTypes");

            entity.Property(e => e.TypeId).HasColumnName("TypeID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.TypeCode).HasMaxLength(20);
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbDocumentsAdvPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TbDocumentsAdvPayment");

            entity.Property(e => e.AdvPayAction).HasMaxLength(255);
            entity.Property(e => e.AdvPayApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AdvPayApprover).HasMaxLength(255);
            entity.Property(e => e.AdvancePayReceiptDocId).HasColumnName("AdvancePayReceiptDocID");
            entity.Property(e => e.Approvers).HasMaxLength(500);
            entity.Property(e => e.AttFiles).HasMaxLength(255);
            entity.Property(e => e.BusinessUnitId).HasColumnName("BusinessUnitID");
            entity.Property(e => e.BusinessUnitName).HasMaxLength(500);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DelivName).HasMaxLength(500);
            entity.Property(e => e.DocCode).HasMaxLength(22);
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.DocId).HasColumnName("DocID");
            entity.Property(e => e.DocStatusId).HasColumnName("DocStatusID");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.FromGoodsTypeId).HasColumnName("fromGoodsTypeID");
            entity.Property(e => e.FromGoodsTypeName)
                .HasMaxLength(255)
                .HasColumnName("fromGoodsTypeName");
            entity.Property(e => e.FromIsCentre).HasColumnName("fromIsCentre");
            entity.Property(e => e.FromIsFactories).HasColumnName("fromIsFactories");
            entity.Property(e => e.FromIsProvince).HasColumnName("fromIsProvince");
            entity.Property(e => e.FromIsTbl).HasColumnName("fromIsTBL");
            entity.Property(e => e.FromStorehouseCode)
                .HasMaxLength(255)
                .HasColumnName("fromStorehouseCode");
            entity.Property(e => e.FromStorehouseListId).HasColumnName("fromStorehouseListID");
            entity.Property(e => e.FromStorehouseName)
                .HasMaxLength(255)
                .HasColumnName("fromStorehouseName");
            entity.Property(e => e.FromStorehouseTypeId).HasColumnName("fromStorehouseTypeID");
            entity.Property(e => e.FromStorehouseTypeName)
                .HasMaxLength(255)
                .HasColumnName("fromStorehouseTypeName");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.GroupName).HasMaxLength(500);
            entity.Property(e => e.IsDocStatus).HasMaxLength(20);
            entity.Property(e => e.RefDocId).HasColumnName("RefDocID");
            entity.Property(e => e.RefIsDocStatus).HasColumnName("refIsDocStatus");
            entity.Property(e => e.RequestFrom).HasColumnType("datetime");
            entity.Property(e => e.RequestStatus).HasMaxLength(255);
            entity.Property(e => e.RequestTo).HasColumnType("datetime");
            entity.Property(e => e.SignatureApprove).HasMaxLength(255);
            entity.Property(e => e.ToGoodsTypeId).HasColumnName("toGoodsTypeID");
            entity.Property(e => e.ToGoodsTypeName)
                .HasMaxLength(255)
                .HasColumnName("toGoodsTypeName");
            entity.Property(e => e.ToIsCentre).HasColumnName("toIsCentre");
            entity.Property(e => e.ToIsFactories).HasColumnName("toIsFactories");
            entity.Property(e => e.ToIsProvince).HasColumnName("toIsProvince");
            entity.Property(e => e.ToIsTbl).HasColumnName("toIsTBL");
            entity.Property(e => e.ToStorehouseCode)
                .HasMaxLength(255)
                .HasColumnName("toStorehouseCode");
            entity.Property(e => e.ToStorehouseListId).HasColumnName("toStorehouseListID");
            entity.Property(e => e.ToStorehouseName)
                .HasMaxLength(255)
                .HasColumnName("toStorehouseName");
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.WorkFlowStatusName).HasMaxLength(255);
        });

        modelBuilder.Entity<TbDocumentsBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TbDocumentsBackup");

            entity.Property(e => e.AcceptedDate).HasColumnType("datetime");
            entity.Property(e => e.Approvers).HasMaxLength(255);
            entity.Property(e => e.AreaId).HasColumnName("AreaID");
            entity.Property(e => e.AttFiles).HasMaxLength(255);
            entity.Property(e => e.CarLicense).HasMaxLength(255);
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.Consignee).HasMaxLength(1400);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerName).HasMaxLength(1400);
            entity.Property(e => e.DelivName).HasMaxLength(255);
            entity.Property(e => e.DocCode).HasMaxLength(22);
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.DocId).HasColumnName("DocID");
            entity.Property(e => e.DocStatus).HasMaxLength(20);
            entity.Property(e => e.DocStatusId).HasColumnName("DocStatusID");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.ExposeDate).HasMaxLength(10);
            entity.Property(e => e.ExposeTime).HasMaxLength(10);
            entity.Property(e => e.FirstReviewer).HasMaxLength(255);
            entity.Property(e => e.FromStorehouseListId).HasColumnName("FromStorehouseListID");
            entity.Property(e => e.IssueType).HasMaxLength(4);
            entity.Property(e => e.OwnerName).HasMaxLength(255);
            entity.Property(e => e.PaymentCode).HasMaxLength(255);
            entity.Property(e => e.ReceiveFrom).HasMaxLength(255);
            entity.Property(e => e.RefCode).HasMaxLength(255);
            entity.Property(e => e.Requester).HasMaxLength(255);
            entity.Property(e => e.SaleName).HasMaxLength(255);
            entity.Property(e => e.SecondReviewer).HasMaxLength(255);
            entity.Property(e => e.SecondSignature).HasMaxLength(255);
            entity.Property(e => e.Signature).HasMaxLength(255);
            entity.Property(e => e.TaxId)
                .HasMaxLength(20)
                .HasColumnName("TaxID");
            entity.Property(e => e.Telephone).HasMaxLength(1400);
            entity.Property(e => e.ToStorehouseListId).HasColumnName("ToStorehouseListID");
            entity.Property(e => e.TranferCode).HasMaxLength(255);
            entity.Property(e => e.TranferType).HasMaxLength(250);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
        });

        modelBuilder.Entity<TbDocumentsDummy>(entity =>
        {
            entity.HasKey(e => new { e.DummyId, e.StorehouseListId, e.UserId }).HasName("PK_TbDocumentsTemp");

            entity.ToTable("TbDocumentsDummy");

            entity.Property(e => e.DummyId).HasColumnName("DummyID");
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<TbDriver>(entity =>
        {
            entity.HasKey(e => e.DriverId);

            entity.Property(e => e.DriverId).HasColumnName("DriverID");
            entity.Property(e => e.CarId).HasColumnName("CarID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EmpCode).HasMaxLength(16);
            entity.Property(e => e.FullName).HasMaxLength(255);
            entity.Property(e => e.LocId).HasColumnName("LocID");
            entity.Property(e => e.Position).HasMaxLength(255);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Car).WithMany(p => p.TbDrivers)
                .HasForeignKey(d => d.CarId)
                .HasConstraintName("FK__TbDrivers__CarID__7720AD13");

            entity.HasOne(d => d.Loc).WithMany(p => p.TbDrivers)
                .HasForeignKey(d => d.LocId)
                .HasConstraintName("FK__TbDrivers__LocID__7814D14C");

            entity.HasOne(d => d.Region).WithMany(p => p.TbDrivers)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK__TbDrivers__Regio__7908F585");
        });

        modelBuilder.Entity<TbEndOfDayChecking>(entity =>
        {
            entity.HasKey(e => e.CheckingId);

            entity.ToTable("TbEndOfDayChecking");

            entity.HasIndex(e => new { e.StorehouseListId, e.CreatedDate }, "idx_EndOfDayChecking_StorehouseListID_CreatedDate");

            entity.HasIndex(e => e.StorehouseListId, "index_CheckingByStorehouseList");

            entity.HasIndex(e => new { e.StorehouseListId, e.ProductCode }, "index_Tracking");

            entity.Property(e => e.CheckingId).HasColumnName("CheckingID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.ProductCode).HasMaxLength(16);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.RowsId).HasColumnName("RowsID");
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.StorehouseList).WithMany(p => p.TbEndOfDayCheckings)
                .HasForeignKey(d => d.StorehouseListId)
                .HasConstraintName("FK__TbEndOfDa__Store__14B10FFA");
        });

        modelBuilder.Entity<TbFactoriesAreaCode>(entity =>
        {
            entity.HasKey(e => e.ArId);

            entity.ToTable("TbFactoriesAreaCode");

            entity.Property(e => e.ArId).HasColumnName("ArID");
            entity.Property(e => e.ArCode).HasMaxLength(10);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FactId).HasColumnName("FactID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Fact).WithMany(p => p.TbFactoriesAreaCodes)
                .HasForeignKey(d => d.FactId)
                .HasConstraintName("FK__TbFactori__FactI__1F198FD4");
        });

        modelBuilder.Entity<TbFactory>(entity =>
        {
            entity.HasKey(e => e.FactId).HasName("PK_TbPlantType");

            entity.Property(e => e.FactId).HasColumnName("FactID");
            entity.Property(e => e.Address).HasMaxLength(500);
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FactName).HasMaxLength(400);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.ShortName).HasMaxLength(100);
            entity.Property(e => e.Tel).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbGoodsType>(entity =>
        {
            entity.HasKey(e => e.GoodsTypeId);

            entity.Property(e => e.GoodsTypeId).HasColumnName("GoodsTypeID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.GoodsTypeName).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasDefaultValue(false);
            entity.Property(e => e.Remark).HasMaxLength(1000);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbGroupHolding>(entity =>
        {
            entity.HasKey(e => e.GroupHoldingId);

            entity.ToTable("TbGroupHolding");

            entity.Property(e => e.GroupHoldingId).HasColumnName("GroupHoldingID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GroupHoldingName).HasMaxLength(500);
            entity.Property(e => e.IsActive).HasDefaultValue(false);
            entity.Property(e => e.IsCentre).HasDefaultValue(false);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbLocation>(entity =>
        {
            entity.HasKey(e => e.LocId);

            entity.Property(e => e.LocId).HasColumnName("LocID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.LocCode).HasMaxLength(5);
            entity.Property(e => e.LocName).HasMaxLength(255);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Region).WithMany(p => p.TbLocations)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK__TbLocatio__Regio__762C88DA");
        });

        modelBuilder.Entity<TbMetaBrandHolding>(entity =>
        {
            entity.HasKey(e => e.MetaBrandHoldingId);

            entity.ToTable("TbMetaBrandHolding");

            entity.Property(e => e.MetaBrandHoldingId).HasColumnName("MetaBrandHoldingID");
            entity.Property(e => e.BrandHoldingId).HasColumnName("BrandHoldingID");
            entity.Property(e => e.BrandId).HasColumnName("BrandID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.BrandHolding).WithMany(p => p.TbMetaBrandHoldings)
                .HasForeignKey(d => d.BrandHoldingId)
                .HasConstraintName("FK__TbMetaBra__Brand__1ABEEF0B");

            entity.HasOne(d => d.Brand).WithMany(p => p.TbMetaBrandHoldings)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK__TbMetaBra__Brand__1BB31344");
        });

        modelBuilder.Entity<TbMetaCategoriesHolding>(entity =>
        {
            entity.HasKey(e => e.MetaCategoriesHoldingId);

            entity.ToTable("TbMetaCategoriesHolding");

            entity.Property(e => e.MetaCategoriesHoldingId).HasColumnName("MetaCategoriesHoldingID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Category).WithMany(p => p.TbMetaCategoriesHoldings)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__TbMetaCat__Categ__1F83A428");

            entity.HasOne(d => d.Comp).WithMany(p => p.TbMetaCategoriesHoldings)
                .HasForeignKey(d => d.CompId)
                .HasConstraintName("FK__TbMetaCat__CompI__19CACAD2");
        });

        modelBuilder.Entity<TbMetaGroupHolding>(entity =>
        {
            entity.HasKey(e => e.MetaGroupHoldingId);

            entity.ToTable("TbMetaGroupHolding");

            entity.Property(e => e.MetaGroupHoldingId).HasColumnName("MetaGroupHoldingID");
            entity.Property(e => e.BrandHoldingId).HasColumnName("BrandHoldingID");
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.GroupHoldingId).HasColumnName("GroupHoldingID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.BrandHolding).WithMany(p => p.TbMetaGroupHoldings)
                .HasForeignKey(d => d.BrandHoldingId)
                .HasConstraintName("FK__TbMetaGro__Brand__1CA7377D");

            entity.HasOne(d => d.Comp).WithMany(p => p.TbMetaGroupHoldings)
                .HasForeignKey(d => d.CompId)
                .HasConstraintName("FK__TbMetaGro__CompI__1249A49B");

            entity.HasOne(d => d.GroupHolding).WithMany(p => p.TbMetaGroupHoldings)
                .HasForeignKey(d => d.GroupHoldingId)
                .HasConstraintName("FK__TbMetaGro__Group__1E8F7FEF");
        });

        modelBuilder.Entity<TbMetaPermission>(entity =>
        {
            entity.HasKey(e => e.MetaPermissionId);

            entity.ToTable("TbMetaPermission");

            entity.Property(e => e.MetaPermissionId).HasColumnName("MetaPermissionID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.PermissionId).HasColumnName("PermissionID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Group).WithMany(p => p.TbMetaPermissions)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK__TbMetaPer__Group__14270015");

            entity.HasOne(d => d.Permission).WithMany(p => p.TbMetaPermissions)
                .HasForeignKey(d => d.PermissionId)
                .HasConstraintName("FK__TbMetaPer__Permi__151B244E");
        });

        modelBuilder.Entity<TbMetaUser>(entity =>
        {
            entity.HasKey(e => e.MetaUserId);

            entity.ToTable("TbMetaUser");

            entity.HasIndex(e => new { e.UserId, e.StorehouseListId }, "IDX_User_Storehouse");

            entity.HasIndex(e => e.UserId, "idx_TbMetaUser_UserID");

            entity.HasIndex(e => new { e.UserId, e.GroupId, e.WarehouseId, e.StorehouseListId }, "index_MetaUser");

            entity.Property(e => e.MetaUserId).HasColumnName("MetaUserID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.GroupHoldingId).HasColumnName("GroupHoldingID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

            entity.HasOne(d => d.GroupHolding).WithMany(p => p.TbMetaUsers)
                .HasForeignKey(d => d.GroupHoldingId)
                .HasConstraintName("FK__TbMetaUse__Group__6AFACD50");

            entity.HasOne(d => d.Group).WithMany(p => p.TbMetaUsers)
                .HasForeignKey(d => d.GroupId)
                .HasConstraintName("FK__TbMetaUse__Group__52E34C9D");

            entity.HasOne(d => d.Role).WithMany(p => p.TbMetaUsers)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__TbMetaUse__RoleI__58F12BAE");

            entity.HasOne(d => d.StorehouseList).WithMany(p => p.TbMetaUsers)
                .HasForeignKey(d => d.StorehouseListId)
                .HasConstraintName("FK__TbMetaUse__Store__54CB950F");

            entity.HasOne(d => d.User).WithMany(p => p.TbMetaUsers)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__TbMetaUse__UserI__56B3DD81");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.TbMetaUsers)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK__TbMetaUse__Wareh__019E3B86");
        });

        modelBuilder.Entity<TbPermission>(entity =>
        {
            entity.HasKey(e => e.PermissionId);

            entity.ToTable("TbPermission");

            entity.Property(e => e.PermissionId).HasColumnName("PermissionID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MenuName).HasMaxLength(255);
            entity.Property(e => e.MenuUrl)
                .HasMaxLength(255)
                .HasColumnName("MenuURL");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId);

            entity.HasIndex(e => e.CategoryId, "UVW_ProductRegionalBroughtForward_CategoryID");

            entity.HasIndex(e => e.ProductCode, "idx_ProductCode");

            entity.HasIndex(e => e.ProductCode, "idx_TbProducts_ProductCode");

            entity.HasIndex(e => e.ProductCode, "idx_products_code");

            entity.HasIndex(e => e.ProductCode, "index_Products");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.BrandId).HasColumnName("BrandID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.ConversionId).HasColumnName("ConversionID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CsperPlt).HasColumnName("CSPerPLT");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.ProductCode).HasMaxLength(16);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.BaseUnitNavigation).WithMany(p => p.TbProductBaseUnitNavigations)
                .HasForeignKey(d => d.BaseUnit)
                .HasConstraintName("FK__TbProduct__BaseU__68D28DBC");

            entity.HasOne(d => d.Brand).WithMany(p => p.TbProducts)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK__TbProduct__Brand__6ABAD62E");

            entity.HasOne(d => d.Category).WithMany(p => p.TbProducts)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__TbProduct__Categ__6BAEFA67");

            entity.HasOne(d => d.Conversion).WithMany(p => p.TbProducts)
                .HasForeignKey(d => d.ConversionId)
                .HasConstraintName("FK__TbProduct__Conve__69C6B1F5");

            entity.HasOne(d => d.SalesUnitNavigation).WithMany(p => p.TbProductSalesUnitNavigations)
                .HasForeignKey(d => d.SalesUnit)
                .HasConstraintName("FK__TbProduct__Sales__67DE6983");

            entity.HasOne(d => d.SubCategory).WithMany(p => p.TbProducts)
                .HasForeignKey(d => d.SubCategoryId)
                .HasConstraintName("FK__TbProduct__SubCa__6CA31EA0");
        });

        modelBuilder.Entity<TbProductBroughtForward>(entity =>
        {
            entity.HasKey(e => e.Idx);

            entity.ToTable("TbProductBroughtForward");

            entity.Property(e => e.Idx).HasColumnName("IDx");
            entity.Property(e => e.AdvPayVal).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.BrokenVal).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.ExpoVal).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.ProductCode).HasMaxLength(16);
            entity.Property(e => e.ReceVal).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
        });

        modelBuilder.Entity<TbProductBroughtForwardCurrent>(entity =>
        {
            entity.HasKey(e => e.RowsId);

            entity.ToTable("TbProductBroughtForwardCurrent");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ProductCode).HasMaxLength(16);
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.WarehouseCode).HasMaxLength(8);
        });

        modelBuilder.Entity<TbProductManufacturedDate>(entity =>
        {
            entity.HasKey(e => e.ManuTransId);

            entity.ToTable("TbProductManufacturedDate");

            entity.Property(e => e.ManuTransId).HasColumnName("ManuTransID");
            entity.Property(e => e.Act).HasMaxLength(10);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocId).HasColumnName("DocID");
            entity.Property(e => e.ManufactureDate).HasMaxLength(15);
            entity.Property(e => e.NewManufactureDate).HasMaxLength(15);
            entity.Property(e => e.ProductCode).HasMaxLength(16);
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.StorehouseList).WithMany(p => p.TbProductManufacturedDates)
                .HasForeignKey(d => d.StorehouseListId)
                .HasConstraintName("FK__TbProduct__Store__5C57A83E");
        });

        modelBuilder.Entity<TbProductReginalSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TbProductReginalSummary");

            entity.Property(e => e.AdvanceDiv).HasColumnType("decimal(20, 10)");
            entity.Property(e => e.AdvanceUnit)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AmountDiv).HasColumnType("decimal(20, 10)");
            entity.Property(e => e.AmountUnit)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.BalanceDiv).HasColumnType("decimal(20, 10)");
            entity.Property(e => e.BalanceUnit)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.BreakDiv).HasColumnType("decimal(20, 10)");
            entity.Property(e => e.BreakUnit)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.BroughtForwardDiv).HasColumnType("decimal(20, 10)");
            entity.Property(e => e.BroughtForwardUnit)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CheckingDiv).HasColumnType("decimal(20, 10)");
            entity.Property(e => e.CheckingUnit)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DiffDiv).HasColumnType("decimal(20, 10)");
            entity.Property(e => e.DiffUnit)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ExpoDiv).HasColumnType("decimal(20, 10)");
            entity.Property(e => e.ExpoUnit)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProductName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ReceDiv).HasColumnType("decimal(20, 10)");
            entity.Property(e => e.ReceUnit)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RegionCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.StockUnitName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StorehouseCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.StorehouseName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.StorehouseTypeId).HasColumnName("StorehouseTypeID");
            entity.Property(e => e.StorehouseTypeName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
            entity.Property(e => e.SubCategoryName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UnitId).HasColumnName("UnitID");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.WarehouseName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TbProductRegionalBroughtForward>(entity =>
        {
            entity.HasKey(e => e.Idx);

            entity.ToTable("TbProductRegionalBroughtForward");

            entity.HasIndex(e => new { e.StorehouseListId, e.LastUpdate }, "TbProductRegionalBroughtForward_StorehouseListIDLastUpdate");

            entity.Property(e => e.Idx).HasColumnName("IDx");
            entity.Property(e => e.AdvanceDiv).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.AdvanceUnit).HasMaxLength(20);
            entity.Property(e => e.AmountDiv).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.AmountUnit).HasMaxLength(20);
            entity.Property(e => e.BalanceDiv).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.BalanceUnit).HasMaxLength(20);
            entity.Property(e => e.BreakDiv).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.BreakUnit).HasMaxLength(20);
            entity.Property(e => e.BroughtForwardDiv).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.BroughtForwardUnit).HasMaxLength(20);
            entity.Property(e => e.CheckingDiv).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.CheckingUnit).HasMaxLength(20);
            entity.Property(e => e.DiffDiv).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.DiffUnit).HasMaxLength(20);
            entity.Property(e => e.ExpoDiv).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ExpoUnit).HasMaxLength(20);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.ProductCode).HasMaxLength(20);
            entity.Property(e => e.ReceDiv).HasColumnType("decimal(38, 18)");
            entity.Property(e => e.ReceUnit).HasMaxLength(20);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
        });

        modelBuilder.Entity<TbProductRegionalStock>(entity =>
        {
            entity.HasKey(e => e.ProductStockId).HasName("PK__TbProduc__8EA5111A67249B1F");

            entity.ToTable("TbProductRegionalStock");

            entity.HasIndex(e => e.CategoryId, "IDX_TbProductRegionalStock_CategoryID");

            entity.HasIndex(e => e.ProductCode, "IDX_TbProductRegionalStock_ProductCode");

            entity.Property(e => e.ProductStockId).HasColumnName("ProductStockID");
            entity.Property(e => e.AdvanceDiv).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.AdvanceQty).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.AdvanceUnit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AmountDiv).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.AmountQty).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.AmountUnit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BalanceDiv).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.BalanceQty).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.BalanceUnit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BreakDiv).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.BreakQty).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.BreakUnit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BroughtForwardDiv).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.BroughtForwardQty).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.BroughtForwardUnit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName).HasMaxLength(255);
            entity.Property(e => e.CheckingDiv).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.CheckingQty).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.CheckingUnit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Conversion).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DiffDiv).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.DiffQty).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.DiffUnit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ExpoDiv).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.ExpoQty).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.ExpoUnit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IsPremium).HasDefaultValue(false);
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ReceDiv).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.ReceQty).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.ReceUnit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RegionCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.StockUnitName).HasMaxLength(255);
            entity.Property(e => e.StorehouseCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.StorehouseName).HasMaxLength(255);
            entity.Property(e => e.StorehouseTypeId).HasColumnName("StorehouseTypeID");
            entity.Property(e => e.StorehouseTypeName).HasMaxLength(255);
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
            entity.Property(e => e.SubCategoryName).HasMaxLength(255);
            entity.Property(e => e.UnitId).HasColumnName("UnitID");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WarehouseName).HasMaxLength(255);
        });

        modelBuilder.Entity<TbProductStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId);

            entity.ToTable("TbProductStatus");

            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.StatusCode).HasMaxLength(16);
            entity.Property(e => e.StatusName).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbProductTransaction>(entity =>
        {
            entity.HasKey(e => e.TransId);

            entity.ToTable(tb => tb.HasTrigger("DataSummaryExpose"));

            entity.HasIndex(e => new { e.ProductCode, e.StorehouseListId, e.UpdatedDate, e.IsActive }, "IX_TbProductTransactions");

            entity.HasIndex(e => e.IsActive, "idx_IsActive");

            entity.HasIndex(e => e.ProductCode, "idx_ProductCode");

            entity.HasIndex(e => e.StorehouseListId, "idx_ProductTransactionsByStorehouseListID");

            entity.HasIndex(e => e.StorehouseListId, "idx_ProductTransactionsByStorehouseListIDByDocID");

            entity.HasIndex(e => new { e.ProductCode, e.StorehouseListId }, "idx_ProductTransactions_ProductCode_StorehouseListID");

            entity.HasIndex(e => e.StorehouseListId, "idx_ProductTransactions_StorehouseListID");

            entity.HasIndex(e => e.RefCode, "idx_RefCode");

            entity.HasIndex(e => e.StorehouseListId, "idx_StorehouseListID");

            entity.HasIndex(e => new { e.DocId, e.ProductCode, e.StorehouseListId }, "idx_TbProductTransactions_DocID_ProductCode_StorehouseListID");

            entity.HasIndex(e => new { e.DocId, e.ProductCode, e.StorehouseListId }, "index_ProductTrans");

            entity.HasIndex(e => new { e.StorehouseListId, e.IsActive }, "index_ProductTransByStorehouseList");

            entity.HasIndex(e => new { e.ProductCode, e.RefCode, e.DocId, e.StorehouseListId, e.ReceQty, e.CreatedDate }, "index_ProductTransactions");

            entity.HasIndex(e => e.Price, "index_ProductTransactionsWithPrice");

            entity.HasIndex(e => new { e.StorehouseListId, e.Price }, "index_ProductTransactionsWithStorehouseListIDandPrice");

            entity.Property(e => e.TransId).HasColumnName("TransID");
            entity.Property(e => e.AttFiles).HasMaxLength(255);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocId).HasColumnName("DocID");
            entity.Property(e => e.ExpiredDate).HasColumnType("datetime");
            entity.Property(e => e.IssueDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentCode).HasMaxLength(50);
            entity.Property(e => e.ProductCode).HasMaxLength(16);
            entity.Property(e => e.RefCode).HasMaxLength(50);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Doc).WithMany(p => p.TbProductTransactions)
                .HasForeignKey(d => d.DocId)
                .HasConstraintName("FK__TbProduct__DocID__133DC8D4");

            entity.HasOne(d => d.StorehouseList).WithMany(p => p.TbProductTransactions)
                .HasForeignKey(d => d.StorehouseListId)
                .HasConstraintName("FK__TbProduct__Store__1431ED0D");
        });

        modelBuilder.Entity<TbProductTransactionsBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TbProductTransactionsBackup");

            entity.Property(e => e.AttFiles).HasMaxLength(255);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocId).HasColumnName("DocID");
            entity.Property(e => e.ExpiredDate).HasColumnType("datetime");
            entity.Property(e => e.IssueDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentCode).HasMaxLength(50);
            entity.Property(e => e.ProductCode).HasMaxLength(16);
            entity.Property(e => e.RefCode).HasMaxLength(50);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.TransId).HasColumnName("TransID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbProductType>(entity =>
        {
            entity.HasKey(e => e.BrandId);

            entity.ToTable("TbProductType");

            entity.Property(e => e.BrandId)
                .ValueGeneratedNever()
                .HasColumnName("BrandID");
            entity.Property(e => e.BrandCode).HasMaxLength(8);
            entity.Property(e => e.BrandName).HasMaxLength(255);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbProductWarehouseStock>(entity =>
        {
            entity.HasKey(e => e.ProductStockId).HasName("PK__TbProduc__8EA5111AB55274AD");

            entity.ToTable("TbProductWarehouseStock");

            entity.HasIndex(e => e.CategoryId, "IDX_TbProductWarehouseStock_CategoryID");

            entity.HasIndex(e => e.ProductCode, "IDX_TbProductWarehouseStock_ProductCode");

            entity.Property(e => e.ProductStockId).HasColumnName("ProductStockID");
            entity.Property(e => e.AdvanceDiv).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.AdvanceQty).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.AdvanceUnit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AmountDiv).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.AmountQty).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.AmountUnit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BalanceDiv).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.BalanceQty).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.BalanceUnit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BreakDiv).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.BreakQty).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.BreakUnit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BroughtForwardDiv).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.BroughtForwardQty).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.BroughtForwardUnit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName).HasMaxLength(255);
            entity.Property(e => e.CheckingDiv).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.CheckingQty).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.CheckingUnit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Conversion).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.DiffDiv).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.DiffQty).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.DiffUnit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ExpoDiv).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.ExpoQty).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.ExpoUnit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.IsPremium).HasDefaultValue(false);
            entity.Property(e => e.LastUpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ReceDiv).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.ReceQty).HasColumnType("decimal(30, 15)");
            entity.Property(e => e.ReceUnit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RegionCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.StockUnitName).HasMaxLength(255);
            entity.Property(e => e.StorehouseCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.StorehouseName).HasMaxLength(255);
            entity.Property(e => e.StorehouseTypeId).HasColumnName("StorehouseTypeID");
            entity.Property(e => e.StorehouseTypeName).HasMaxLength(255);
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
            entity.Property(e => e.SubCategoryName).HasMaxLength(255);
            entity.Property(e => e.UnitId).HasColumnName("UnitID");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.WarehouseCode)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.WarehouseName).HasMaxLength(255);
        });

        modelBuilder.Entity<TbProvince>(entity =>
        {
            entity.HasKey(e => e.ProvinceId);

            entity.ToTable("TbProvince");

            entity.Property(e => e.ProvinceId).ValueGeneratedNever();
            entity.Property(e => e.CreatedAt)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ProvinceCode).HasMaxLength(4);
            entity.Property(e => e.ProvinceNameEn).HasMaxLength(200);
            entity.Property(e => e.ProvinceNameTh).HasMaxLength(200);
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbRegion>(entity =>
        {
            entity.HasKey(e => e.RegionId);

            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.RegionCode).HasMaxLength(8);
            entity.Property(e => e.RegionName).HasMaxLength(255);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbReportTransaction>(entity =>
        {
            entity.HasKey(e => e.ReportTransactionsId).HasName("PK__TbReport__93DE863804E2F582");

            entity.Property(e => e.BrandHoldingId).HasColumnName("BrandHoldingID");
            entity.Property(e => e.CancelRemark).HasMaxLength(300);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ReportTransactionDate).HasColumnType("datetime");
            entity.Property(e => e.ReportTransactionName).HasMaxLength(500);
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.BrandHolding).WithMany(p => p.TbReportTransactions)
                .HasForeignKey(d => d.BrandHoldingId)
                .HasConstraintName("FK__TbReportT__Brand__4B622666");

            entity.HasOne(d => d.StorehouseList).WithMany(p => p.TbReportTransactions)
                .HasForeignKey(d => d.StorehouseListId)
                .HasConstraintName("FK__TbReportT__Store__056ECC6A");

            entity.HasOne(d => d.WorkFlow).WithMany(p => p.TbReportTransactions)
                .HasForeignKey(d => d.WorkFlowId)
                .HasConstraintName("FK__TbReportT__WorkF__0662F0A3");

            entity.HasOne(d => d.WorkFlowStatus).WithMany(p => p.TbReportTransactions)
                .HasForeignKey(d => d.WorkFlowStatusId)
                .HasConstraintName("FK__TbReportT__WorkF__489AC854");
        });

        modelBuilder.Entity<TbSale>(entity =>
        {
            entity.HasKey(e => e.SaleId).HasName("PK__TbSale__1EE3C3FFF4DC129E");

            entity.ToTable("TbSale");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.SaleCode)
                .HasMaxLength(20)
                .HasColumnName("saleCode");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.SaleUnit).WithMany(p => p.TbSales)
                .HasForeignKey(d => d.SaleUnitId)
                .HasConstraintName("FK_TbSale_TbSaleUnitMaster");
        });

        modelBuilder.Entity<TbSaleAccessList>(entity =>
        {
            entity.HasKey(e => e.SaleAccessListId).HasName("PK__TbSaleAc__04E4B7FE046E19E3");

            entity.ToTable("TbSaleAccessList");

            entity.Property(e => e.ComId).HasColumnName("ComID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Com).WithMany(p => p.TbSaleAccessLists)
                .HasForeignKey(d => d.ComId)
                .HasConstraintName("FK_TbSaleAccessList_TbCompanyProfile");

            entity.HasOne(d => d.Sale).WithMany(p => p.TbSaleAccessLists)
                .HasForeignKey(d => d.SaleId)
                .HasConstraintName("FK_TbSaleAccessList_TbSale");

            entity.HasOne(d => d.StorehouseList).WithMany(p => p.TbSaleAccessLists)
                .HasForeignKey(d => d.StorehouseListId)
                .HasConstraintName("FK_TbSaleAccessList_TbStorehouseList");
        });

        modelBuilder.Entity<TbSaleUnitGroupType>(entity =>
        {
            entity.HasKey(e => e.SaleTypeId).HasName("PK__TbSaleUn__A16AC327FFCD3D4A");

            entity.ToTable("TbSaleUnitGroupType");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.SaleTypeName).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbSaleUnitMaster>(entity =>
        {
            entity.HasKey(e => e.SaleUnitId).HasName("PK__TbSaleUn__0E17E5A6BD4E7066");

            entity.ToTable("TbSaleUnitMaster");

            entity.Property(e => e.AreaGroupName).HasMaxLength(100);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.RegionGroupName).HasMaxLength(100);
            entity.Property(e => e.SaleUnitDesc).HasMaxLength(300);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Region).WithMany(p => p.TbSaleUnitMasters)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK_TbSaleUnitMaster_TbRegions");

            entity.HasOne(d => d.SaleType).WithMany(p => p.TbSaleUnitMasters)
                .HasForeignKey(d => d.SaleTypeId)
                .HasConstraintName("FK_TbSaleUnitMaster_TbSaleUnitGroupType");
        });

        modelBuilder.Entity<TbSalesArea>(entity =>
        {
            entity.HasKey(e => e.AreaId);

            entity.Property(e => e.AreaId).HasColumnName("AreaID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.SalesAreaCode).HasMaxLength(5);
            entity.Property(e => e.SalesAreaName).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Region).WithMany(p => p.TbSalesAreas)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK__TbSalesAr__Regio__498EEC8D");
        });

        modelBuilder.Entity<TbStockTrackingChangeRequestDetail>(entity =>
        {
            entity.HasKey(e => e.RequestId);

            entity.ToTable("TbStockTrackingChangeRequestDetail");

            entity.Property(e => e.CheckingId).HasColumnName("CheckingID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.RequestFrom).HasMaxLength(500);
            entity.Property(e => e.RequestReason).HasMaxLength(500);
            entity.Property(e => e.RequestTo).HasMaxLength(500);
            entity.Property(e => e.RequestTypeId).HasDefaultValue(2);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.RequestType).WithMany(p => p.TbStockTrackingChangeRequestDetails)
                .HasForeignKey(d => d.RequestTypeId)
                .HasConstraintName("FK__TbStockTr__Reque__51700577");
        });

        modelBuilder.Entity<TbStockUnit>(entity =>
        {
            entity.HasKey(e => e.StockUnitId);

            entity.ToTable("TbStockUnit");

            entity.HasIndex(e => e.StockUnitId, "idx_DocID");

            entity.HasIndex(e => e.StockUnitId, "idx_TbStockUnit_StockUnitID");

            entity.Property(e => e.StockUnitId).HasColumnName("StockUnitID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.StockUnitCode).HasMaxLength(16);
            entity.Property(e => e.StockUnitName).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbStorehouse>(entity =>
        {
            entity.HasKey(e => e.StorehouseId);

            entity.ToTable("TbStorehouse");

            entity.HasIndex(e => e.StorehouseId, "IDX_Storehouse");

            entity.HasIndex(e => e.StorehouseId, "idx_TbStorehouse_StorehouseID");

            entity.Property(e => e.StorehouseId).HasColumnName("StorehouseID");
            entity.Property(e => e.AccountingTypeId).HasColumnName("AccountingTypeID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.GoodsTypeId).HasColumnName("GoodsTypeID");
            entity.Property(e => e.IsActive).HasDefaultValue(false);
            entity.Property(e => e.IsCentre).HasDefaultValue(false);
            entity.Property(e => e.IsFactories).HasDefaultValue(false);
            entity.Property(e => e.IsFlagTbl)
                .HasDefaultValue(false)
                .HasColumnName("IsFlagTBL");
            entity.Property(e => e.IsProvince).HasDefaultValue(false);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.StorehouseCode).HasMaxLength(8);
            entity.Property(e => e.StorehouseName).HasMaxLength(255);
            entity.Property(e => e.StorehouseNameOmSap).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.AccountingType).WithMany(p => p.TbStorehouses)
                .HasForeignKey(d => d.AccountingTypeId)
                .HasConstraintName("FK__TbStoreho__Accou__53584DE9");

            entity.HasOne(d => d.GoodsType).WithMany(p => p.TbStorehouses)
                .HasForeignKey(d => d.GoodsTypeId)
                .HasConstraintName("FK__TbStoreho__Goods__4B422AD5");

            entity.HasOne(d => d.Region).WithMany(p => p.TbStorehouses)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK__TbStoreho__Regio__4A4E069C");
        });

        modelBuilder.Entity<TbStorehouseList>(entity =>
        {
            entity.HasKey(e => e.StorehouseListId);

            entity.ToTable("TbStorehouseList");

            entity.HasIndex(e => new { e.StorehouseListId, e.StorehouseId, e.WarehouseId, e.StorehouseTypeId }, "IDX_StorehouseList_Storehouse");

            entity.HasIndex(e => e.StorehouseListId, "idx_StorehouseListID");

            entity.HasIndex(e => e.StorehouseTypeId, "idx_StorehouseListIncludeStorehouseId");

            entity.HasIndex(e => e.StorehouseId, "idx_TbStorehouseList_StorehouseID");

            entity.HasIndex(e => e.StorehouseListId, "idx_TbStorehouseList_StorehouseListID");

            entity.HasIndex(e => new { e.StorehouseId, e.WarehouseId, e.StorehouseTypeId, e.BusinessUnitId }, "index_StorehouseList");

            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.AccountingTypeId).HasColumnName("AccountingTypeID");
            entity.Property(e => e.BusinessUnitId).HasColumnName("BusinessUnitID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.StorehouseId).HasColumnName("StorehouseID");
            entity.Property(e => e.StorehouseListIcon).HasMaxLength(50);
            entity.Property(e => e.StorehouseTypeId).HasColumnName("StorehouseTypeID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");

            entity.HasOne(d => d.BusinessUnit).WithMany(p => p.TbStorehouseLists)
                .HasForeignKey(d => d.BusinessUnitId)
                .HasConstraintName("FK__TbStoreho__Busin__4F12BBB9");

            entity.HasOne(d => d.SaleUnit).WithMany(p => p.TbStorehouseLists)
                .HasForeignKey(d => d.SaleUnitId)
                .HasConstraintName("FK__TbStoreho__SaleU__28D80438");

            entity.HasOne(d => d.Storehouse).WithMany(p => p.TbStorehouseLists)
                .HasForeignKey(d => d.StorehouseId)
                .HasConstraintName("FK__TbStoreho__Store__4C364F0E");

            entity.HasOne(d => d.StorehouseType).WithMany(p => p.TbStorehouseLists)
                .HasForeignKey(d => d.StorehouseTypeId)
                .HasConstraintName("FK__TbStoreho__Store__4E1E9780");

            entity.HasOne(d => d.Warehouse).WithMany(p => p.TbStorehouseLists)
                .HasForeignKey(d => d.WarehouseId)
                .HasConstraintName("FK__TbStoreho__Wareh__041093DD");
        });

        modelBuilder.Entity<TbStorehouseType>(entity =>
        {
            entity.HasKey(e => e.StorehouseTypeId);

            entity.ToTable("TbStorehouseType");

            entity.Property(e => e.StorehouseTypeId).HasColumnName("StorehouseTypeID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.StorehouseTypeName).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbSubCategory>(entity =>
        {
            entity.HasKey(e => e.SubCategoryId);

            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.SubCategoryCode).HasMaxLength(8);
            entity.Property(e => e.SubCategoryName).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbSummaryExposeDatum>(entity =>
        {
            entity.HasKey(e => e.RowNo);

            entity.Property(e => e.AdvActionStatus).HasMaxLength(500);
            entity.Property(e => e.AdvPayAction).HasMaxLength(500);
            entity.Property(e => e.AdvPayApproved).HasMaxLength(50);
            entity.Property(e => e.AdvPayApprovedDate).HasMaxLength(50);
            entity.Property(e => e.AdvPayApprover).HasMaxLength(50);
            entity.Property(e => e.AdvReceiptAction).HasMaxLength(500);
            entity.Property(e => e.AdvancePayReceiptDocCode).HasMaxLength(500);
            entity.Property(e => e.AdvancePayReceiptDocId)
                .HasMaxLength(500)
                .HasColumnName("AdvancePayReceiptDocID");
            entity.Property(e => e.AdvanceReceiptPayIsDocStatus).HasMaxLength(500);
            entity.Property(e => e.AdvanceReceiptPayRowCountx).HasMaxLength(500);
            entity.Property(e => e.Approvers).HasMaxLength(50);
            entity.Property(e => e.AttFiles).HasMaxLength(500);
            entity.Property(e => e.BusinessUnitId).HasColumnName("BusinessUnitID");
            entity.Property(e => e.BusinessUnitName).HasMaxLength(500);
            entity.Property(e => e.CreatedDate).HasMaxLength(50);
            entity.Property(e => e.DocCode).HasMaxLength(50);
            entity.Property(e => e.DocDate).HasMaxLength(50);
            entity.Property(e => e.DocId).HasColumnName("DocID");
            entity.Property(e => e.DocStatus).HasMaxLength(50);
            entity.Property(e => e.FromGoodsTypeId).HasColumnName("fromGoodsTypeID");
            entity.Property(e => e.FromGoodsTypeName)
                .HasMaxLength(50)
                .HasColumnName("fromGoodsTypeName");
            entity.Property(e => e.FromIsCentre).HasColumnName("fromIsCentre");
            entity.Property(e => e.FromIsFactories).HasColumnName("fromIsFactories");
            entity.Property(e => e.FromIsProvince).HasColumnName("fromIsProvince");
            entity.Property(e => e.FromIsTbl).HasColumnName("fromIsTBL");
            entity.Property(e => e.FromStorehouseCode)
                .HasMaxLength(50)
                .HasColumnName("fromStorehouseCode");
            entity.Property(e => e.FromStorehouseListId).HasColumnName("fromStorehouseListID");
            entity.Property(e => e.FromStorehouseName)
                .HasMaxLength(50)
                .HasColumnName("fromStorehouseName");
            entity.Property(e => e.FromStorehouseTypeId).HasColumnName("fromStorehouseTypeID");
            entity.Property(e => e.FromStorehouseTypeName)
                .HasMaxLength(50)
                .HasColumnName("fromStorehouseTypeName");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.GroupName).HasMaxLength(500);
            entity.Property(e => e.IsDocStatus).HasMaxLength(50);
            entity.Property(e => e.RefCode).HasMaxLength(500);
            entity.Property(e => e.RefCodeOrderPayment).HasMaxLength(500);
            entity.Property(e => e.RefDocId)
                .HasMaxLength(500)
                .HasColumnName("RefDocID");
            entity.Property(e => e.RefIsDocStatus)
                .HasMaxLength(500)
                .HasColumnName("refIsDocStatus");
            entity.Property(e => e.SignatureApprove).HasMaxLength(500);
            entity.Property(e => e.ToGoodsTypeId).HasColumnName("toGoodsTypeID");
            entity.Property(e => e.ToGoodsTypeName)
                .HasMaxLength(50)
                .HasColumnName("toGoodsTypeName");
            entity.Property(e => e.ToIsCentre).HasColumnName("toIsCentre");
            entity.Property(e => e.ToIsFactories).HasColumnName("toIsFactories");
            entity.Property(e => e.ToIsProvince).HasColumnName("toIsProvince");
            entity.Property(e => e.ToIsTbl).HasColumnName("toIsTBL");
            entity.Property(e => e.ToStorehouseCode)
                .HasMaxLength(50)
                .HasColumnName("toStorehouseCode");
            entity.Property(e => e.ToStorehouseListId).HasColumnName("toStorehouseListID");
            entity.Property(e => e.ToStorehouseName)
                .HasMaxLength(500)
                .HasColumnName("toStorehouseName");
            entity.Property(e => e.TypeName).HasMaxLength(500);
            entity.Property(e => e.UpdatedDate).HasMaxLength(50);
        });

        modelBuilder.Entity<TbTadvanceDeflect>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TbTAdvanceDeflect");

            entity.Property(e => e.DocId).HasColumnName("DocID");
            entity.Property(e => e.Pcount).HasColumnName("PCount");
            entity.Property(e => e.RefCode).HasMaxLength(50);
        });

        modelBuilder.Entity<TbTadvanceDeflectAmount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TbTAdvanceDeflectAmount");

            entity.Property(e => e.DocCode).HasMaxLength(50);
            entity.Property(e => e.DocId).HasColumnName("DocID");
            entity.Property(e => e.RefCode).HasMaxLength(50);
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.TransId).HasColumnName("TransID");
        });

        modelBuilder.Entity<TbTadvanceDocument>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TbTAdvanceDocuments");

            entity.Property(e => e.AdvPayAction).HasMaxLength(255);
            entity.Property(e => e.AdvPayApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AdvPayApprover).HasMaxLength(255);
            entity.Property(e => e.AdvancePayReceiptDocId).HasColumnName("AdvancePayReceiptDocID");
            entity.Property(e => e.Approvers).HasMaxLength(500);
            entity.Property(e => e.AttFiles).HasMaxLength(255);
            entity.Property(e => e.BusinessUnitId).HasColumnName("BusinessUnitID");
            entity.Property(e => e.BusinessUnitName).HasMaxLength(500);
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DelivName).HasMaxLength(500);
            entity.Property(e => e.DocCode).HasMaxLength(22);
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.DocId).HasColumnName("DocID");
            entity.Property(e => e.DocStatusId).HasColumnName("DocStatusID");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.FromGoodsTypeId).HasColumnName("fromGoodsTypeID");
            entity.Property(e => e.FromGoodsTypeName)
                .HasMaxLength(255)
                .HasColumnName("fromGoodsTypeName");
            entity.Property(e => e.FromIsCentre).HasColumnName("fromIsCentre");
            entity.Property(e => e.FromIsFactories).HasColumnName("fromIsFactories");
            entity.Property(e => e.FromIsProvince).HasColumnName("fromIsProvince");
            entity.Property(e => e.FromIsTbl).HasColumnName("fromIsTBL");
            entity.Property(e => e.FromStorehouseCode)
                .HasMaxLength(255)
                .HasColumnName("fromStorehouseCode");
            entity.Property(e => e.FromStorehouseListId).HasColumnName("fromStorehouseListID");
            entity.Property(e => e.FromStorehouseName)
                .HasMaxLength(255)
                .HasColumnName("fromStorehouseName");
            entity.Property(e => e.FromStorehouseTypeId).HasColumnName("fromStorehouseTypeID");
            entity.Property(e => e.FromStorehouseTypeName)
                .HasMaxLength(255)
                .HasColumnName("fromStorehouseTypeName");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.GroupName).HasMaxLength(500);
            entity.Property(e => e.IsDocStatus).HasMaxLength(20);
            entity.Property(e => e.RefDocId).HasColumnName("RefDocID");
            entity.Property(e => e.RefIsDocStatus).HasColumnName("refIsDocStatus");
            entity.Property(e => e.RequestFrom).HasColumnType("datetime");
            entity.Property(e => e.RequestStatus).HasMaxLength(255);
            entity.Property(e => e.RequestTo).HasColumnType("datetime");
            entity.Property(e => e.SignatureApprove).HasMaxLength(255);
            entity.Property(e => e.ToGoodsTypeId).HasColumnName("toGoodsTypeID");
            entity.Property(e => e.ToGoodsTypeName)
                .HasMaxLength(255)
                .HasColumnName("toGoodsTypeName");
            entity.Property(e => e.ToIsCentre).HasColumnName("toIsCentre");
            entity.Property(e => e.ToIsFactories).HasColumnName("toIsFactories");
            entity.Property(e => e.ToIsProvince).HasColumnName("toIsProvince");
            entity.Property(e => e.ToIsTbl).HasColumnName("toIsTBL");
            entity.Property(e => e.ToStorehouseCode)
                .HasMaxLength(255)
                .HasColumnName("toStorehouseCode");
            entity.Property(e => e.ToStorehouseListId).HasColumnName("toStorehouseListID");
            entity.Property(e => e.ToStorehouseName)
                .HasMaxLength(255)
                .HasColumnName("toStorehouseName");
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.WorkFlowStatusName).HasMaxLength(255);
        });

        modelBuilder.Entity<TbTadvanceDocumentCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TbTAdvanceDocumentCode");

            entity.Property(e => e.CompCode).HasMaxLength(50);
            entity.Property(e => e.DocCode).HasMaxLength(255);
            entity.Property(e => e.UserCode).HasMaxLength(50);
        });

        modelBuilder.Entity<TbTadvancePaymentDocument>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TbTAdvancePaymentDocuments");

            entity.Property(e => e.AdvPayAction).HasMaxLength(255);
            entity.Property(e => e.AdvPayApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.AdvPayApprover).HasMaxLength(255);
            entity.Property(e => e.AdvancePayReceiptDocId).HasColumnName("AdvancePayReceiptDocID");
            entity.Property(e => e.Approvers).HasMaxLength(500);
            entity.Property(e => e.AttFiles).HasMaxLength(255);
            entity.Property(e => e.BusinessUnitId).HasColumnName("BusinessUnitID");
            entity.Property(e => e.BusinessUnitName).HasMaxLength(500);
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DelivName).HasMaxLength(500);
            entity.Property(e => e.DocCode).HasMaxLength(22);
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.DocId).HasColumnName("DocID");
            entity.Property(e => e.DocStatusId).HasColumnName("DocStatusID");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.FromGoodsTypeId).HasColumnName("fromGoodsTypeID");
            entity.Property(e => e.FromGoodsTypeName)
                .HasMaxLength(255)
                .HasColumnName("fromGoodsTypeName");
            entity.Property(e => e.FromIsCentre).HasColumnName("fromIsCentre");
            entity.Property(e => e.FromIsFactories).HasColumnName("fromIsFactories");
            entity.Property(e => e.FromIsProvince).HasColumnName("fromIsProvince");
            entity.Property(e => e.FromIsTbl).HasColumnName("fromIsTBL");
            entity.Property(e => e.FromStorehouseCode)
                .HasMaxLength(255)
                .HasColumnName("fromStorehouseCode");
            entity.Property(e => e.FromStorehouseListId).HasColumnName("fromStorehouseListID");
            entity.Property(e => e.FromStorehouseName)
                .HasMaxLength(255)
                .HasColumnName("fromStorehouseName");
            entity.Property(e => e.FromStorehouseTypeId).HasColumnName("fromStorehouseTypeID");
            entity.Property(e => e.FromStorehouseTypeName)
                .HasMaxLength(255)
                .HasColumnName("fromStorehouseTypeName");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.GroupName).HasMaxLength(500);
            entity.Property(e => e.IsDocStatus).HasMaxLength(20);
            entity.Property(e => e.RefDocId).HasColumnName("RefDocID");
            entity.Property(e => e.RefIsDocStatus).HasColumnName("refIsDocStatus");
            entity.Property(e => e.RequestFrom).HasColumnType("datetime");
            entity.Property(e => e.RequestStatus).HasMaxLength(255);
            entity.Property(e => e.RequestTo).HasColumnType("datetime");
            entity.Property(e => e.SignatureApprove).HasMaxLength(255);
            entity.Property(e => e.ToGoodsTypeId).HasColumnName("toGoodsTypeID");
            entity.Property(e => e.ToGoodsTypeName)
                .HasMaxLength(255)
                .HasColumnName("toGoodsTypeName");
            entity.Property(e => e.ToIsCentre).HasColumnName("toIsCentre");
            entity.Property(e => e.ToIsFactories).HasColumnName("toIsFactories");
            entity.Property(e => e.ToIsProvince).HasColumnName("toIsProvince");
            entity.Property(e => e.ToIsTbl).HasColumnName("toIsTBL");
            entity.Property(e => e.ToStorehouseCode)
                .HasMaxLength(255)
                .HasColumnName("toStorehouseCode");
            entity.Property(e => e.ToStorehouseListId).HasColumnName("toStorehouseListID");
            entity.Property(e => e.ToStorehouseName)
                .HasMaxLength(255)
                .HasColumnName("toStorehouseName");
            entity.Property(e => e.TypeName).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.WorkFlowStatusName).HasMaxLength(255);
        });

        modelBuilder.Entity<TbTadvanceProductBalance>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TbTAdvanceProductBalance");

            entity.Property(e => e.ActionDate).HasColumnType("datetime");
            entity.Property(e => e.AdvPayApprovedDate).HasColumnType("datetime");
            entity.Property(e => e.Approvers).HasMaxLength(255);
            entity.Property(e => e.BalanceAmountQty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CarLicense).HasMaxLength(50);
            entity.Property(e => e.CompAddress).HasMaxLength(500);
            entity.Property(e => e.CompCode).HasMaxLength(50);
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.CompName).HasMaxLength(255);
            entity.Property(e => e.Conversion).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerName).HasMaxLength(255);
            entity.Property(e => e.DelivName).HasMaxLength(255);
            entity.Property(e => e.DocAttFile).HasMaxLength(1000);
            entity.Property(e => e.DocCode).HasMaxLength(255);
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.DocId).HasColumnName("DocID");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.ExpoQty).HasMaxLength(50);
            entity.Property(e => e.ExpoUnit).HasMaxLength(50);
            entity.Property(e => e.FromStoredCode).HasMaxLength(50);
            entity.Property(e => e.FromStoredName).HasMaxLength(255);
            entity.Property(e => e.FromStorehouseListId).HasColumnName("FromStorehouseListID");
            entity.Property(e => e.IsDocStatus).HasMaxLength(50);
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.Reason).HasMaxLength(500);
            entity.Property(e => e.ReceQty).HasMaxLength(50);
            entity.Property(e => e.ReceUnit).HasMaxLength(50);
            entity.Property(e => e.ReceiveFrom).HasMaxLength(255);
            entity.Property(e => e.Remark).HasMaxLength(1000);
            entity.Property(e => e.RemarkTrans).HasMaxLength(1000);
            entity.Property(e => e.RequestFrom).HasMaxLength(255);
            entity.Property(e => e.RequestReason).HasMaxLength(500);
            entity.Property(e => e.RequestStatus).HasMaxLength(50);
            entity.Property(e => e.RequestTo).HasMaxLength(255);
            entity.Property(e => e.RequestTypeName).HasMaxLength(255);
            entity.Property(e => e.SignatureApprove).HasMaxLength(255);
            entity.Property(e => e.StockUnitName).HasMaxLength(50);
            entity.Property(e => e.SumAdvancePayAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SumAdvancePayAmountUnit).HasMaxLength(50);
            entity.Property(e => e.Telephone).HasMaxLength(50);
            entity.Property(e => e.ToStoredCode).HasMaxLength(50);
            entity.Property(e => e.ToStoredName).HasMaxLength(255);
            entity.Property(e => e.ToStorehouseListId).HasColumnName("ToStorehouseListID");
            entity.Property(e => e.TranferType).HasMaxLength(50);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserIdapprove).HasColumnName("UserIDApprove");
            entity.Property(e => e.UserNameApprove).HasMaxLength(255);
            entity.Property(e => e.WarehouseAddress).HasMaxLength(500);
            entity.Property(e => e.WarehouseCode).HasMaxLength(50);
            entity.Property(e => e.WarehouseName).HasMaxLength(255);
            entity.Property(e => e.WorkFlowStatusName).HasMaxLength(255);
        });

        modelBuilder.Entity<TbTdocumentNumber>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TbTDocumentNumber");

            entity.Property(e => e.CompId).HasColumnName("compId");
            entity.Property(e => e.DocCode)
                .HasMaxLength(22)
                .HasColumnName("docCode");
            entity.Property(e => e.DocMonth).HasColumnName("docMonth");
            entity.Property(e => e.DocNumberId)
                .ValueGeneratedOnAdd()
                .HasColumnName("docNumberId");
            entity.Property(e => e.DocType).HasColumnName("docType");
            entity.Property(e => e.DocTypeCode)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("docTypeCode");
            entity.Property(e => e.MaxDocNumber).HasColumnName("maxDocNumber");
            entity.Property(e => e.WarehouseId).HasColumnName("warehouseId");
        });

        modelBuilder.Entity<TbTdocumntFirstDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TbTDocumntFirstDate");

            entity.Property(e => e.CompCode).HasMaxLength(8);
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.Idx).ValueGeneratedOnAdd();
            entity.Property(e => e.MaxDate).HasColumnType("datetime");
            entity.Property(e => e.MinDate).HasColumnType("datetime");
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
        });

        modelBuilder.Entity<TbTypeOfApprovedWorkflow>(entity =>
        {
            entity.HasKey(e => e.ApproveTypeId).HasName("PK__TbTypeOf__22498120481B0BFF");

            entity.ToTable("TbTypeOfApprovedWorkflow");

            entity.Property(e => e.ApproveTypeName).HasMaxLength(50);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbTypeOfApprovedWorkflowList>(entity =>
        {
            entity.HasKey(e => e.ApproveListId).HasName("PK__TbApprov__61B3CCA26E8E12B7");

            entity.ToTable("TbTypeOfApprovedWorkflowList");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.ApproveType).WithMany(p => p.TbTypeOfApprovedWorkflowLists)
                .HasForeignKey(d => d.ApproveTypeId)
                .HasConstraintName("FK__TbTypeOfA__Appro__32EB7E57");
        });

        modelBuilder.Entity<TbUser>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.HasIndex(e => new { e.UserId, e.IsActive }, "IDX_Users");

            entity.HasIndex(e => e.UserId, "IX_TbUsers_UserId");

            entity.HasIndex(e => e.UserId, "idx_TbUsers_UserID");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.PasswordHash).HasMaxLength(64);
            entity.Property(e => e.Phone).HasMaxLength(255);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.Signature).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserCode).HasMaxLength(8);

            entity.HasOne(d => d.Comp).WithMany(p => p.TbUsers)
                .HasForeignKey(d => d.CompId)
                .HasConstraintName("FK__TbUsers__CompID__467D75B8");
        });

        modelBuilder.Entity<TbUserAuthen>(entity =>
        {
            entity.HasKey(e => e.AuthenId);

            entity.Property(e => e.AuthenKey).HasMaxLength(4000);
            entity.Property(e => e.BrandHoldingId).HasColumnName("BrandHoldingID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.ExpiredDate).HasColumnType("datetime");
            entity.Property(e => e.PassPhrase).HasMaxLength(25);
            entity.Property(e => e.RedirectUrl).HasMaxLength(4000);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.UserCode).HasMaxLength(8);

            entity.HasOne(d => d.BrandHolding).WithMany(p => p.TbUserAuthens)
                .HasForeignKey(d => d.BrandHoldingId)
                .HasConstraintName("FK__TbUserAut__Brand__1D9B5BB6");
        });

        modelBuilder.Entity<TbUserGroup>(entity =>
        {
            entity.HasKey(e => e.GroupId);

            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.GroupCode).HasMaxLength(8);
            entity.Property(e => e.GroupName).HasMaxLength(255);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbUserRole>(entity =>
        {
            entity.HasKey(e => e.RoleId);

            entity.Property(e => e.RoleId).HasColumnName("RoleID");
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.RoleAbbrev).HasMaxLength(8);
            entity.Property(e => e.RoleName).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbWarehouse>(entity =>
        {
            entity.HasKey(e => e.WarehouseId);

            entity.ToTable("TbWarehouse");

            entity.HasIndex(e => new { e.WarehouseId, e.CompId }, "IDX_Warehouse");

            entity.HasIndex(e => new { e.WarehouseId, e.WarehouseCode }, "idx_TbWarehouse_WarehouseID_WarehouseCode");

            entity.HasIndex(e => e.WarehouseId, "idx_WarehouseID");

            entity.HasIndex(e => e.WarehouseCode, "idx_warehouse_code");

            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
            entity.Property(e => e.BranchCode).HasMaxLength(255);
            entity.Property(e => e.BranchId).HasColumnName("BranchID");
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.IsAddressUsed).HasDefaultValue(false);
            entity.Property(e => e.IsFactories).HasDefaultValue(false);
            entity.Property(e => e.LocId).HasColumnName("LocID");
            entity.Property(e => e.PlantCode).HasMaxLength(8);
            entity.Property(e => e.Remark).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.WarehouseAddress).HasMaxLength(500);
            entity.Property(e => e.WarehouseCode).HasMaxLength(8);
            entity.Property(e => e.WarehouseName).HasMaxLength(255);

            entity.HasOne(d => d.Comp).WithMany(p => p.TbWarehouses)
                .HasForeignKey(d => d.CompId)
                .HasConstraintName("FK__TbWarehou__CompI__24B26D99");

            entity.HasOne(d => d.Loc).WithMany(p => p.TbWarehouses)
                .HasForeignKey(d => d.LocId)
                .HasConstraintName("FK__TbWarehou__LocID__25A691D2");
        });

        modelBuilder.Entity<TbWorkFlow>(entity =>
        {
            entity.HasKey(e => e.WorkFlowId).HasName("PK__TbWorkFl__F98B18EE3AB324ED");

            entity.ToTable("TbWorkFlow");

            entity.HasIndex(e => e.WorkFlowId, "IX_TbWorkFlow_WorkFlowId");

            entity.HasIndex(e => e.WorkFlowId, "idx_tbworkflow_workflowid");

            entity.HasIndex(e => new { e.StorehouseListId, e.WorkFlowTypeId, e.UserId }, "index_WorkFlow");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.StorehouseList).WithMany(p => p.TbWorkFlows)
                .HasForeignKey(d => d.StorehouseListId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TbWorkFlo__Store__57A801BA");

            entity.HasOne(d => d.User).WithMany(p => p.TbWorkFlows)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TbWorkFlo__UserI__59904A2C");

            entity.HasOne(d => d.WorkFlowType).WithMany(p => p.TbWorkFlows)
                .HasForeignKey(d => d.WorkFlowTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TbWorkFlo__WorkF__589C25F3");
        });

        modelBuilder.Entity<TbWorkFlowBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TbWorkFlowBackup");

            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbWorkFlowStatus>(entity =>
        {
            entity.HasKey(e => e.WorkFlowStatusId).HasName("PK__TbWorkFl__7D2098F2B108F5CD");

            entity.ToTable("TbWorkFlowStatus");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.WorkFlowStatusName).HasMaxLength(50);
            entity.Property(e => e.WorkFlowStatusNameTh).HasMaxLength(50);
        });

        modelBuilder.Entity<TbWorkFlowTransaction>(entity =>
        {
            entity.HasKey(e => e.WorkFlowTransactionsId).HasName("PK__TbWorkFl__E74E2AB39D5BF702");

            entity.HasIndex(e => new { e.DocId, e.WorkFlowStatusId, e.WorkFlowTransactionsId }, "IX_TbWorkFlowTransactions_DocId_StatusId");

            entity.HasIndex(e => e.DocId, "idx_DocID");

            entity.HasIndex(e => new { e.DocId, e.WorkFlowStatusId }, "idx_DocIDWorkFlowStatusId");

            entity.HasIndex(e => e.WorkFlowStatusId, "idx_TbWorkFlowTransactionsByWorkFlowStatusId");

            entity.HasIndex(e => e.DocId, "idx_TbWorkFlowTransactions_DocID");

            entity.HasIndex(e => e.WorkFlowId, "idx_WorkFlowId");

            entity.HasIndex(e => e.WorkFlowStatusId, "idx_WorkFlowStatusId");

            entity.HasIndex(e => e.WorkFlowStatusId, "idx_WorkFlowTransactionsByWorkFlowStatusId");

            entity.HasIndex(e => new { e.DocId, e.WorkFlowStatusId }, "idx_WorkFlowTransactions_DocID_StatusId");

            entity.HasIndex(e => e.WorkFlowId, "idx_WorkFlowTransactions_WorkFlowId");

            entity.HasIndex(e => e.WorkFlowStatusId, "idx_tbworkflowtransactions_workflowstatusid");

            entity.HasIndex(e => e.DocId, "index_DocumentWorkflowTrans");

            entity.HasIndex(e => e.UpdatedBy, "index_TbWorkFlowTransactionsByUpdate");

            entity.HasIndex(e => e.WorkFlowStatusId, "index_WorkFlowTrans");

            entity.HasIndex(e => new { e.WorkFlowStatusId, e.WorkFlowTransactionsId, e.WorkFlowId, e.DocId, e.UpdatedBy, e.UpdatedDate }, "index_WorkFlowTransactions");

            entity.HasIndex(e => new { e.WorkFlowId, e.WorkFlowStatusId }, "index_WorkFlowTransactionsByWorkFlowIdWorkFlowStatusId");

            entity.HasIndex(e => e.WorkFlowStatusId, "index_WorkFlowTransactionsByWorkFlowStatusId");

            entity.HasIndex(e => new { e.WorkFlowStatusId, e.IsActive }, "index_WorkFlowTransactionsStatusId");

            entity.Property(e => e.ApproveListId).HasDefaultValue(1);
            entity.Property(e => e.CancelRemark).HasMaxLength(300);
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocId).HasColumnName("DocID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

            entity.HasOne(d => d.Doc).WithMany(p => p.TbWorkFlowTransactions)
                .HasForeignKey(d => d.DocId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TbWorkFlo__DocId__4B7734FF");

            entity.HasOne(d => d.WorkFlow).WithMany(p => p.TbWorkFlowTransactions)
                .HasForeignKey(d => d.WorkFlowId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__TbWorkFlo__WorkF__192BAC54");

            entity.HasOne(d => d.WorkFlowStatus).WithMany(p => p.TbWorkFlowTransactions)
                .HasForeignKey(d => d.WorkFlowStatusId)
                .HasConstraintName("FK__TbWorkFlo__WorkF__4C6B5938");
        });

        modelBuilder.Entity<TbWorkFlowTransactionsBackup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TbWorkFlowTransactionsBackup");

            entity.Property(e => e.CancelRemark).HasMaxLength(300);
            entity.Property(e => e.CreatedDate).HasColumnType("datetime");
            entity.Property(e => e.DocId).HasColumnName("DocID");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbWorkFlowType>(entity =>
        {
            entity.HasKey(e => e.WorkFlowTypeId).HasName("PK__TbWorkFl__CC92D26E278D56D2");

            entity.ToTable("TbWorkFlowType");

            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            entity.Property(e => e.WorkFlowTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<UvwGetSalespersonRequestDocument>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("UVW_GetSalespersonRequestDocuments");

            entity.Property(e => e.DocCode).HasMaxLength(22);
            entity.Property(e => e.DocId)
                .ValueGeneratedOnAdd()
                .HasColumnName("DocID");
            entity.Property(e => e.SaleCode)
                .HasMaxLength(4000)
                .HasColumnName("saleCode");
            entity.Property(e => e.SaleName).HasMaxLength(255);
        });

        modelBuilder.Entity<UvwProducstInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("UVW_ProducstInfo");

            entity.Property(e => e.BaseUnitName).HasMaxLength(255);
            entity.Property(e => e.BrandCode).HasMaxLength(8);
            entity.Property(e => e.BrandId).HasColumnName("BrandID");
            entity.Property(e => e.BrandName).HasMaxLength(255);
            entity.Property(e => e.CategoryCode).HasMaxLength(8);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName).HasMaxLength(255);
            entity.Property(e => e.ConversionId).HasColumnName("ConversionID");
            entity.Property(e => e.ProductCode).HasMaxLength(16);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductImage)
                .HasMaxLength(110)
                .HasColumnName("productImage");
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.SaleUnitName).HasMaxLength(255);
            entity.Property(e => e.SubCategoryCode).HasMaxLength(8);
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
            entity.Property(e => e.SubCategoryName).HasMaxLength(255);
        });

        modelBuilder.Entity<UvwProductBroughtForward>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("UVW_ProductBroughtForward");

            entity.Property(e => e.BaseUnitName).HasMaxLength(255);
            entity.Property(e => e.BrandCode).HasMaxLength(8);
            entity.Property(e => e.BrandHoldingId).HasColumnName("BrandHoldingID");
            entity.Property(e => e.BrandHoldingName).HasMaxLength(500);
            entity.Property(e => e.BrandId).HasColumnName("BrandID");
            entity.Property(e => e.BrandName).HasMaxLength(255);
            entity.Property(e => e.BrokenVal).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.BusinessUnitName).HasMaxLength(255);
            entity.Property(e => e.CategoryCode).HasMaxLength(8);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName).HasMaxLength(255);
            entity.Property(e => e.CompCode).HasMaxLength(8);
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.CompName).HasMaxLength(255);
            entity.Property(e => e.ConversionId).HasColumnName("ConversionID");
            entity.Property(e => e.ExpoVal).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.ProductCode).HasMaxLength(16);
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ReceVal).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.SaleUnitName).HasMaxLength(255);
            entity.Property(e => e.StorehouseId).HasColumnName("StorehouseID");
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.StorehouseTypeName).HasMaxLength(255);
            entity.Property(e => e.SubCategoryCode).HasMaxLength(8);
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
            entity.Property(e => e.SubCategoryName).HasMaxLength(255);
            entity.Property(e => e.UnitId).HasColumnName("UnitID");
            entity.Property(e => e.WarehouseCode).HasMaxLength(8);
            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
            entity.Property(e => e.WarehouseName).HasMaxLength(255);
        });

        modelBuilder.Entity<UvwProductRegionalBroughtForward>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("UVW_ProductRegionalBroughtForward");

            entity.Property(e => e.AdvanceUnit).HasMaxLength(20);
            entity.Property(e => e.BalanceUnit).HasMaxLength(20);
            entity.Property(e => e.BaseUnitName).HasMaxLength(255);
            entity.Property(e => e.BrandCode).HasMaxLength(8);
            entity.Property(e => e.BrandHoldingId).HasColumnName("BrandHoldingID");
            entity.Property(e => e.BrandHoldingName).HasMaxLength(500);
            entity.Property(e => e.BrandId).HasColumnName("BrandID");
            entity.Property(e => e.BrandName).HasMaxLength(255);
            entity.Property(e => e.BreakUnit).HasMaxLength(20);
            entity.Property(e => e.BroughtForwardUnit).HasMaxLength(20);
            entity.Property(e => e.BusinessUnitName).HasMaxLength(255);
            entity.Property(e => e.CategoryCode).HasMaxLength(8);
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName).HasMaxLength(255);
            entity.Property(e => e.CheckingUnit).HasMaxLength(20);
            entity.Property(e => e.CompCode).HasMaxLength(8);
            entity.Property(e => e.CompId).HasColumnName("CompID");
            entity.Property(e => e.CompName).HasMaxLength(255);
            entity.Property(e => e.ConversionId).HasColumnName("ConversionID");
            entity.Property(e => e.ExpoUnit).HasMaxLength(20);
            entity.Property(e => e.LastUpdate).HasColumnType("datetime");
            entity.Property(e => e.ProductCode).HasMaxLength(20);
            entity.Property(e => e.ProductImage)
                .HasMaxLength(114)
                .HasColumnName("productImage");
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.ReceUnit).HasMaxLength(20);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.SaleUnitName).HasMaxLength(255);
            entity.Property(e => e.StorehouseCode).HasMaxLength(8);
            entity.Property(e => e.StorehouseId).HasColumnName("StorehouseID");
            entity.Property(e => e.StorehouseListId).HasColumnName("StorehouseListID");
            entity.Property(e => e.StorehouseName).HasMaxLength(255);
            entity.Property(e => e.StorehouseTypeName).HasMaxLength(255);
            entity.Property(e => e.SubCategoryCode).HasMaxLength(8);
            entity.Property(e => e.SubCategoryId).HasColumnName("SubCategoryID");
            entity.Property(e => e.SubCategoryName).HasMaxLength(255);
            entity.Property(e => e.UnitId).HasColumnName("UnitID");
            entity.Property(e => e.WarehouseCode).HasMaxLength(8);
            entity.Property(e => e.WarehouseId).HasColumnName("WarehouseID");
            entity.Property(e => e.WarehouseName).HasMaxLength(255);
        });

        modelBuilder.Entity<VProducstInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vProducstInfo");

            entity.Property(e => e.BaseUnitName).HasMaxLength(255);
            entity.Property(e => e.ConversionId).HasColumnName("ConversionID");
            entity.Property(e => e.ProductCode).HasMaxLength(16);
            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductName).HasMaxLength(255);
            entity.Property(e => e.SaleUnitName).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
