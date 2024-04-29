using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class ManagementsInsideInAndOut
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Title { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string IssuerCount { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly? IssuerDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Issuer { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly? ArrivalDate { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Signature { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Details { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Book { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? BookTypeId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool ReadIt { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? DepartmentId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? ArrivalCount { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? InsideInAndOutId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? SourceId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Species { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public bool Answered { get; set; }

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
    public string? Subject { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Answer { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? TitleBook { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Conclusion { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial999 { get; set; }

    public virtual ManagementsIssueType? BookType { get; set; }

    public virtual DepartmentsDepartment? Department { get; set; }

    public virtual ManagementsInsideInAndOut? InsideInAndOut { get; set; }

    public virtual ICollection<ManagementsInsideInAndOut> InverseInsideInAndOut { get; set; } = new List<ManagementsInsideInAndOut>();

    public virtual ICollection<ManagementsBooksDepartment> ManagementsBooksDepartments { get; set; } = new List<ManagementsBooksDepartment>();

    public virtual ICollection<ManagementsInsideInAndOutUser> ManagementsInsideInAndOutUsers { get; set; } = new List<ManagementsInsideInAndOutUser>();

    public virtual ICollection<RegistrationRequest> RegistrationRequests { get; set; } = new List<RegistrationRequest>();

    public virtual ManagementsIssuer? Source { get; set; }
}
