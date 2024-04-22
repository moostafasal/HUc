using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class RegistrationIdList
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset? ModifiedDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Group { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly? CreatedDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int DepId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial035 { get; set; }

    public virtual DepartmentsDepartment Dep { get; set; } = null!;
}
