using System;
using System.Collections.Generic;
using System.Text;

using Lab3.Core;

namespace Lab3.World;

public sealed class LocationRegistry
{
    private readonly List<Location> locations;

    public LocationRegistry(IEnumerable<Location> locations)
    {
        this.locations = locations.ToList();
    }

    public IReadOnlyList<Location> All => locations.AsReadOnly();

    public Location Get(string code)
    {
        return locations.FirstOrDefault(location => location.Code == code)
            ?? throw new UnknownCodeException("Локация", code);
    }
}