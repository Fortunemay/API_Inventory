using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbCompanyGroup
{
    public int GroupId { get; set; }

    public string? GroupName { get; set; }

    public string? Description { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<TbCompanyProfile> TbCompanyProfiles { get; set; } = new List<TbCompanyProfile>();
}
