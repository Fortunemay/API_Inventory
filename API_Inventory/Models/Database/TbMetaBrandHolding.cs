using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbMetaBrandHolding
{
    public int MetaBrandHoldingId { get; set; }

    public int? BrandHoldingId { get; set; }

    public int? BrandId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TbBrand? Brand { get; set; }

    public virtual TbBrandHolding? BrandHolding { get; set; }
}
