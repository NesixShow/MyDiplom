
using System;
using System.Collections.Generic;

namespace tipoDiplom.Models;

public partial class MatType
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public override string ToString()
    {
        return Name;
    }

}