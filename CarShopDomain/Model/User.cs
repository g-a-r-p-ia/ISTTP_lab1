using System;
using System.Collections.Generic;

namespace CarShopDomain.Model;

public partial class User
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Address { get; set; }

    public byte[]? CreatedAt { get; set; }

    public virtual Basket? Basket { get; set; }
}
