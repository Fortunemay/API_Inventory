using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbProductType
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
}
