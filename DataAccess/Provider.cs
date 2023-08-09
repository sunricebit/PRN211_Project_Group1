using System;
using System.Collections.Generic;

namespace PRN211_Project_Group1.DataAccess;

public partial class Provider
{
    public int Id { get; set; }

    public string? ProviderName { get; set; }

    public string? Phone { get; set; }

    public string? Address { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
