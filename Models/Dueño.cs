using System;
using System.Collections.Generic;

namespace Veterinaria.Models;

public partial class Dueño
{
    public int IdDueño { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? NumeroTelefonico { get; set; }

    public string? Genero { get; set; }

    public string? NombreMascota { get; set; }

    public string? TipoMacota { get; set; }
}
