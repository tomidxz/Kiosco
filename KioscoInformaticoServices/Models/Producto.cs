﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KioscoInformaticoServices.Models;

public partial class Producto
{
    public int Id { get; set; }
    [Required]
    public string Nombre { get; set; } = null!;
    [Required]
    public decimal Precio { get; set; }

    public virtual ICollection<Detallescompra> Detallescompras { get; set; } = new List<Detallescompra>();

    public virtual ICollection<Detallesventa> Detallesventa { get; set; } = new List<Detallesventa>();
}
