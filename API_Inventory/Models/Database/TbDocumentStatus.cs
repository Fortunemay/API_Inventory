using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbDocumentStatus
{
    public int DocStatusId { get; set; }

    public string? DocStatus { get; set; }

    public string? DocStatusTh { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
