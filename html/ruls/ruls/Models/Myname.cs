using System;
using System.Collections.Generic;

namespace ruls.Models;

public partial class Myname
{
    public string Name { get; set; } = null!;

    public string State { get; set; } = null!;

    public virtual ICollection<Maintab> Maintabs { get; } = new List<Maintab>();
}
