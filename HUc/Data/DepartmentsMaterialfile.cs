using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class DepartmentsMaterialfile
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string File { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int MaterialId { get; set; }

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
    public bool? EvaluationCheck { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool DeanCheck { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool IsChecked { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Link { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? PageCount { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Thumbnail { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial905 { get; set; }

    public virtual ICollection<DepartmentsMaterialfilesCommentsAndRating> DepartmentsMaterialfilesCommentsAndRatings { get; set; } = new List<DepartmentsMaterialfilesCommentsAndRating>();

    public virtual DepartmentsMaterial Material { get; set; } = null!;
}
