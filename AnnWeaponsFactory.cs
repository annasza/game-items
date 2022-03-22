using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Engine.Items.AnnWeapons;

namespace Game.Engine.Items.ItemFactories
{
    [Serializable]
    class AnnWeaponsFactory : ItemFactory
    {

        public Item CreateItem()
        {
            List<Item> AnnWeapons = new List<Item>()
            {
                new AnnFierySword(),
                new AnnMagicBook(),
                new AnnPoison(),
                new AnnShuriken()
            };
            return AnnWeapons[Index.RNG(0, AnnWeapons.Count)];
        }
        public Item CreateNonMagicItem()
        {
            List<Item> AnnWeapons = new List<Item>()
            {
                new AnnFierySword(),
                new AnnPoison(),
                new AnnShuriken()
            };
            return AnnWeapons[Index.RNG(0, AnnWeapons.Count)];
        }
        public Item CreateNonWeaponItem()
        {
            List<Item> AnnWeapons = new List<Item>()
            {
                new AnnMagicBook(),
                new AnnPoison(),
            };
            return AnnWeapons[Index.RNG(0, AnnWeapons.Count)];
        }
    }
}
