﻿using KioscoInformaticoServices.Enums;
using System;
using System.Collections.Generic;

namespace KioscoInformaticoServices.Models;

public partial class Compra
{
    public int Id { get; set; }

    public FormaDePagoEnum FormaDePago { get; set; }

    public CondicionIvaEnum Iva { get; set; }

    public int Total { get; set; }

    public DateTime Fecha { get; set; }

    public int? ProveedorId { get; set; }

    public virtual Proveedor? Proveedor { get; set; }
}
