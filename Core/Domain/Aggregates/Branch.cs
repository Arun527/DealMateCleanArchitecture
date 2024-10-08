﻿using Common.Attributes;

namespace Core.Domain.Aggregates;

public class Branch
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int DealerId { get; set; }

    [Include]
    public Dealer? Dealer { get; set; }
}

