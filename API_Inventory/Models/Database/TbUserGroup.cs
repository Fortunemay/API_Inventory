using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbUserGroup
{
    public int GroupId { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? Description { get; set; }

    public string? Remark { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<TbMetaPermission> TbMetaPermissions { get; set; } = new List<TbMetaPermission>();

    public virtual ICollection<TbMetaUser> TbMetaUsers { get; set; } = new List<TbMetaUser>();
}
