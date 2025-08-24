using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbWorkFlowTransactionsBackup
{
    public long? WorkFlowTransactionsId { get; set; }

    public int? WorkFlowId { get; set; }

    public long? DocId { get; set; }

    public int? WorkFlowStatusId { get; set; }

    public string? CancelRemark { get; set; }

    public bool? IsRepresent { get; set; }

    public bool? IsActive { get; set; }

    public int? ApproveListId { get; set; }

    public int? RequestTransactionCount { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
