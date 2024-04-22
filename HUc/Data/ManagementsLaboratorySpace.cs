using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class ManagementsLaboratorySpace
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public double Space { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int MaterialId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long TypeId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial022 { get; set; }

    public virtual DepartmentsMaterial Material { get; set; } = null!;

    public virtual ManagementsQuorumType Type { get; set; } = null!;
}
