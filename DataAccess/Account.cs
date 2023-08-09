using System;
using System.Collections.Generic;

namespace PRN211_Project_Group1.DataAccess;

public partial class Account
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? FullName { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Role { get; set; }
}
