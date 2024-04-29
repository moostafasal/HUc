using System;
using System.Collections.Generic;

namespace HUc.Data;

/// <summary>
/// TRIAL
/// </summary>
public partial class HucsiteNews
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
    public DateTimeOffset? Date { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? DefaultImg { get; set; }

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
    public string? Video { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? MegLink { get; set; }

    /// <summary>
    /// TRIAL
    /// </summary>
    public string? Trial443 { get; set; }

    public virtual ICollection<HucsiteNewsDepartment> HucsiteNewsDepartments { get; set; } = new List<HucsiteNewsDepartment>();

    public virtual ICollection<HucsiteNewsImg> HucsiteNewsImgs { get; set; } = new List<HucsiteNewsImg>();

    public virtual ICollection<HucsiteNewsUser> HucsiteNewsUsers { get; set; } = new List<HucsiteNewsUser>();
}
