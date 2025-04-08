﻿using System;
using System.Collections.Generic;

namespace firstDay.Server.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public string? ProductDesc { get; set; }

    public decimal Price { get; set; }

    public int Quantity { get; set; }

    public int? CategoryId { get; set; }

    public virtual Category? Category { get; set; }
}
