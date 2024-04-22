﻿using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class UseresNationality
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
    public string? Trial473 { get; set; }

    public virtual ICollection<UseresUser> UseresUsers { get; set; } = new List<UseresUser>();
}
