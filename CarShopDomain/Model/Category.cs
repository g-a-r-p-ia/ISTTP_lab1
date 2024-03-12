using System;
using System.Collections.Generic;

namespace CarShopDomain.Model;

public partial class Category
{
    public int Id { get; set; }

    public string? Category1 { get; set; }

    public string? Info { get; set; }

    public int? ProductId { get; set; }

    public virtual Product? Product { get; set; }

    public virtual ProductList? ProductList { get; set; }
}
