using System;
using System.Collections.Generic;

namespace HireMeNow_Wrkshp_MVC.Models;

public partial class Company
{
    public int CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? Location { get; set; }

    public virtual ICollection<Job> Jobs { get; set; } = new List<Job>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
