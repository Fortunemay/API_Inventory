using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbSale
{
    public int SaleId { get; set; }

    public string? SaleCode { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public int? SaleUnitId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TbSaleUnitMaster? SaleUnit { get; set; }

    public virtual ICollection<TbSaleAccessList> TbSaleAccessLists { get; set; } = new List<TbSaleAccessList>();
}
