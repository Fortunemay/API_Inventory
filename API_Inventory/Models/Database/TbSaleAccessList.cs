using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbSaleAccessList
{
    public int SaleAccessListId { get; set; }

    public int? StorehouseListId { get; set; }

    public int? SaleId { get; set; }

    public int? ComId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TbCompanyProfile? Com { get; set; }

    public virtual TbSale? Sale { get; set; }

    public virtual TbStorehouseList? StorehouseList { get; set; }

    public virtual ICollection<TbDocument> TbDocuments { get; set; } = new List<TbDocument>();
}
