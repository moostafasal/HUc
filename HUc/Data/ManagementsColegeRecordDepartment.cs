using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class ManagementsColegeRecordDepartment
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool ReadIt { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int DepartmentId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int InsideInAndOutId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial996 { get; set; }

    public virtual DepartmentsDepartment Department { get; set; } = null!;

    public virtual ManagementsColegeRecord InsideInAndOut { get; set; } = null!;
}
