using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbSalesArea
{
    public int AreaId { get; set; }

    public string? SalesAreaCode { get; set; }

    public string? SalesAreaName { get; set; }

    public int? RegionId { get; set; }

    public string? Description { get; set; }

    public string? Remark { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TbRegion? Region { get; set; }
}
