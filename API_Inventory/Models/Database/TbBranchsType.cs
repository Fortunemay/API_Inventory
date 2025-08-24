using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbBranchsType
{
    public int BranchTypeId { get; set; }

    public string? BranchTypeName { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
