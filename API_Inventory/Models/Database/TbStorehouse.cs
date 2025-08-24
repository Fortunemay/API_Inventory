using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbStorehouse
{
    public int StorehouseId { get; set; }

    public string? StorehouseCode { get; set; }

    public string? StorehouseName { get; set; }

    public string? StorehouseNameOmSap { get; set; }

    public string? Description { get; set; }

    public string? Remark { get; set; }

    public int? GoodsTypeId { get; set; }

    public int? RegionId { get; set; }

    public bool? IsProvince { get; set; }

    public bool? IsCentre { get; set; }

    public bool? IsFactories { get; set; }

    public bool? IsFlagTbl { get; set; }

    public bool? IsActive { get; set; }

    public int? AccountingTypeId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TbAccountingType? AccountingType { get; set; }

    public virtual TbGoodsType? GoodsType { get; set; }

    public virtual TbRegion? Region { get; set; }

    public virtual ICollection<TbStorehouseList> TbStorehouseLists { get; set; } = new List<TbStorehouseList>();
}
