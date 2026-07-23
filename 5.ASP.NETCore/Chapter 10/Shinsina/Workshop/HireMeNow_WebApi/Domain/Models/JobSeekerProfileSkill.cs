using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class JobSeekerProfileSkill
{
    public Guid JobSeekerProfileId { get; set; }

    public Guid SkillId { get; set; }

    public Guid Id { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual JobSeekerProfile JobSeekerProfile { get; set; } = null!;

    public virtual Skill Skill { get; set; } = null!;
}
