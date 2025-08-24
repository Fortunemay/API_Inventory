using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbAccountingType
{
    public int AccountingTypeId { get; set; }

    public string? AccountingTypeName { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<TbStorehouse> TbStorehouses { get; set; } = new List<TbStorehouse>();
}
