using System;
using System.Collections.Generic;

namespace PRN211_Project_Group1.DataAccess;

public partial class Product
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public int? Quantity { get; set; }

    public double? Price { get; set; }

    public int? CategoryId { get; set; }

    public int? ProviderId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual ICollection<History> Histories { get; set; } = new List<History>();

    public virtual Provider? Provider { get; set; }
}
