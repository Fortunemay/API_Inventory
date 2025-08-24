using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbDocument
{
    public long DocId { get; set; }

    public string? DocCode { get; set; }

    public DateTime? DocDate { get; set; }

    public DateTime? DueDate { get; set; }

    public int? DocType { get; set; }

    public string? RefCode { get; set; }

    public string? TranferCode { get; set; }

    public string? PaymentCode { get; set; }

    public int? FromStorehouseListId { get; set; }

    public int? ToStorehouseListId { get; set; }

    public string? CustomerName { get; set; }

    public string? TaxId { get; set; }

    public int? AreaId { get; set; }

    public string? SaleName { get; set; }

    public string? DelivName { get; set; }

    public string? Telephone { get; set; }

    public string? ExposeDate { get; set; }

    public string? ExposeTime { get; set; }

    public string? Description { get; set; }

    public string? Remark { get; set; }

    public string? Reason { get; set; }

    public bool? IsActive { get; set; }

    public string? DocStatus { get; set; }

    public int? DocStatusId { get; set; }

    public string? AttFiles { get; set; }

    public int? CompId { get; set; }

    public int? WarehouseId { get; set; }

    public int? ReceivedBy { get; set; }

    public string? FirstReviewer { get; set; }

    public string? SecondReviewer { get; set; }

    public string? ReceiveFrom { get; set; }

    public string? Approvers { get; set; }

    public string? Signature { get; set; }

    public string? Requester { get; set; }

    public string? SecondSignature { get; set; }

    public string? IssueType { get; set; }

    public int? TransactionType { get; set; }

    public string? OwnerName { get; set; }

    public string? TranferType { get; set; }

    public string? CarLicense { get; set; }

    public bool? IsAdvancePay { get; set; }

    public int? UploadAdvancePay { get; set; }

    public bool? IsFormEntry { get; set; }

    public int? SaleAccessListId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsAccepted { get; set; }

    public int? AcceptedBy { get; set; }

    public DateTime? AcceptedDate { get; set; }

    public bool? IsConfirm { get; set; }

    public string? Consignee { get; set; }

    public virtual TbCompanyProfile? Comp { get; set; }

    public virtual TbDocumentType? DocTypeNavigation { get; set; }

    public virtual TbSaleAccessList? SaleAccessList { get; set; }

    public virtual ICollection<TbDocumentChangeRequestDetail> TbDocumentChangeRequestDetails { get; set; } = new List<TbDocumentChangeRequestDetail>();

    public virtual ICollection<TbProductTransaction> TbProductTransactions { get; set; } = new List<TbProductTransaction>();

    public virtual ICollection<TbWorkFlowTransaction> TbWorkFlowTransactions { get; set; } = new List<TbWorkFlowTransaction>();

    public virtual TbWarehouse? Warehouse { get; set; }
}
