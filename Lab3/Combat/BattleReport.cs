using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Combat;
public sealed record BattleReport(Participant Hero, Participant Enemy, Outcome Outcome, IReadOnlyList<BattleEvent> Events);
