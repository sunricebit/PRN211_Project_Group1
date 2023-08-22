using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PRN211_Project_Group1.DataAccess;

public partial class Category
{
    public int Id { get; set; }

    public string? CategoryName { get; set; }
    [Browsable(false)]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
