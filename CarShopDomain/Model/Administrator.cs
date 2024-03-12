using System;
using System.Collections.Generic;

namespace CarShopDomain.Model;

public partial class Administrator
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Role { get; set; }

    public byte[]? CreatedAt { get; set; }

    public virtual Product? Product { get; set; }
}
