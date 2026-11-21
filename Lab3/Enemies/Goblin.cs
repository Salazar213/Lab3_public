using System;
using System.Collections.Generic;
using System.Text;
namespace Lab3.Enemies;

public sealed class Goblin : AbstractEnemy
{
    public Goblin()
        : base("goblin", "Гоблин", 50, 6, 14, 40, 30)
    {
    }
}
