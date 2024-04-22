using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class UseresCollege
{
    /// <summary>
    /// TRIAL
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Name { get; set; }

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
    public string? Trial463 { get; set; }

    public virtual ICollection<UseresUser> UseresUserBachelors { get; set; } = new List<UseresUser>();

    public virtual ICollection<UseresUser> UseresUserMasters { get; set; } = new List<UseresUser>();

    public virtual ICollection<UseresUser> UseresUserPhDs { get; set; } = new List<UseresUser>();
}
