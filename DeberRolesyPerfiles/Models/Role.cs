using System;
using System.Collections.Generic;

namespace DeberRolesyPerfiles.Models;

public partial class Role
{
    public int Id { get; set; }

    public string? Codigo { get; set; }

    public string? Descripcion { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<OpcionesXRole> OpcionesXRoles { get; set; } = new List<OpcionesXRole>();

    public virtual ICollection<UsuarioXRole> UsuarioXRoles { get; set; } = new List<UsuarioXRole>();
}
