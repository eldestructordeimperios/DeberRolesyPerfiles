using System;
using System.Collections.Generic;

namespace DeberRolesyPerfiles.Models;

public partial class UsuarioXRole
{
    public int Id { get; set; }

    public int? IdUsuario { get; set; }

    public int? IdRol { get; set; }

    public string? Estado { get; set; }

    public virtual Role? IdRolNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
