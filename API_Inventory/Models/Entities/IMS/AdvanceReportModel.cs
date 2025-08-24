using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace API_Inventory.Models.Entities.IMS
{

    public class AdvanceReportReq
    {
        [Required] public int userId { get; set; }
        [Required] public string? compCode { get; set; }
        [Required] public List<int>? docTypes { get; set; }
        [Required] public string? reportDate { get; set; }
    }

    public class AdvanceReportRes
    {
        public string? status { get; set; }
        public string? message { get; set; }
        public List<AdvanceReportData>? data { get; set; }
    }

    public class AdvanceReportData
    {
        public long? docId { get; set; }
        public int isAttachedFile { get; set; }
        public string? docAttFile { get; set; }
        public string? docCode { get; set; }
        public string? refCode { get; set; }
        public int? docTypeID { get; set; }
        public string? docTypeName { get; set; }
        public int? fromWarehouseID { get; set; }
        public string? fromWarehouseCode { get; set; }
        public int? fromStorehouseListID { get; set; }
        public string? fromStorehouseCode { get; set; }
        public string? fromStorehouseName { get; set; }
        public int? fromStorehouseTypeID { get; set; }
        public string? fromStorehouseTypeName { get; set; }
        public int? fromGoodsTypeID { get; set; }
        public string? fromGoodsTypeName { get; set; }
        public bool fromIsTBL { get; set; }
        public bool fromIsProvince { get; set; }
        public bool fromIsCentre { get; set; }
        public bool fromIsFactories { get; set; }
        public int? toStorehouseListID { get; set; }
        public string? toStorehouseCode { get; set; }
        public string? toStorehouseName { get; set; }
        public int? toGoodsTypeID { get; set; }
        public bool toIsTBL { get; set; }
        public bool toIsProvince { get; set; }
        public bool toIsCentre { get; set; }
        public bool toIsFactories { get; set; }
        public string? toGoodsTypeName { get; set; }
        public string? docDate { get; set; }
        public string? createdDate { get; set; }
        public string? updatedDate { get; set; }
        public string? isDocStatus { get; set; }
        public bool isActive { get; set; }
        public int sumAdvancePayAmount { get; set; }
        public string? advanceDocID { get; set; }
        public string? advanceDocCode { get; set; }
        public string? advanceReceiptDocID { get; set; }
        public string? advanceReceiptDocCode { get; set; }
        public string? advanceReceiptIsDocStatus { get; set; }
        public string? refCodeOrderPayment { get; set; }
        public string? refDocID { get; set; }
        public string? refIsDocStatus { get; set; }
        public int? workFlowId { get; set; }
        public int? workFlowStatusId { get; set; }
        public string? advApprovers { get; set; }
        public string? advPayApprovedDate { get; set; }
        public string? signatureApprove { get; set; }
        public string? advPayAction { get; set; }
        public string? advReceiptAction { get; set; }
        public string? advActionStatus { get; set; }
        public string? advanceReceiptRowCountx { get; set; }
        public string? docIDEncyp { get; set; }
        public bool isFormEntry { get; set; }
        public string? delivName { get; set; }
        public string? dueDate { get; set; }
        public int? groupID { get; set; }
        public string? groupName { get; set; }
        public string? ReqApprover { get; set; }
        public long? requestId { get; set; }
        public int? approveListId { get; set; }
        public int? requestTypeId { get; set; }
        public string? requestTypeName { get; set; }
        public bool? requestStatus { get; set; }
        public string? requestReason { get; set; }
        public string? workFlowStatusName { get; set; }
        public string? requestFrom { get; set; }
        public string? requestTo { get; set; }
        public List<documentApprovalLs>? documentWorkflowLs { get; set; }

    }

    public class documentApprovalLs
    {
        public int? userId { get; set; }
    }
}
