using System;
using System.Collections.Generic;

namespace FerreteriaApp.Models;

public partial class RedesSociale
{
    public int IdRedSocial { get; set; }

    public string NombreRed { get; set; } = null!;

    public string? Usuario { get; set; }

    public string? LinkRed { get; set; }

    public int IdSucursal { get; set; }

    public virtual Sucursale IdSucursalNavigation { get; set; } = null!;
}
