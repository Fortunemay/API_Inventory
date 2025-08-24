using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbTypeOfApprovedWorkflowList
{
    public int ApproveListId { get; set; }

    public int? ApproveTypeId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TbTypeOfApprovedWorkflow? ApproveType { get; set; }
}
