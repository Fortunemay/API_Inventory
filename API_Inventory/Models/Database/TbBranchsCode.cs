using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbBranchsCode
{
    public int BranchCodeId { get; set; }

    public string? BranchCode { get; set; }

    public int? WarehouseId { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsSalesArea { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
