using KioscoInformaticoServices.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KioscoInformaticoServices.Models;

public partial class Empleado
{
    public int Id { get; set; }

    [Required(ErrorMessage ="El campo Nombre debe ser obligatorio")]
    public string Nombre { get; set; } = null!;
    [Required(ErrorMessage = "El campo Direccion debe ser obligatorio")]
    public string Direccion { get; set; } = null!;

    public string Telefonos { get; set; } = null!;
    public PuestoEmpleadoEnum PuestoEmpleado { get; set; }

    public DateTime FechaNacimiento { get; set; }


    [Required(ErrorMessage = "El campo Direccion debe ser obligatorio")]

    public string Correo { get; set; } = null!;

    public bool Eliminado { get; set; }= false;

    public override string ToString()
    {
        return Nombre;
    }
}
