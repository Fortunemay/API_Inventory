using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbCustomer
{
    public int CusId { get; set; }

    public string? CusCode { get; set; }

    public string? CusName { get; set; }

    public string? TaxId { get; set; }

    public string? Address { get; set; }

    public string? Village { get; set; }

    public string? VillageName { get; set; }

    public string? Soi { get; set; }

    public string? Road { get; set; }

    public string? Building { get; set; }

    public string? Floor { get; set; }

    public string? Unit { get; set; }

    public string? SubDistrict { get; set; }

    public string? District { get; set; }

    public string? Province { get; set; }

    public string? Country { get; set; }

    public string? Post { get; set; }

    public string? Tel { get; set; }

    public string? Fax { get; set; }

    public int? RegionId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TbRegion? Region { get; set; }
}
