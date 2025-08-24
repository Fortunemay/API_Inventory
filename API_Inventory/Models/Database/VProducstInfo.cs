using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class VProducstInfo
{
    public int ProductId { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public int? ConversionId { get; set; }

    public int? Conversion { get; set; }

    public int? SalesUnit { get; set; }

    public string? SaleUnitName { get; set; }

    public int? BaseUnit { get; set; }

    public string? BaseUnitName { get; set; }
}
