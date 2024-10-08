﻿using KioscoInformaticoServices.Enums;
using System;
using System.Collections.Generic;

namespace KioscoInformaticoServices.Models;

public partial class Proveedor

{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Telefonos { get; set; } = null!;

    public string Cbu { get; set; } = null!;

    public CondicionIvaEnum CondicionIva { get; set; }

    public int? LocalidadId { get; set; }


    public virtual Localidad? Localidad { get; set; }

    public bool Eliminado { get; set; } = false;
}
