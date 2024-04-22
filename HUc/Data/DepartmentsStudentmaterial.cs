using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class DepartmentsStudentmaterial
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Theoretical1 { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Practical1 { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? FirstTotal { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Theoretical2 { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Practical2 { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? SecondTotal { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Theoretical3 { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Practical3 { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? ThirdTotal { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? HelpDgree { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Quest { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Writen1 { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Dor1 { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Writen2 { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Dor1Helped { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Dor2 { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Dor2Helped { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Dor3 { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Dor3Helped { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Dor4 { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? Total { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Writen3 { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Appreciation { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool? IsCarry { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool? IsCarried { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool? IsPresent { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool? IsNotDor1 { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int MaterialId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int StudentinfromtionId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool? Fulfilled { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool? IsFail { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool? IsFailed { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public double? FinalPractical { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public double? FinalTheoretical { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool? SickLeave { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool? IsMissing { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool? Disabled { get; set; }

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
    public double? FinalPractical2 { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public double? FinalTheoretical2 { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial927 { get; set; }

    public virtual DepartmentsMaterial Material { get; set; } = null!;

    public virtual DepartmentsStudentinfromtion Studentinfromtion { get; set; } = null!;
}
