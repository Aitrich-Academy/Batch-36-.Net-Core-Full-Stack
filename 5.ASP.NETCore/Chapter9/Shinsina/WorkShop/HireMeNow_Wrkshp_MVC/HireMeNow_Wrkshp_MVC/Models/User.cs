using System;
using System.Collections.Generic;

namespace HireMeNow_Wrkshp_MVC.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public int? CompanyId { get; set; }

    public virtual Company? Company { get; set; }
}
