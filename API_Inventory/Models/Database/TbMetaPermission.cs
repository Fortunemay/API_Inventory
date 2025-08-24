using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbMetaPermission
{
    public int MetaPermissionId { get; set; }

    public int? GroupId { get; set; }

    public int? PermissionId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TbUserGroup? Group { get; set; }

    public virtual TbPermission? Permission { get; set; }
}
