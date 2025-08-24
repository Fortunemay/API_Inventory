using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbDocumentsDummy
{
    public int DummyId { get; set; }

    public int UserId { get; set; }

    public int StorehouseListId { get; set; }
}
