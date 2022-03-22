using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Engine.Items.AnnWeapons
{
    [Serializable]
    class AnnShuriken : Item
    {
        public AnnShuriken() : base("item1320")
        {
            StrMod = 5;
            PrMod = 10;
            GoldValue = 1;
            PublicName = "Ann's Shuriken";
            PublicTip = "precision depends on health; \n if you have Ann's Poison, it's buffs are added;";
        }

        public override void ApplyBuffs(Engine.CharacterClasses.Player currentPlayer, List<string> otherItems)
        {
            AnnPoison poison1 = new AnnPoison();

            if (otherItems.Contains(poison1.Name))
            {
                currentPlayer.StrengthBuff += poison1.StrMod + StrMod;
                currentPlayer.PrecisionBuff += PrMod * currentPlayer.Health / 100 + poison1.PrMod;
            }
            else
            {
                currentPlayer.StrengthBuff += StrMod;
                currentPlayer.PrecisionBuff += PrMod * currentPlayer.Health / 100;
            }
        }
    }
}
