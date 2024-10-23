﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace KioscoInformaticoServices.Models;

public partial class Detallesventa
{
    public int Id { get; set; }

    public int VentaId { get; set; }

    public int ProductoId { get; set; }

    public int Cantidad { get; set; }

    public decimal PrecioUnitario { get; set; }

    public virtual Producto Producto { get; set; } = null!;

    public virtual Venta Venta { get; set; } = null!;

    public bool Eliminado { get; set; } = false;

    [NotMapped]
    public decimal SubTotal => Cantidad * PrecioUnitario;
}
