using System;
using System.Collections.Generic;

namespace PRN211_Project_Group1.DataAccess;

public partial class Category
{
    public int Id { get; set; }

    public string? CategoryName { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
