using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbWorkFlowStatus
{
    public int WorkFlowStatusId { get; set; }

    public string WorkFlowStatusName { get; set; } = null!;

    public string? WorkFlowStatusNameTh { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<TbReportTransaction> TbReportTransactions { get; set; } = new List<TbReportTransaction>();

    public virtual ICollection<TbWorkFlowTransaction> TbWorkFlowTransactions { get; set; } = new List<TbWorkFlowTransaction>();
}
