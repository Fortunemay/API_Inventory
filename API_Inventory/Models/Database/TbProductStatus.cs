using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbProductStatus
{
    public int StatusId { get; set; }

    public string? StatusCode { get; set; }

    public string? StatusName { get; set; }

    public string? Description { get; set; }

    public string? Remark { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
