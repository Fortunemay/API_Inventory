using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbProductWarehouseStock
{
    public long ProductStockId { get; set; }

    public int? RegionId { get; set; }

    public string? RegionCode { get; set; }

    public string? WarehouseCode { get; set; }

    public string? WarehouseName { get; set; }

    public int? StorehouseListId { get; set; }

    public string? StorehouseCode { get; set; }

    public string? StorehouseName { get; set; }

    public int? StorehouseTypeId { get; set; }

    public string? StorehouseTypeName { get; set; }

    public int? CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public int? SubCategoryId { get; set; }

    public string? SubCategoryName { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public int? UnitId { get; set; }

    public decimal? Conversion { get; set; }

    public string? StockUnitName { get; set; }

    public string? BroughtForwardUnit { get; set; }

    public decimal? BroughtForwardQty { get; set; }

    public decimal? BroughtForwardDiv { get; set; }

    public string? ReceUnit { get; set; }

    public decimal? ReceQty { get; set; }

    public decimal? ReceDiv { get; set; }

    public string? ExpoUnit { get; set; }

    public decimal? ExpoQty { get; set; }

    public decimal? ExpoDiv { get; set; }

    public string? BreakUnit { get; set; }

    public decimal? BreakQty { get; set; }

    public decimal? BreakDiv { get; set; }

    public string? CheckingUnit { get; set; }

    public decimal? CheckingQty { get; set; }

    public decimal? CheckingDiv { get; set; }

    public string? DiffUnit { get; set; }

    public decimal? DiffQty { get; set; }

    public decimal? DiffDiv { get; set; }

    public string? AdvanceUnit { get; set; }

    public decimal? AdvanceQty { get; set; }

    public decimal? AdvanceDiv { get; set; }

    public string? BalanceUnit { get; set; }

    public decimal? BalanceQty { get; set; }

    public decimal? BalanceDiv { get; set; }

    public string? AmountUnit { get; set; }

    public decimal? AmountQty { get; set; }

    public decimal? AmountDiv { get; set; }

    public decimal? UnitPrice { get; set; }

    public bool? IsPremium { get; set; }

    public DateTime? LastUpdate { get; set; }
}
