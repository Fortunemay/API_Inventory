using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbBarcodeMapping
{
    public int MappingId { get; set; }

    public int? BarcodeId { get; set; }

    public int? ProductId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TbBarcode? Barcode { get; set; }

    public virtual TbProduct? Product { get; set; }
}
