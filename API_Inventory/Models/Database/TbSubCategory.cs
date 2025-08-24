using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbSubCategory
{
    public int SubCategoryId { get; set; }

    public string? SubCategoryCode { get; set; }

    public string? SubCategoryName { get; set; }

    public string? Description { get; set; }

    public string? Remark { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<TbProduct> TbProducts { get; set; } = new List<TbProduct>();
}
