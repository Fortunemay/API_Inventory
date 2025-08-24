using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbDriver
{
    public int DriverId { get; set; }

    public string? EmpCode { get; set; }

    public string? FullName { get; set; }

    public string? Position { get; set; }

    public string? Remark { get; set; }

    public int? CarId { get; set; }

    public int? LocId { get; set; }

    public int? RegionId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TbCar? Car { get; set; }

    public virtual TbLocation? Loc { get; set; }

    public virtual TbRegion? Region { get; set; }
}
