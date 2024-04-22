using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class DjangoContentType
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string AppLabel { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Model { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial414 { get; set; }

    public virtual ICollection<AuditlogLogentry> AuditlogLogentries { get; set; } = new List<AuditlogLogentry>();

    public virtual ICollection<AuthPermission> AuthPermissions { get; set; } = new List<AuthPermission>();

    public virtual ICollection<DjangoAdminLog> DjangoAdminLogs { get; set; } = new List<DjangoAdminLog>();

    public virtual ICollection<ReversionVersion> ReversionVersions { get; set; } = new List<ReversionVersion>();
}
