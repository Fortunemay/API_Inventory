using System;
using System.Collections.Generic;

namespace API_Inventory.Models.Database;

public partial class TbAuditLog
{
    public long LogId { get; set; }

    public string? UserCode { get; set; }

    public string? PageUrl { get; set; }

    public string? LogData { get; set; }

    public string? MethodeType { get; set; }

    public string? IpAddress { get; set; }

    public DateTime? CreatedDate { get; set; }
}
