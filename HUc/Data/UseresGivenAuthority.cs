using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class UseresGivenAuthority
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long GroupId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long UserId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? DepId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public double Discont { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial466 { get; set; }

    public virtual DepartmentsDepartment? Dep { get; set; }

    public virtual UseresGroupAuthority Group { get; set; } = null!;

    public virtual UseresUser User { get; set; } = null!;
}
