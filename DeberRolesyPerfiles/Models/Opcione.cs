using System;
using System.Collections.Generic;

namespace DeberRolesyPerfiles.Models;

public partial class Opcione
{
    public int Id { get; set; }

    public string? Descripcion { get; set; }

    public string? NombreFormulario { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<OpcionesXRole> OpcionesXRoles { get; set; } = new List<OpcionesXRole>();
}
