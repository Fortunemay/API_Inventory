using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbLocation
{
    public int LocId { get; set; }

    public string? LocCode { get; set; }

    public string? LocName { get; set; }

    public string? Description { get; set; }

    public string? Remark { get; set; }

    public int? RegionId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TbRegion? Region { get; set; }

    public virtual ICollection<TbCar> TbCars { get; set; } = new List<TbCar>();

    public virtual ICollection<TbDriver> TbDrivers { get; set; } = new List<TbDriver>();

    public virtual ICollection<TbWarehouse> TbWarehouses { get; set; } = new List<TbWarehouse>();
}
