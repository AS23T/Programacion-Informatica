using System;
using System.Collections.Generic;

namespace WebApplicationDBFirst.Models;

public partial class Contacto
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public string? Fono { get; set; }
}
