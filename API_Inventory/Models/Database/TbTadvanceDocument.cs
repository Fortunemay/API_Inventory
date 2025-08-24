using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbTadvanceDocument
{
    public long DocId { get; set; }

    public string? DocCode { get; set; }

    public string? RefCode { get; set; }

    public int? DocType { get; set; }

    public string? TypeName { get; set; }

    public int? WorkFlowId { get; set; }

    public DateTime? AdvPayApprovedDate { get; set; }

    public string? AdvPayApprover { get; set; }

    public string? SignatureApprove { get; set; }

    public int? FromStorehouseListId { get; set; }

    public string? FromStorehouseName { get; set; }

    public int? FromStorehouseTypeId { get; set; }

    public string? FromStorehouseCode { get; set; }

    public string? FromStorehouseTypeName { get; set; }

    public int? FromGoodsTypeId { get; set; }

    public string? FromGoodsTypeName { get; set; }

    public bool? FromIsTbl { get; set; }

    public bool? FromIsProvince { get; set; }

    public bool? FromIsCentre { get; set; }

    public bool? FromIsFactories { get; set; }

    public int? ToStorehouseListId { get; set; }

    public string? ToStorehouseCode { get; set; }

    public string? ToStorehouseName { get; set; }

    public int? ToGoodsTypeId { get; set; }

    public string? ToGoodsTypeName { get; set; }

    public bool? ToIsTbl { get; set; }

    public bool? ToIsProvince { get; set; }

    public bool? ToIsCentre { get; set; }

    public bool? ToIsFactories { get; set; }

    public DateTime? DocDate { get; set; }

    public DateTime? DueDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? IsDocStatus { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsAttachedFile { get; set; }

    public string? AttFiles { get; set; }

    public bool? IsFormEntry { get; set; }

    public int? GroupId { get; set; }

    public string? GroupName { get; set; }

    public int? DocStatusId { get; set; }

    public string? Approvers { get; set; }

    public int? BusinessUnitId { get; set; }

    public string? BusinessUnitName { get; set; }

    public string? DelivName { get; set; }

    public string? RequestStatus { get; set; }

    public int? SumAdvancePayAmount { get; set; }

    public string? RefCodeOrderPayment { get; set; }

    public string? RefDocId { get; set; }

    public string? RefIsDocStatus { get; set; }

    public string? AdvancePayReceiptDocId { get; set; }

    public string? AdvancePayReceiptDocCode { get; set; }

    public string? AdvanceReceiptPayIsDocStatus { get; set; }

    public string? AdvanceReceiptPayRowCountx { get; set; }

    public string? AdvPayAction { get; set; }

    public string? AdvActionStatus { get; set; }

    public int? ApproveListId { get; set; }

    public int? RequestId { get; set; }

    public int? RequestTypeId { get; set; }

    public string? RequestTypeName { get; set; }

    public int? WorkFlowStatusId { get; set; }

    public string? WorkFlowStatusName { get; set; }

    public DateTime? RequestFrom { get; set; }

    public DateTime? RequestTo { get; set; }

    public string? RequestReason { get; set; }

    public int? UserId { get; set; }

    public int? CompId { get; set; }
}
