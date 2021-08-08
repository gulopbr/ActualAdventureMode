using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Collections.Generic;


namespace ActualAdventureMode
{
    public class CustomPlayer : ModPlayer
    {
        public override void SetupStartInventory(IList<Item> items)
        {
                Item item = new Item();
                item.SetDefaults(ItemID.EoCShield);
                item.stack = 1;
                items.Add(item);
            
        }
    }
}

