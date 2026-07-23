using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class Message
{
    public Guid Id { get; set; }

    public Guid? FromUserId { get; set; }

    public Guid? ToUserId { get; set; }

    public Guid? MessageGroupId { get; set; }

    public string? From { get; set; }

    public string? To { get; set; }

    public string Content { get; set; } = null!;

    public DateTime? SentDate { get; set; }

    public string? ToGroup { get; set; }

    public int? Status { get; set; }

    public virtual MessageGroup? MessageGroup { get; set; }
}
