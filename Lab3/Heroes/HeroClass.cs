using System;
using System.Collections.Generic;
using System.Text;

using Lab3.Core;
using Lab3.Items;
using Lab3.Kits;

namespace Lab3.Heroes;


public sealed class HeroClass
{
    public static readonly HeroClass Warrior = new("warrior", "Воин", 120, catalog => new WarriorKitFactory(catalog));
    public static readonly HeroClass Ranger = new("ranger", "Следопыт", 100, catalog => new RangerKitFactory(catalog));
    public static readonly HeroClass Mage = new("mage", "Маг", 85, catalog => new MageKitFactory(catalog));

    public static readonly IReadOnlyList<HeroClass> Values = [Warrior, Ranger, Mage];

    private readonly Func<ItemCatalog, IStarterKitFactory> starterKit;

    private HeroClass(string code, string displayName, int baseHealth, Func<ItemCatalog, IStarterKitFactory> starterKit)
    {
        Code = code;
        DisplayName = displayName;
        BaseHealth = baseHealth;
        this.starterKit = starterKit;
    }

    public string Code { get; }

    public string DisplayName { get; }

    public int BaseHealth { get; }

    public static HeroClass ByCode(string code)
    {
        return Values.FirstOrDefault(heroClass => heroClass.Code == code)
            ?? throw new UnknownCodeException("Класс героя", code);
    }

    public IStarterKitFactory GetStarterKit(ItemCatalog catalog)
    {
        return starterKit(catalog);
    }
}