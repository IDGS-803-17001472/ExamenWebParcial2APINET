using System;
using System.Collections.Generic;

namespace APITienda.Models;

public partial class Teni
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public decimal? Precio { get; set; }

    public string? Categoria { get; set; }

    public string? Imagen { get; set; }
    public string? Descripcion { get; set; }
}
