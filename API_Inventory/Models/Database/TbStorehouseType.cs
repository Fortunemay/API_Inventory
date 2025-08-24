using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbStorehouseType
{
    public int StorehouseTypeId { get; set; }

    public string? StorehouseTypeName { get; set; }

    public string? Description { get; set; }

    public string? Remark { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<TbStorehouseList> TbStorehouseLists { get; set; } = new List<TbStorehouseList>();
}
