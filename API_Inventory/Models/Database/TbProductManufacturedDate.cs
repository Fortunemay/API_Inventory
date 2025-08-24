using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbProductManufacturedDate
{
    public long ManuTransId { get; set; }

    public long DocId { get; set; }

    public int? StorehouseListId { get; set; }

    public string ProductCode { get; set; } = null!;

    public string? ManufactureDate { get; set; }

    public string? NewManufactureDate { get; set; }

    public string? Act { get; set; }

    public double? CostPrice { get; set; }

    public int? ExpoQty { get; set; }

    public int? ReceQty { get; set; }

    public int? BreakQty { get; set; }

    public int? LeakQty { get; set; }

    public int? LabelQty { get; set; }

    public int? WaterlessQty { get; set; }

    public int? DisappearQty { get; set; }

    public long? BeerType { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsUpdate { get; set; }

    public bool? IsConfirm { get; set; }

    public int? RowNo { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TbStorehouseList? StorehouseList { get; set; }
}
