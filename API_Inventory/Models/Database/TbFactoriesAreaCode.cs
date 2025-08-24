using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbFactoriesAreaCode
{
    public int ArId { get; set; }

    public string? ArCode { get; set; }

    public int? FactId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TbFactory? Fact { get; set; }
}
