using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class AuthPermission
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int ContentTypeId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Codename { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial411 { get; set; }

    public virtual ICollection<AuthGroupPermission> AuthGroupPermissions { get; set; } = new List<AuthGroupPermission>();

    public virtual DjangoContentType ContentType { get; set; } = null!;

    public virtual ICollection<UseresUserUserPermission> UseresUserUserPermissions { get; set; } = new List<UseresUserUserPermission>();
}
