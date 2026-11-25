using System;
using System.Collections.Generic;

namespace CapaNegocio.Models;

public partial class Grado
{
    public int IdGrado { get; set; }

    public string? Grado1 { get; set; }

    public string? Seccion { get; set; }

    public string? Turno { get; set; }

    public long? Año { get; set; }

    public virtual ICollection<Alumno> Alumnos { get; set; } = new List<Alumno>();

    public virtual ICollection<Nota> Nota { get; set; } = new List<Nota>();
}
