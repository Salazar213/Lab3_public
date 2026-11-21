using System;
using System.Collections.Generic;
using System.Text;

using Lab3.Combat;

namespace Lab3.Enemies;

public interface IEnemy : ICombatant
{
    int ExperienceReward { get; }

    int RollGoldReward();
}