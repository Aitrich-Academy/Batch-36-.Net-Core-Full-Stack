using System;
using System.Collections.Generic;

namespace HireMeNow_Wrkshp_MVC.Models;

public partial class Job
{
    public int JobId { get; set; }

    public string? JobTitle { get; set; }

    public string? Description { get; set; }

    public decimal? Salary { get; set; }

    public string? Location { get; set; }

    public string? TypeOfWork { get; set; }

    public int? CompanyId { get; set; }

    public virtual Company? Company { get; set; }
}
