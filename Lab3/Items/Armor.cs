using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Items;

public sealed class Armor : Item
{
    private const double MaxDefense = 0.75;

    private readonly double defense;

    public Armor(string code, string name, int basePrice, double defense)
        : base(code, name, basePrice)
    {
        this.defense = defense;
    }

    private Armor(Armor source)
        : base(source)
    {
        defense = source.defense;
    }

    public double Defense => Math.Min(defense + Enchantments.Sum(enchantment => enchantment.BonusDefense), MaxDefense);

    public override IReadOnlyList<Enchantment> PossibleEnchantments => Enchantment.ForArmor;

    public override string Description => $"защита {Math.Round(Defense * 100)}%";

    public override Armor Copy()
    {
        return new Armor(this);
    }
}
