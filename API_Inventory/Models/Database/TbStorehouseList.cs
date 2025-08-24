using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbStorehouseList
{
    public int StorehouseListId { get; set; }

    public int? StorehouseId { get; set; }

    public int? WarehouseId { get; set; }

    public int? StorehouseTypeId { get; set; }

    public int? BusinessUnitId { get; set; }

    public int? SaleUnitId { get; set; }

    public string? StorehouseListIcon { get; set; }

    public int? StorehouseListSeq { get; set; }

    public int? AccountingTypeId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsAutoSync { get; set; }

    public virtual TbBusinessUnit? BusinessUnit { get; set; }

    public virtual TbSaleUnitMaster? SaleUnit { get; set; }

    public virtual TbStorehouse? Storehouse { get; set; }

    public virtual TbStorehouseType? StorehouseType { get; set; }

    public virtual ICollection<TbEndOfDayChecking> TbEndOfDayCheckings { get; set; } = new List<TbEndOfDayChecking>();

    public virtual ICollection<TbMetaUser> TbMetaUsers { get; set; } = new List<TbMetaUser>();

    public virtual ICollection<TbProductManufacturedDate> TbProductManufacturedDates { get; set; } = new List<TbProductManufacturedDate>();

    public virtual ICollection<TbProductTransaction> TbProductTransactions { get; set; } = new List<TbProductTransaction>();

    public virtual ICollection<TbReportTransaction> TbReportTransactions { get; set; } = new List<TbReportTransaction>();

    public virtual ICollection<TbSaleAccessList> TbSaleAccessLists { get; set; } = new List<TbSaleAccessList>();

    public virtual ICollection<TbWorkFlow> TbWorkFlows { get; set; } = new List<TbWorkFlow>();

    public virtual TbWarehouse? Warehouse { get; set; }
}
