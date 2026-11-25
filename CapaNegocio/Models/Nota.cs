using System;
using System.Collections.Generic;

namespace CapaNegocio.Models;

public partial class Nota
{
    public int IdNota { get; set; }

    public int? IdMateria { get; set; }

    public int? IdGrado { get; set; }

    public int? IdAlumno { get; set; }

    public int? Evaluacion1 { get; set; }

    public int? Evaluacion2 { get; set; }

    public int? Evaluacion3 { get; set; }

    public int? PromedioFinal { get; set; }

    public TimeOnly? FechaRegistro { get; set; }

    public virtual Alumno? IdAlumnoNavigation { get; set; }

    public virtual Grado? IdGradoNavigation { get; set; }

    public virtual Materia? IdMateriaNavigation { get; set; }
}
