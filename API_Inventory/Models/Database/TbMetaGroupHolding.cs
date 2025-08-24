using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbMetaGroupHolding
{
    public int MetaGroupHoldingId { get; set; }

    public int? GroupHoldingId { get; set; }

    public int? BrandHoldingId { get; set; }

    public int? CompId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TbBrandHolding? BrandHolding { get; set; }

    public virtual TbCompanyProfile? Comp { get; set; }

    public virtual TbGroupHolding? GroupHolding { get; set; }
}
