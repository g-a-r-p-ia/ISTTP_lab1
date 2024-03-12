using System;
using System.Collections.Generic;

namespace CarShopDomain.Model;

public partial class Basket
{
    public int Id { get; set; }

    public int? UsserId { get; set; }

    public int? ProductId { get; set; }

    public virtual User Id1 { get; set; } = null!;

    public virtual Product IdNavigation { get; set; } = null!;
}
