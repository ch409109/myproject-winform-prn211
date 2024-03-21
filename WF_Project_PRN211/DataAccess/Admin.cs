using System;
using System.Collections.Generic;

namespace WF_Project_PRN211.DataAccess;

public partial class Admin
{
    public int AdminId { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }
}
