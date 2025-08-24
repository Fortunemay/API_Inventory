using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbTadvanceDeflectAmount
{
    public int? TransId { get; set; }

    public int? DocId { get; set; }

    public string? DocCode { get; set; }

    public string? RefCode { get; set; }

    public int? ProductCode { get; set; }

    public int? StorehouseListId { get; set; }

    public int? AmountQty { get; set; }
}
