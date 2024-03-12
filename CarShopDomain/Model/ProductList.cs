using System;
using System.Collections.Generic;

namespace CarShopDomain.Model;

public partial class ProductList
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public int? CategoryId { get; set; }

    public virtual Product Id1 { get; set; } = null!;

    public virtual Category IdNavigation { get; set; } = null!;
}
