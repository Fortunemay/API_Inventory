using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbTadvanceProductBalance
{
    public int? WorkFlowStatusId { get; set; }

    public string? WorkFlowStatusName { get; set; }

    public DateTime? AdvPayApprovedDate { get; set; }

    public int? UserIdapprove { get; set; }

    public string? UserNameApprove { get; set; }

    public string? SignatureApprove { get; set; }

    public string? WarehouseCode { get; set; }

    public string? WarehouseName { get; set; }

    public string? WarehouseAddress { get; set; }

    public bool? IsAddressUsed { get; set; }

    public string? CompCode { get; set; }

    public string? CompName { get; set; }

    public string? CompAddress { get; set; }

    public string? ReceiveFrom { get; set; }

    public string? CustomerName { get; set; }

    public string? Approvers { get; set; }

    public int? FromStorehouseListId { get; set; }

    public string? FromStoredCode { get; set; }

    public string? FromStoredName { get; set; }

    public int? ToStorehouseListId { get; set; }

    public string? ToStoredCode { get; set; }

    public string? ToStoredName { get; set; }

    public int? DocId { get; set; }

    public string? DocCode { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? DocDate { get; set; }

    public DateTime? ActionDate { get; set; }

    public TimeOnly? ActionTime { get; set; }

    public string? DelivName { get; set; }

    public string? Telephone { get; set; }

    public string? Remark { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductName { get; set; }

    public string? ReceUnit { get; set; }

    public string? ReceQty { get; set; }

    public string? ExpoUnit { get; set; }

    public string? ExpoQty { get; set; }

    public string? SumAdvancePayAmountUnit { get; set; }

    public decimal? SumAdvancePayAmount { get; set; }

    public decimal? BalanceAmountQty { get; set; }

    public decimal? Conversion { get; set; }

    public bool? IsFormEntry { get; set; }

    public string? IsDocStatus { get; set; }

    public string? RemarkTrans { get; set; }

    public string? TranferType { get; set; }

    public string? Reason { get; set; }

    public string? DocAttFile { get; set; }

    public string? CarLicense { get; set; }

    public int? CompId { get; set; }

    public string? StockUnitName { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? ApproveListId { get; set; }

    public int? RequestId { get; set; }

    public int? RequestTypeId { get; set; }

    public string? RequestTypeName { get; set; }

    public string? RequestReason { get; set; }

    public string? RequestStatus { get; set; }

    public string? RequestFrom { get; set; }

    public string? RequestTo { get; set; }
}
