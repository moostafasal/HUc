using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class RegistrationValidityRespond
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
    public string Title { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly Date { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string Isso { get; set; } = null!;

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? File { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial038 { get; set; }

    public virtual ICollection<RegistrationValidityRespondStudent> RegistrationValidityRespondStudents { get; set; } = new List<RegistrationValidityRespondStudent>();
}
