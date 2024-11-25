using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KioscoInformaticoServices.Models;

public partial class Donador
{
    public int Id { get; set; }

    [Required(ErrorMessage ="El campo Nombre debe ser obligatorio")]
    public string Nombre { get; set; } = null!;
    [Required(ErrorMessage = "El campo Direccion debe ser obligatorio")]
    public string Pais { get; set; } = null!;

    public string Telefonos { get; set; } = null!;
    
    public decimal TotalDonado { get; set; }

    public bool Eliminado { get; set; }= false;

    public override string ToString()
    {
        return Nombre;
    }
}
