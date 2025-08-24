using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbWorkFlow
{
    public int WorkFlowId { get; set; }

    public int StorehouseListId { get; set; }

    public int WorkFlowTypeId { get; set; }

    public int UserId { get; set; }

    public int SequenceNo { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsSubstitute { get; set; }

    public int? RefWorkFlowId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TbStorehouseList StorehouseList { get; set; } = null!;

    public virtual ICollection<TbReportTransaction> TbReportTransactions { get; set; } = new List<TbReportTransaction>();

    public virtual ICollection<TbWorkFlowTransaction> TbWorkFlowTransactions { get; set; } = new List<TbWorkFlowTransaction>();

    public virtual TbUser User { get; set; } = null!;

    public virtual TbWorkFlowType WorkFlowType { get; set; } = null!;
}
