using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class GroupMember
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public Guid? ToUserId { get; set; }

    public string? Email { get; set; }

    public Guid? MessageGroupId { get; set; }

    public virtual MessageGroup? MessageGroup { get; set; }
}
