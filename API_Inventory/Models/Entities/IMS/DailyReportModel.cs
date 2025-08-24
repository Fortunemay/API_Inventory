using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace API_Inventory.Models.Entities.IMS
{
    public class DailyReportReq
    {
       [Required] public string? warehouseCode { get; set; }
       [Required] public string? reportDate { get; set; }
       [Required] public int? storehouseId { get; set; }
       public int? brandId { get; set; }
       public int? categoriesId { get; set; }
       public int? typeOfproduct { get; set; }
       public int? brandHoldings { get; set; }
    }
    public class DailyReportRes
    {
        public string? status { get; set; }
        public string? message { get; set; }
        public List<DailyReportData>? data { get; set; }
    }
    public class DailyReportData
    {
        public int? brandHoldingID { get; set; }
        public string? brandHoldingName { get; set; }
        public int? brandID { get; set; }
        public string? brandCode { get; set; }
        public string? brandName { get; set; }
        public string? productCode { get; set; }
        public string? productName { get; set; }
        public int? conversion { get; set; }
        public string? productImage { get; set; }
        public int? categoryID { get; set; }
        public string? categoryName { get; set; }
        public string? subCategoryName { get; set; }
        public string? warehouseCode { get; set; }
        public string? warehouseName { get; set; }
        public int? storehouseListId { get; set; }
        public int? storehouseId { get; set; }
        public string? storehouseCode { get; set; }
        public string? storehouseName { get; set; }
        public string? storehouseTypeName { get; set; }
        public string? businessUnitName { get; set; }
        public string? broughtForwardUnit { get; set; }
        public int? broughtForwardBalanceQty { get; set; }
        public string? receUnit { get; set; }
        public int? receQty { get; set; }
        public int? brokenQty { get; set; }
        public string? brokenUnit { get; set; }
        public string? expoUnit { get; set; }
        public int? expoQty { get; set; }
        public int? advanceQty { get; set; }
        public string? advanceUnit { get; set; }
        public string? balanceStoredUnit { get; set; }
        public int? balanceStoredQty { get; set; }
        public string? checkingUnit { get; set; }
        public int? checkingQty { get; set; }
        public string? diffUnit { get; set; }
        public int? diffQty { get; set; }
        public string? docDate { get; set; }
        public string? stockUnitName { get; set; }
        public double? productPrice { get; set; }
        public double? totalPrice { get; set; }
        public bool? isPremium { get; set; }

    }
}
