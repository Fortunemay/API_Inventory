using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbSaleUnitMaster
{
    public int SaleUnitId { get; set; }

    public int? SaleUnitNo { get; set; }

    public int? RegionId { get; set; }

    public int? SaleTypeId { get; set; }

    public int? RegionGroupId { get; set; }

    public string? RegionGroupName { get; set; }

    public int? AreaGroupCode { get; set; }

    public string? AreaGroupName { get; set; }

    public int? SaleTeamId { get; set; }

    public string? SaleUnitDesc { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TbRegion? Region { get; set; }

    public virtual TbSaleUnitGroupType? SaleType { get; set; }

    public virtual ICollection<TbSale> TbSales { get; set; } = new List<TbSale>();

    public virtual ICollection<TbStorehouseList> TbStorehouseLists { get; set; } = new List<TbStorehouseList>();
}
