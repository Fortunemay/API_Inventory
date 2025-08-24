using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbRegion
{
    public int RegionId { get; set; }

    public string? RegionCode { get; set; }

    public string? RegionName { get; set; }

    public string? Description { get; set; }

    public string? Remark { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<TbCar> TbCars { get; set; } = new List<TbCar>();

    public virtual ICollection<TbCompanyProfile> TbCompanyProfiles { get; set; } = new List<TbCompanyProfile>();

    public virtual ICollection<TbCustomer> TbCustomers { get; set; } = new List<TbCustomer>();

    public virtual ICollection<TbDriver> TbDrivers { get; set; } = new List<TbDriver>();

    public virtual ICollection<TbLocation> TbLocations { get; set; } = new List<TbLocation>();

    public virtual ICollection<TbSaleUnitMaster> TbSaleUnitMasters { get; set; } = new List<TbSaleUnitMaster>();

    public virtual ICollection<TbSalesArea> TbSalesAreas { get; set; } = new List<TbSalesArea>();

    public virtual ICollection<TbStorehouse> TbStorehouses { get; set; } = new List<TbStorehouse>();
}
