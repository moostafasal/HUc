using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class DepartmentsMaterial
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
    public string? EnName { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public double Weight { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Type { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public int DepartmentId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int StageId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long? UserId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int YearId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Order { get; set; }

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
    public double Rate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public double PartHours { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public double TheryHours { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public double FinalPractical { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public double FinalTheoretical { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool IsChecked { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial898 { get; set; }

    public virtual DepartmentsDepartment Department { get; set; } = null!;

    public virtual ICollection<DepartmentsMaterialCommentsAndRating> DepartmentsMaterialCommentsAndRatings { get; set; } = new List<DepartmentsMaterialCommentsAndRating>();

    public virtual ICollection<DepartmentsMaterialLab> DepartmentsMaterialLabs { get; set; } = new List<DepartmentsMaterialLab>();

    public virtual ICollection<DepartmentsMaterialfile> DepartmentsMaterialfiles { get; set; } = new List<DepartmentsMaterialfile>();

    public virtual ICollection<DepartmentsStudentmaterial> DepartmentsStudentmaterials { get; set; } = new List<DepartmentsStudentmaterial>();

    public virtual ICollection<ManagementsLaboratorySpace> ManagementsLaboratorySpaces { get; set; } = new List<ManagementsLaboratorySpace>();

    public virtual ICollection<ManagementsTeachingAssignment> ManagementsTeachingAssignments { get; set; } = new List<ManagementsTeachingAssignment>();

    public virtual ICollection<OmrSolverExamNumber> OmrSolverExamNumbers { get; set; } = new List<OmrSolverExamNumber>();

    public virtual DepartmentsStage Stage { get; set; } = null!;

    public virtual UseresUser? User { get; set; }

    public virtual DepartmentsYear Year { get; set; } = null!;
}
