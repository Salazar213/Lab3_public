using System;
using System.Collections.Generic;
using System.Text;

using Lab3.Items;

namespace Lab3.Kits;

public interface IStarterKitFactory
{
    Weapon CreateWeapon();

 
    Armor CreateArmor();
}
