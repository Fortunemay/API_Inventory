using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbProductBroughtForwardCurrent
{
    public int RowsId { get; set; }

    public string? WarehouseCode { get; set; }

    public int? StorehouseListId { get; set; }

    public string? ProductCode { get; set; }

    public int? CategoryId { get; set; }

    public int? BroughtForwardQty { get; set; }

    public int? ReceQty { get; set; }

    public int? ExpoQty { get; set; }

    public int? Broken { get; set; }

    public decimal? Price { get; set; }

    public bool? IsPremium { get; set; }

    public DateTime? LastUpdate { get; set; }
}
