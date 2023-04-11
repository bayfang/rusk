using System;
using System.Collections.Generic;

namespace zamu.Models;

public partial class Maintab
{
    public int Phone { get; set; }

    public string Email { get; set; } = null!;

    public string? Cnumber { get; set; }

    public string? Unmber { get; set; }

    public string? Nickname { get; set; }

    public DateTime? Bd { get; set; }

    public string? Sexul { get; set; }

    public string? Remark { get; set; }

    public string Name { get; set; } = null!;

    public virtual Myname NameNavigation { get; set; } = null!;
}
