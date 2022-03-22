using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items.AnnWeapons
{
    [Serializable]
    class AnnFierySword : Sword
    {
        private int bonus;
        public AnnFierySword() : base("item1323")
        {
            StrMod = 20;
            PrMod = 10;
            GoldValue = 1;
            PublicName = "Ann's Fiery Sword";
            PublicTip = "for fire type of damage extra 40% reduction of health damage and then increase cut and crush strength attack about 1/5 of this health damage";
        }

        public override StatPackage ModifyDefensive(StatPackage pack, List<string> otherItems)
        {
            if (pack.DamageType == DmgType.Fire)
            {
                pack.HealthDmg =  60 * pack.HealthDmg / 100;
                bonus = pack.HealthDmg / 5;
            }
            return pack;
        }

        public override StatPackage ModifyOffensive(StatPackage pack, List<string> otherItems)
        {
            if (pack.DamageType == DmgType.Cut || pack.DamageType == DmgType.Crush)
            {
                pack.StrengthDmg = pack.StrengthDmg + bonus;
            }
            return pack;
        }

    }
}
