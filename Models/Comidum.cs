using System;
using System.Collections.Generic;

namespace Veterinaria.Models;

public partial class Comidum
{
    public int IdComida { get; set; }

    public string? NombreProducto { get; set; }

    public string? TipoComida { get; set; }

    public string? Marca { get; set; }

    public int? Precio { get; set; }
}
