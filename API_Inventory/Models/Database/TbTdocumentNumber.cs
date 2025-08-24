using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbTdocumentNumber
{
    public int DocNumberId { get; set; }

    public int? CompId { get; set; }

    public int? WarehouseId { get; set; }

    public int? DocMonth { get; set; }

    public string? DocCode { get; set; }

    public int? DocType { get; set; }

    public string? DocTypeCode { get; set; }

    public long? MaxDocNumber { get; set; }
}
