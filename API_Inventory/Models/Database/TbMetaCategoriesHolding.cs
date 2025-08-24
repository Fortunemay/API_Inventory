using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbMetaCategoriesHolding
{
    public int MetaCategoriesHoldingId { get; set; }

    public int? CategoryId { get; set; }

    public int? CompId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TbCategory? Category { get; set; }

    public virtual TbCompanyProfile? Comp { get; set; }
}
