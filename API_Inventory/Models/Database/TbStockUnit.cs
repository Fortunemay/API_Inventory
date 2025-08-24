using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbStockUnit
{
    public int StockUnitId { get; set; }

    public string? StockUnitCode { get; set; }

    public string? StockUnitName { get; set; }

    public string? Description { get; set; }

    public string? Remark { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<TbProduct> TbProductBaseUnitNavigations { get; set; } = new List<TbProduct>();

    public virtual ICollection<TbProduct> TbProductSalesUnitNavigations { get; set; } = new List<TbProduct>();
}
