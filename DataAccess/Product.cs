using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PRN211_Project_Group1.DataAccess;

public partial class Product
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public int? Quantity { get; set; }

    public double? Price { get; set; }

    public int? CategoryId { get; set; }

    public int? ProviderId { get; set; }
    [Browsable(false)]
    public virtual Category? Category { get; set; }
    [Browsable(false)]
    public virtual ICollection<History> Histories { get; set; } = new List<History>();
    [Browsable(false)]
    public virtual Provider? Provider { get; set; }
}
