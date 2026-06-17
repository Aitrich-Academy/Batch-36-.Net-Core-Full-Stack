using System;
using System.Collections.Generic;

namespace HireMeNow_MVC_Exc.Models;

public partial class JobApplication
{
    public Guid ApplicationId { get; set; }

    public Guid UserId { get; set; }

    public Guid JobId { get; set; }

    public DateTime? AppliedDate { get; set; }

    public virtual Job Job { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
