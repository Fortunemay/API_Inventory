using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbTdocumntFirstDate
{
    public int Idx { get; set; }

    public int? CompId { get; set; }

    public string? CompCode { get; set; }

    public int? StorehouseListId { get; set; }

    public DateTime? MinDate { get; set; }

    public DateTime? MaxDate { get; set; }
}
