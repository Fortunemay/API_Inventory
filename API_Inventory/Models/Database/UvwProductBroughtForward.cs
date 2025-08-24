using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class UvwProductBroughtForward
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

    public int? BroughtForwardVol { get; set; }

    public int? ReceVol { get; set; }

    public decimal? ReceVal { get; set; }

    public int? ExpoVol { get; set; }

    public decimal? ExpoVal { get; set; }

    public int? BrokenVol { get; set; }

    public decimal? BrokenVal { get; set; }

    public int? BalanceVol { get; set; }

    public int? BrandHoldingId { get; set; }

    public string? BrandHoldingName { get; set; }

    public int? ConversionId { get; set; }

    public int? Conversion { get; set; }

    public int? SalesUnit { get; set; }

    public string? SaleUnitName { get; set; }

    public int? BaseUnit { get; set; }

    public string? BaseUnitName { get; set; }

    public int? UnitId { get; set; }

    public DateTime? LastUpdate { get; set; }
}
