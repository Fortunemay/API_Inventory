using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbEndOfDayChecking
{
    public int CheckingId { get; set; }

    public int? StorehouseListId { get; set; }

    public string? ProductCode { get; set; }

    public int? ProductQty { get; set; }

    public string? Description { get; set; }

    public string? Remark { get; set; }

    public int? RowsId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsArchived { get; set; }

    public virtual TbStorehouseList? StorehouseList { get; set; }
}
