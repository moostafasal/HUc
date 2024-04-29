using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class RegistrationPreparatoryDocumentsStudentsReceipt
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
    public DateOnly Date { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long StudentId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial035 { get; set; }

    public virtual UseresUser Student { get; set; } = null!;
}
