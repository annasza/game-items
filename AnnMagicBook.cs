using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items.AnnWeapons
{
    [Serializable]
    class AnnMagicBook : Staff
    {
        private int magicPowerAbsorption;
        public AnnMagicBook() : base("item1322")
        {
            MgcMod = 20;
            PrMod = 10;
            GoldValue = 1; // 20;
            PublicName = "Ann's Magic Book";
            PublicTip = "absorbs 50% of magic damage and adds it to magic attack";
        }
        
        public override StatPackage ModifyOffensive(StatPackage pack, List<string> otherItems)
        {
            if (DmgTest.Magic(pack.DamageType))
            {
                pack.MagicPowerDmg += magicPowerAbsorption;
            }
            return pack;
        }
        public override StatPackage ModifyDefensive(StatPackage pack, List<string> otherItems)
        {
            if (DmgTest.Magic(pack.DamageType))
            {
                magicPowerAbsorption = pack.MagicPowerDmg / 2;
            }
            return pack;
        }
    }
}
