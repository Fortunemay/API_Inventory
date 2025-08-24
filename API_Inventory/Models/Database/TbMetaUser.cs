using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbMetaUser
{
    public int MetaUserId { get; set; }

    public int? UserId { get; set; }

    public int? GroupId { get; set; }

    public int? RoleId { get; set; }

    public int? WarehouseId { get; set; }

    public int? StorehouseListId { get; set; }

    public int? GroupHoldingId { get; set; }

    public int? ReportOwnerStatus { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TbUserGroup? Group { get; set; }

    public virtual TbGroupHolding? GroupHolding { get; set; }

    public virtual TbUserRole? Role { get; set; }

    public virtual TbStorehouseList? StorehouseList { get; set; }

    public virtual TbUser? User { get; set; }

    public virtual TbWarehouse? Warehouse { get; set; }
}
