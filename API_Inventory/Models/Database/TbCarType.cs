using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbCarType
{
    public int CarTypeId { get; set; }

    public string? CarTypeName { get; set; }

    public string? Description { get; set; }

    public string? Remark { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatetedDate { get; set; }

    public virtual ICollection<TbCar> TbCars { get; set; } = new List<TbCar>();
}
