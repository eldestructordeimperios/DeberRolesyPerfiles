using System;
using System.Collections.Generic;

namespace DeberRolesyPerfiles.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string? Contrasena { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<UsuarioXRole> UsuarioXRoles { get; set; } = new List<UsuarioXRole>();
}
