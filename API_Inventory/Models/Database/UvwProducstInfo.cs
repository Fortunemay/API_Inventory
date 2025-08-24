using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class UvwProducstInfo
{
    public int ProductId { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public int? CategoryId { get; set; }

    public string? CategoryCode { get; set; }

    public string? CategoryName { get; set; }

    public int? SubCategoryId { get; set; }

    public string? SubCategoryCode { get; set; }

    public string? SubCategoryName { get; set; }

    public int? BrandId { get; set; }

    public string? BrandCode { get; set; }

    public string? BrandName { get; set; }

    public int? ConversionId { get; set; }

    public int? Conversion { get; set; }

    public int? SalesUnit { get; set; }

    public string? SaleUnitName { get; set; }

    public int? BaseUnit { get; set; }

    public string? BaseUnitName { get; set; }

    public string ProductImage { get; set; } = null!;

    public bool? IsActive { get; set; }
}
