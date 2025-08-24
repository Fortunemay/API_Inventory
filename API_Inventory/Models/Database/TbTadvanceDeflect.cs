using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbTadvanceDeflect
{
    public int? DocId { get; set; }

    public string? RefCode { get; set; }

    public int? ProductCode { get; set; }

    public int? Pcount { get; set; }

    public int? AmountQty { get; set; }
}
