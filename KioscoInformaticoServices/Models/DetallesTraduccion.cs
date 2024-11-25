using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace KioscoInformaticoServices.Models;

public partial class DetallesTraduccion
{
    public int Id { get; set; }

    public int ManwhasId { get; set; }

    public int? ManwhaId { get; set; }

    public Empleado? EmpleadoEncargado { get; set; }

    public Empleado? EmpleadoTraductor { get; set; }
    public Empleado? EmpleadoTyper { get; set; }
    public Empleado? EmpleadoCleaner { get; set; }
    public int Cantidad { get; set; }

    public int CompraId { get; set; }

    public virtual Manwha? Manwha { get; set; }

    public bool Eliminado { get; set; } = false;

}
