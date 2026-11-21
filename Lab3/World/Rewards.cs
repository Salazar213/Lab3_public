using System;
using System.Collections.Generic;
using System.Text;

using Lab3.Items;

namespace Lab3.World;


public sealed record Rewards(int Experience, int Gold, Item? Loot, int LevelsGained);
