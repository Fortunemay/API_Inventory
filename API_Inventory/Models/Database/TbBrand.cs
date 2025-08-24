using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbBrand
{
    public int BrandId { get; set; }

    public string? BrandCode { get; set; }

    public string? BrandName { get; set; }

    public string? Description { get; set; }

    public string? Remark { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<TbMetaBrandHolding> TbMetaBrandHoldings { get; set; } = new List<TbMetaBrandHolding>();

    public virtual ICollection<TbProduct> TbProducts { get; set; } = new List<TbProduct>();
}
