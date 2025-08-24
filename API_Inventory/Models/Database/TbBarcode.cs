using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbBarcode
{
    public int BarcodeId { get; set; }

    public string? Barcode { get; set; }

    public string? UnitSizeName { get; set; }

    public int? UnitSize { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<TbBarcodeMapping> TbBarcodeMappings { get; set; } = new List<TbBarcodeMapping>();
}
