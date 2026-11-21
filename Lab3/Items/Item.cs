using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3.Items;

public abstract class Item
{
    private readonly List<Enchantment> enchantments;

    protected Item(string code, string name, int basePrice)
    {
        Code = code;
        Name = name;
        BasePrice = basePrice;
        enchantments = new List<Enchantment>();
    }

    protected Item(Item source)
    {
        Code = source.Code;
        Name = source.Name;
        BasePrice = source.BasePrice;
        enchantments = new List<Enchantment>(source.enchantments);
    }

    // код шаблона, из которого получен предмет
    public string Code { get; }

    public string Name { get; }

    private int BasePrice { get; }

    public int Price => BasePrice + enchantments.Sum(enchantment => enchantment.BonusPrice);

    public IReadOnlyList<Enchantment> Enchantments => enchantments.AsReadOnly();

    public abstract IReadOnlyList<Enchantment> PossibleEnchantments { get; }

    public abstract string Description { get; }

    public abstract Item Copy();

    public void Enchant(Enchantment enchantment)
    {
        if (!PossibleEnchantments.Contains(enchantment))
        {
            throw new ArgumentException($"Зачарование '{enchantment.Name}' не подходит для предмета '{Name}'");
        }

        enchantments.Add(enchantment);
    }
}
