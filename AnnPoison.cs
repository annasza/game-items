using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items.AnnWeapons
{
    [Serializable]
    class AnnPoison : Item
    {
        public AnnPoison() : base("item1321")
        {
            StrMod = 10;
            PrMod = 10;
            GoldValue = 1;
            PublicName = "Ann's Poison";
        }

    }
}
