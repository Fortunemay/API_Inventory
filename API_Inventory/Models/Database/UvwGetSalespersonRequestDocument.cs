using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class UvwGetSalespersonRequestDocument
{
    public long DocId { get; set; }

    public string? DocCode { get; set; }

    public int? DocType { get; set; }

    public string? SaleName { get; set; }

    public string? SaleCode { get; set; }
}
