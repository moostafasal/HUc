using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class DepartmentsMaterialCommentsAndRating
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset? CreatedDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateTimeOffset? ModifiedDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Comment { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public double Rate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool IsChecked { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int MaterialId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long StudentId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial901 { get; set; }

    public virtual DepartmentsMaterial Material { get; set; } = null!;

    public virtual UseresUser Student { get; set; } = null!;
}
