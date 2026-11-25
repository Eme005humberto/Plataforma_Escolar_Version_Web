using System;
using System.Collections.Generic;

namespace CapaNegocio.Models;

public partial class Materia
{
    public int IdMaterias { get; set; }

    public string? Materia1 { get; set; }

    public virtual ICollection<Alumno> Alumnos { get; set; } = new List<Alumno>();

    public virtual ICollection<Nota> Nota { get; set; } = new List<Nota>();
}
