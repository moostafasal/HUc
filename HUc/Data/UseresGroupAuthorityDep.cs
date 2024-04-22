using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class UseresGroupAuthorityDep
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long GroupAuthorityId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int DepartmentId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial469 { get; set; }

    public virtual DepartmentsDepartment Department { get; set; } = null!;

    public virtual UseresGroupAuthority GroupAuthority { get; set; } = null!;
}
