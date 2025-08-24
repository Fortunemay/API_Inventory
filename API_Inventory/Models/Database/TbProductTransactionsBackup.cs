using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbProductTransactionsBackup
{
    public long? TransId { get; set; }

    public long? DocId { get; set; }

    public string? ProductCode { get; set; }

    public int? StorehouseListId { get; set; }

    public int? ReceQty { get; set; }

    public int? ExpoQty { get; set; }

    public double? Price { get; set; }

    public double? Vat { get; set; }

    public DateTime? IssueDate { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public string? Descriptoin { get; set; }

    public string? Remark { get; set; }

    public string? RefCode { get; set; }

    public string? PaymentCode { get; set; }

    public int? StatusId { get; set; }

    public string? AttFiles { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsNew { get; set; }

    public bool? IsPremium { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
