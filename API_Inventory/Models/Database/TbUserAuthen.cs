using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbUserAuthen
{
    public int AuthenId { get; set; }

    public string? UserCode { get; set; }

    public string? PassPhrase { get; set; }

    public string? AuthenKey { get; set; }

    public string? RedirectUrl { get; set; }

    public int? BrandHoldingId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public virtual TbBrandHolding? BrandHolding { get; set; }
}
