using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class RegistrationValidityRespondStudent
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public long Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int ValidityRespondId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long StudentsId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial042 { get; set; }

    public virtual UseresUser Students { get; set; } = null!;

    public virtual RegistrationValidityRespond ValidityRespond { get; set; } = null!;
}
