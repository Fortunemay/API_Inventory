using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbWarehouse
{
    public int WarehouseId { get; set; }

    public string? WarehouseCode { get; set; }

    public string? PlantCode { get; set; }

    public string? WarehouseName { get; set; }

    public string? WarehouseAddress { get; set; }

    public string? Description { get; set; }

    public string? Remark { get; set; }

    public int? LocId { get; set; }

    public int? CompId { get; set; }

    public bool? IsFactories { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsAddressUsed { get; set; }

    public int? BranchId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? BranchCode { get; set; }

    public virtual TbCompanyProfile? Comp { get; set; }

    public virtual TbLocation? Loc { get; set; }

    public virtual ICollection<TbDocument> TbDocuments { get; set; } = new List<TbDocument>();

    public virtual ICollection<TbMetaUser> TbMetaUsers { get; set; } = new List<TbMetaUser>();

    public virtual ICollection<TbStorehouseList> TbStorehouseLists { get; set; } = new List<TbStorehouseList>();
}
