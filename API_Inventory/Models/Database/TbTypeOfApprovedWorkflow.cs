using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbTypeOfApprovedWorkflow
{
    public int ApproveTypeId { get; set; }

    public string ApproveTypeName { get; set; } = null!;

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<TbTypeOfApprovedWorkflowList> TbTypeOfApprovedWorkflowLists { get; set; } = new List<TbTypeOfApprovedWorkflowList>();
}
