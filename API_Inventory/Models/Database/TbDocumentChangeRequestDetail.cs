using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbDocumentChangeRequestDetail
{
    public long RequestId { get; set; }

    public long? DocId { get; set; }

    public string? RequestFrom { get; set; }

    public string? RequestTo { get; set; }

    public string? RequestReason { get; set; }

    public bool? IsActive { get; set; }

    public int? RequestTypeId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TbDocument? Doc { get; set; }

    public virtual TbChangeRequestType? RequestType { get; set; }
}
