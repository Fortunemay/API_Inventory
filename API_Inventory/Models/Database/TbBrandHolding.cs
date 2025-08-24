using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbBrandHolding
{
    public int BrandHoldingId { get; set; }

    public string? BrandHoldingName { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<TbMetaBrandHolding> TbMetaBrandHoldings { get; set; } = new List<TbMetaBrandHolding>();

    public virtual ICollection<TbMetaGroupHolding> TbMetaGroupHoldings { get; set; } = new List<TbMetaGroupHolding>();

    public virtual ICollection<TbReportTransaction> TbReportTransactions { get; set; } = new List<TbReportTransaction>();

    public virtual ICollection<TbUserAuthen> TbUserAuthens { get; set; } = new List<TbUserAuthen>();
}
