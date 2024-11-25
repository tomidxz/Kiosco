using KioscoInformaticoServices.Enums;
using System;
using System.Collections.Generic;

namespace KioscoInformaticoServices.Models;

public partial class Donacion
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public virtual Empleado? Donador { get; set; } = null!;
    public int DonadorId { get; set; }
    public FormaDePagoEnum FormaPago { get; set; }

    public decimal Iva { get; set; }

    public decimal Total { get; set; }

    public bool Eliminado { get; set; } = false;


}
