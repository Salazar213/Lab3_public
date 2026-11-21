using System;
using System.Collections.Generic;
using System.Text;
namespace Lab3.Combat;

public interface ICombatant
{
    string Code { get; }

    string Name { get; }

    int Health { get; }

    int MaxHealth { get; }

    bool IsAlive { get; }

    Hit RollDamage();

    int ReceiveHit(int damage);
}