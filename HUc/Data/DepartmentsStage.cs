using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class DepartmentsStage
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Stage { get; set; } = null!;

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
    public string? Trial908 { get; set; }

    public virtual ICollection<DepartmentsExamsSchedule> DepartmentsExamsSchedules { get; set; } = new List<DepartmentsExamsSchedule>();

    public virtual ICollection<DepartmentsLecturesSchedule> DepartmentsLecturesSchedules { get; set; } = new List<DepartmentsLecturesSchedule>();

    public virtual ICollection<DepartmentsMaterial> DepartmentsMaterials { get; set; } = new List<DepartmentsMaterial>();

    public virtual ICollection<DepartmentsStudentinfromtion> DepartmentsStudentinfromtions { get; set; } = new List<DepartmentsStudentinfromtion>();

    public virtual ICollection<ManagementsGroupsCount> ManagementsGroupsCounts { get; set; } = new List<ManagementsGroupsCount>();
}
