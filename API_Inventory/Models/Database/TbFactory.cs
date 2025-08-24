using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbFactory
{
    public int FactId { get; set; }

    public string? FactName { get; set; }

    public string? ShortName { get; set; }

    public string? Address { get; set; }

    public string? Tel { get; set; }

    public string? Fax { get; set; }

    public int? CompId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<TbFactoriesAreaCode> TbFactoriesAreaCodes { get; set; } = new List<TbFactoriesAreaCode>();
}
