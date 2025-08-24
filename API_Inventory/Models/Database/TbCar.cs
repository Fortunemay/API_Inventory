using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbCar
{
    public int CarId { get; set; }

    public int? CarTypeId { get; set; }

    public string? NumberPlate { get; set; }

    public int? ProvinceId { get; set; }

    public int? RegionId { get; set; }

    public int? LocId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatetedDate { get; set; }

    public virtual TbCarType? CarType { get; set; }

    public virtual TbLocation? Loc { get; set; }

    public virtual TbProvince? Province { get; set; }

    public virtual TbRegion? Region { get; set; }

    public virtual ICollection<TbDriver> TbDrivers { get; set; } = new List<TbDriver>();
}
