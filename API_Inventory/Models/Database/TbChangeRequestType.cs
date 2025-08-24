using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbChangeRequestType
{
    public int RequestTypeId { get; set; }

    public string? RequestTypeName { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<TbDocumentChangeRequestDetail> TbDocumentChangeRequestDetails { get; set; } = new List<TbDocumentChangeRequestDetail>();

    public virtual ICollection<TbStockTrackingChangeRequestDetail> TbStockTrackingChangeRequestDetails { get; set; } = new List<TbStockTrackingChangeRequestDetail>();
}
