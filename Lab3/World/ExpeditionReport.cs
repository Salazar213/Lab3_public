using System;
using System.Collections.Generic;
using System.Text;

using Lab3.Combat;

namespace Lab3.World;

public sealed record ExpeditionReport(int Seed, string LocationCode, BattleReport Battle, Rewards Rewards);
