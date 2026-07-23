using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class MessageGroup
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public int? NewCount { get; set; }

    public bool? IsNewMessages { get; set; }

    public string? Members { get; set; }

    public virtual ICollection<GroupMember> GroupMembers { get; set; } = new List<GroupMember>();

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();
}
