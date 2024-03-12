using System;
using System.Collections.Generic;

namespace CarShopDomain.Model;

public partial class Product
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool? Availability { get; set; }

    public byte[]? CreatedAt { get; set; }

    public string? Info { get; set; }

    public int? CategoryId { get; set; }

    public int? CreatedBy { get; set; }

    public virtual Basket? Basket { get; set; }

    public virtual Category Id1 { get; set; } = null!;

    public virtual Administrator IdNavigation { get; set; } = null!;

    public virtual ProductList? ProductList { get; set; }
}
