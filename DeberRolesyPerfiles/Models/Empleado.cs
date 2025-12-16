using System;
using System.Collections.Generic;

namespace DeberRolesyPerfiles.Models;

public partial class Empleado
{
    public string Cedula { get; set; } = null!;

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string? Direccion { get; set; }

    public DateOnly? FechaNacimineto { get; set; }

    public decimal? Sueldo { get; set; }

    public string? Estado { get; set; }
}
