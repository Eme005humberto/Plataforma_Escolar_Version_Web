using System;
using System.Collections.Generic;

namespace CapaNegocio.Models;

public partial class Cargo
{
    public int IdCargo { get; set; }

    public string? Cargo1 { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
