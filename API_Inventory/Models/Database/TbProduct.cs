using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbProduct
{
    public int ProductId { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public int? SalesUnit { get; set; }

    public int? BaseUnit { get; set; }

    public int? ConversionId { get; set; }

    public int? BrandId { get; set; }

    public int? CategoryId { get; set; }

    public int? SubCategoryId { get; set; }

    public double? Degree { get; set; }

    public double? Milliliter { get; set; }

    public string? Description { get; set; }

    public string? Remark { get; set; }

    public int? RegionId { get; set; }

    public bool? IsActive { get; set; }

    public int? CsperPlt { get; set; }

    public bool? IsNew { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual TbStockUnit? BaseUnitNavigation { get; set; }

    public virtual TbBrand? Brand { get; set; }

    public virtual TbCategory? Category { get; set; }

    public virtual TbConversion? Conversion { get; set; }

    public virtual TbStockUnit? SalesUnitNavigation { get; set; }

    public virtual TbSubCategory? SubCategory { get; set; }

    public virtual ICollection<TbBarcodeMapping> TbBarcodeMappings { get; set; } = new List<TbBarcodeMapping>();
}
