using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace API_Inventory.Models.Entities.IMS
{

    public class MovementReportReq
    {
        [Required] public string? compCode { get; set; }
        [Required] public string? warehouseCode { get; set; }
        [Required] public int? storehouseListId { get; set; }
        [Required] public string? reportDate { get; set; }
        public int? categoriesId { get; set; }
    }

    public class MovementReportRes
    {
        public string? status { get; set; }
        public string? message { get; set; }
        public List<MovementReportData>? data { get; set; }
    }

    public class MovementReportData
    {
        public string? warehouseCode { get; set; }
        public string? warehouseName { get; set; }
        public string? businessUnitName { get; set; }
        public string? storehouseTypeName { get; set; }
        public int storehouseListID { get; set; }
        public int storehouseID { get; set; }
        public string? storehouseCode { get; set; }
        public string? storehouseName { get; set; }
        public string? brandCode { get; set; }
        public string? brandName { get; set; }
        public string? categoryName { get; set; }
        public string? subCategoryCode { get; set; }
        public string? subCategoryName { get; set; }
        public string? productCode { get; set; }
        public string? productName { get; set; }
        public string? broughtForwardUnit { get; set; }
        public int? broughtForwardBalanceQty { get; set; }
        public double? broughtForwardBalanceDiv { get; set; }
        public string? receUnit { get; set; }
        public int? receQty { get; set; }
        public double? receDiv { get; set; }
        public string? expoUnit { get; set; }
        public int? expoQty { get; set; }
        public double? expoDiv { get; set; }
        public string? brokenUnit { get; set; }
        public int? brokenQty { get; set; }
        public double? brokenDiv { get; set; }
        public string? advanceReUnit { get; set; }
        public int? advanceReQty { get; set; }
        public double? advanceReDiv { get; set; }
        public string? advancePeUnit { get; set; }
        public int? advancePeQty { get; set; }
        public double? advancePeDiv { get; set; }
        public string? advanceUnit { get; set; }
        public int? advanceQty { get; set; }
        public double? advanceDiv { get; set; }
        public string? balanceUnit { get; set; }
        public int? balanceQty { get; set; }
        public double? balanceDiv { get; set; }
        public string? checkingUnit { get; set; }
        public int? checkingQty { get; set; }
        public double? checkingDiv { get; set; }
        public string? diffUnit { get; set; }
        public int? diffQty { get; set; }
        public double? diffDiv { get; set; }
        public string? carryForwardUnit { get; set; }
        public int? CarryForwardQty { get; set; }
        public decimal? carryForwardDiv { get; set; }
        public int? conversion { get; set; }
        public double? productPrice { get; set; }
        public string? stockUnitName { get; set; }
        public string? remarkTacking { get; set; }
    }

}
