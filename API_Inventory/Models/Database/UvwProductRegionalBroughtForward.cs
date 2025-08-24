using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class UvwProductRegionalBroughtForward
{
    public int? RegionId { get; set; }

    public int? CompId { get; set; }

    public string? CompCode { get; set; }

    public string? CompName { get; set; }

    public int? WarehouseId { get; set; }

    public string? WarehouseCode { get; set; }

    public string? WarehouseName { get; set; }

    public string? BusinessUnitName { get; set; }

    public string? StorehouseTypeName { get; set; }

    public string? StorehouseCode { get; set; }

    public string? StorehouseName { get; set; }

    public int? StorehouseListId { get; set; }

    public int? StorehouseId { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public int? BrandId { get; set; }

    public string? BrandCode { get; set; }

    public string? BrandName { get; set; }

    public int? CategoryId { get; set; }

    public string? CategoryCode { get; set; }

    public string? CategoryName { get; set; }

    public int? SubCategoryId { get; set; }

    public string? SubCategoryCode { get; set; }

    public string? SubCategoryName { get; set; }

    public string? BroughtForwardUnit { get; set; }

    public int? BroughtForwardQty { get; set; }

    public string? ReceUnit { get; set; }

    public int? ReceQty { get; set; }

    public string? ExpoUnit { get; set; }

    public int? ExpoQty { get; set; }

    public string? BreakUnit { get; set; }

    public int? BreakQty { get; set; }

    public string? CheckingUnit { get; set; }

    public int? CheckingQty { get; set; }

    public string? BalanceUnit { get; set; }

    public int? BalanceQty { get; set; }

    public string? AdvanceUnit { get; set; }

    public int? AdvanceQty { get; set; }

    public int? BrandHoldingId { get; set; }

    public string? BrandHoldingName { get; set; }

    public int? ConversionId { get; set; }

    public int? Conversion { get; set; }

    public int? SalesUnit { get; set; }

    public string? SaleUnitName { get; set; }

    public int? BaseUnit { get; set; }

    public string? BaseUnitName { get; set; }

    public int? UnitId { get; set; }

    public string ProductImage { get; set; } = null!;

    public bool? IsPremium { get; set; }

    public DateTime? LastUpdate { get; set; }
}
