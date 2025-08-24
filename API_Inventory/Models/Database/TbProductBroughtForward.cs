using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbProductBroughtForward
{
    public int Idx { get; set; }

    public int? WarehouseId { get; set; }

    public int? StorehouseListId { get; set; }

    public string? ProductCode { get; set; }

    public int? BroughtForwardVol { get; set; }

    public int? ReceVol { get; set; }

    public decimal? ReceVal { get; set; }

    public int? ExpoVol { get; set; }

    public decimal? ExpoVal { get; set; }

    public int? BrokenVol { get; set; }

    public decimal? BrokenVal { get; set; }

    public int? BalanceVol { get; set; }

    public int? AdvPayVol { get; set; }

    public decimal? AdvPayVal { get; set; }

    public int? AmountVol { get; set; }

    public DateTime? LastUpdate { get; set; }
}
