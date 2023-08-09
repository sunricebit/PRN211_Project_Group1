using System;
using System.Collections.Generic;

namespace PRN211_Project_Group1.DataAccess;

public partial class History
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public string? Status { get; set; }

    public DateTime? TransactionDate { get; set; }

    public int? Quatity { get; set; }

    public string? Note { get; set; }

    public virtual Product? Product { get; set; }
}
