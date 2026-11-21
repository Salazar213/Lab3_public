using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Enemies;

public sealed class Skeleton : AbstractEnemy
{
    private const double Resistance = 0.3;

    public Skeleton()
        : base("skeleton", "Скелет", 110, 10, 24, 90, 70)
    {
    }

    protected override int ReduceDamage(int damage)
    {
        return (int)Math.Round(damage * (1 - Resistance), MidpointRounding.AwayFromZero);
    }
}
