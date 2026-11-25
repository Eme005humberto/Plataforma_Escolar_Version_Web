using System;
using System.Collections.Generic;

namespace CapaNegocio.Models;

public partial class Alumno
{
    public int IdAlumno { get; set; }

    public int? NumeroLista { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public int? IdGrado { get; set; }

    public int? IdMateria { get; set; }

    public virtual Grado? IdGradoNavigation { get; set; }

    public virtual Materia? IdMateriaNavigation { get; set; }

    public virtual ICollection<Nota> Nota { get; set; } = new List<Nota>();
}
