using KioscoInformaticoServices.Enums;
using System;
using System.Collections.Generic;

namespace KioscoInformaticoServices.Models;

public partial class Solicitud
{
    public int Id { get; set; }

    public string ManwhaPedido { get; set; } = null!;
    public DateTime Fecha { get; set; }
    public bool Eliminado { get; set; } = false;
}
