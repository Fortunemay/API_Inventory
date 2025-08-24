using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbReportTransaction
{
    public int ReportTransactionsId { get; set; }

    public string ReportTransactionName { get; set; } = null!;

    public DateTime ReportTransactionDate { get; set; }

    public int? StorehouseListId { get; set; }

    public int? WorkFlowId { get; set; }

    public int? WorkFlowStatusId { get; set; }

    public int? ReportTracsactionCount { get; set; }

    public string? CancelRemark { get; set; }

    public int? BrandHoldingId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TbBrandHolding? BrandHolding { get; set; }

    public virtual TbStorehouseList? StorehouseList { get; set; }

    public virtual TbWorkFlow? WorkFlow { get; set; }

    public virtual TbWorkFlowStatus? WorkFlowStatus { get; set; }
}
