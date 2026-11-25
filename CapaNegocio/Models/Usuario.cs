using System;
using System.Collections.Generic;

namespace CapaNegocio.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? DocumentoIdentidad { get; set; }

    public string? Usuario1 { get; set; }

    public string? Clave { get; set; }

    public int? IdCargo { get; set; }

    public virtual Cargo? IdCargoNavigation { get; set; }
}
