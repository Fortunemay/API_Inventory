using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbTotherSale
{
    public int Id { get; set; }

    public string TaxNo { get; set; } = null!;

    public string? Arname { get; set; }

    public string StorageCode { get; set; } = null!;

    public string? StorageName { get; set; }

    public decimal? AmountBeforeDiscount { get; set; }

    public int Qty { get; set; }

    public DateTime DocDate { get; set; }

    public string DocNo { get; set; } = null!;

    public string ItemCode { get; set; } = null!;

    public string? CompanyCode { get; set; }

    public string? CompanyName { get; set; }

    public string? BranchCode { get; set; }

    public string? Remark { get; set; }

    public string? Whcode { get; set; }

    public string? Whname { get; set; }
}
