using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KioscoInformaticoServices.Models;

public partial class Manwha
{
    public int Id { get; set; }
    [Required]
    public string Nombre { get; set; } = null!;

    [Required]
    [DataType(DataType.Currency)]
    [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
    public decimal Capitulos { get; set; }

    public bool Eliminado { get; set; } = false;

    public string Sinopsis { get; set; } = null!;
    public string ImagenUrl { get; set; } = string.Empty;
    public override string ToString()
    {
        return Nombre;
    }

    


}
