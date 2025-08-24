using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbProvince
{
    public int ProvinceId { get; set; }

    public string? ProvinceCode { get; set; }

    public string? ProvinceNameTh { get; set; }

    public string? ProvinceNameEn { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<TbCar> TbCars { get; set; } = new List<TbCar>();
}
