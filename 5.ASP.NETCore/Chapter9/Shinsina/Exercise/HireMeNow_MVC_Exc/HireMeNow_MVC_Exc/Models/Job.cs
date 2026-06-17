using System;
using System.Collections.Generic;

namespace HireMeNow_MVC_Exc.Models;

public partial class Job
{
    public Guid JobId { get; set; }

    public string? JobTitle { get; set; }

    public string? Description { get; set; }

    public string? CompanyName { get; set; }

    public string? Location { get; set; }

    public decimal? Salary { get; set; }

    public DateTime? PostedDate { get; set; }

    public virtual ICollection<JobApplication> JobApplications { get; set; } = new List<JobApplication>();
}
