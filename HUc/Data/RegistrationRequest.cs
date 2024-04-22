using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class RegistrationRequest
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
    public string? Title { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public DateOnly? Date { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Isso { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int VoucherNumber { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Notes { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public long StudentsId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Type { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public int? BookId { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Status { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial038 { get; set; }

    public virtual ManagementsInsideInAndOut? Book { get; set; }

    public virtual UseresUser Students { get; set; } = null!;
}
