using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbGroupHolding
{
    public int GroupHoldingId { get; set; }

    public string? GroupHoldingName { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsCentre { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<TbMetaGroupHolding> TbMetaGroupHoldings { get; set; } = new List<TbMetaGroupHolding>();

    public virtual ICollection<TbMetaUser> TbMetaUsers { get; set; } = new List<TbMetaUser>();
}
