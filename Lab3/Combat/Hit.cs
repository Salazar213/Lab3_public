using System;
using System.Collections.Generic;
using System.Text;


namespace Lab3.Combat;

public readonly record struct Hit(int Damage, bool Critical);
