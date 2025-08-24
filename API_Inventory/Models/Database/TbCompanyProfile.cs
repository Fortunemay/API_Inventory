using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbCompanyProfile
{
    public int CompId { get; set; }

    public string? CompCode { get; set; }

    public string? AbbreviationCode { get; set; }

    public string? CompName { get; set; }

    public string? CompAddress { get; set; }

    public string? Description { get; set; }

    public string? Remark { get; set; }

    public int? RegionId { get; set; }

    public int? GroupId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TbCompanyGroup? Group { get; set; }

    public virtual TbRegion? Region { get; set; }

    public virtual ICollection<TbDocument> TbDocuments { get; set; } = new List<TbDocument>();

    public virtual ICollection<TbMetaCategoriesHolding> TbMetaCategoriesHoldings { get; set; } = new List<TbMetaCategoriesHolding>();

    public virtual ICollection<TbMetaGroupHolding> TbMetaGroupHoldings { get; set; } = new List<TbMetaGroupHolding>();

    public virtual ICollection<TbSaleAccessList> TbSaleAccessLists { get; set; } = new List<TbSaleAccessList>();

    public virtual ICollection<TbUser> TbUsers { get; set; } = new List<TbUser>();

    public virtual ICollection<TbWarehouse> TbWarehouses { get; set; } = new List<TbWarehouse>();
}
