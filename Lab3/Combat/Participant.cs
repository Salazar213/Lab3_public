using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Combat;

public sealed record Participant(string Code, string Name, int MaxHealth)
{
    public static Participant Of(ICombatant combatant)
    {
        return new Participant(combatant.Code, combatant.Name, combatant.MaxHealth);
    }
}