using System;
using System.Collections.Generic;

namespace Domain.Models;

public partial class AuthUser
{
    public Guid Id { get; set; }

    public string? Password { get; set; }

    public string? ConnectionId { get; set; }

    public bool? OnlineStatus { get; set; }

    public virtual SystemUser IdNavigation { get; set; } = null!;
}
