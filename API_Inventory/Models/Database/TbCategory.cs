using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbCategory
{
    public int CategoryId { get; set; }

    public string? CategoryCode { get; set; }

    public string? CategoryName { get; set; }

    public string? Description { get; set; }

    public string? Remark { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<TbMetaCategoriesHolding> TbMetaCategoriesHoldings { get; set; } = new List<TbMetaCategoriesHolding>();

    public virtual ICollection<TbProduct> TbProducts { get; set; } = new List<TbProduct>();
}
