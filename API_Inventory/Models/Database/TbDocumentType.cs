using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbDocumentType
{
    public int TypeId { get; set; }

    public string? TypeCode { get; set; }

    public string? TypeName { get; set; }

    public string? Description { get; set; }

    public string? Remark { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsReceiver { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<TbDocument> TbDocuments { get; set; } = new List<TbDocument>();
}
