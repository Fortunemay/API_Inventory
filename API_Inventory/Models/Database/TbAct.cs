using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbAct
{
    public int ActId { get; set; }

    public string? ActName { get; set; }

    public DateOnly? ActCreate { get; set; }

    public DateOnly? ActExpiration { get; set; }
}
