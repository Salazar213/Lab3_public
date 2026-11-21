using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Combat;
public sealed record BattleEvent(int Round, EventType Type, Side Source, Side Target, int Amount, int TargetHealthAfter);
