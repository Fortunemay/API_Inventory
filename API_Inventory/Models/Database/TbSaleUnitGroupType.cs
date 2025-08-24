using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbSaleUnitGroupType
{
    public int SaleTypeId { get; set; }

    public string? SaleTypeName { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<TbSaleUnitMaster> TbSaleUnitMasters { get; set; } = new List<TbSaleUnitMaster>();
}
