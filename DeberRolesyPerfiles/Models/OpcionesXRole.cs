using System;
using System.Collections.Generic;

namespace DeberRolesyPerfiles.Models;

public partial class OpcionesXRole
{
    public int Id { get; set; }

    public int? IdOpcion { get; set; }

    public int? IdRol { get; set; }

    public string? Estado { get; set; }

    public virtual Opcione? IdOpcionNavigation { get; set; }

    public virtual Role? IdRolNavigation { get; set; }
}
