using System;
using System.Collections.Generic;

namespace DeberRolesyPerfiles.Models;

public partial class Manga
{
    public string CodManga { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Autor { get; set; }

    public string? Genero { get; set; }

    public DateOnly? FechaCreacion { get; set; }

    public decimal? Precio { get; set; }

    public string? Estado { get; set; }
}
