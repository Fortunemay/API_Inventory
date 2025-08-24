using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbTstockTransfer
{
    public int Id { get; set; }

    public string DocNo { get; set; } = null!;

    public DateTime DocDate { get; set; }

    public string ItemCode { get; set; } = null!;

    public decimal BaseQty { get; set; }

    public string? SaleCode { get; set; }

    public string? FromShelfCode { get; set; }

    public string? ToShelfCode { get; set; }

    public string? WhCode { get; set; }

    public string? WhName { get; set; }

    public string? CompanyCode { get; set; }

    public string? CompanyName { get; set; }

    public string? Remark { get; set; }

    public DateTime? CreatedDate { get; set; }
}
