using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class AdvancePayment
{
    public string? DocCode { get; set; }

    public int? CompId { get; set; }

    public int? FromStorehouseListId { get; set; }

    public string? UserCode { get; set; }

    public string? ProductCode { get; set; }

    public int? Conversion { get; set; }

    public double? Quantity { get; set; }

    public int? SaleQty { get; set; }

    public int? BaseQty { get; set; }

    public int? TotalQty { get; set; }
}
