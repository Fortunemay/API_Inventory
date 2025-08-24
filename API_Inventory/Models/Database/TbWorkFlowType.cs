using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbWorkFlowType
{
    public int WorkFlowTypeId { get; set; }

    public string WorkFlowTypeName { get; set; } = null!;

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<TbWorkFlow> TbWorkFlows { get; set; } = new List<TbWorkFlow>();
}
