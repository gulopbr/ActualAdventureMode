using Terraria.ModLoader;
using ActualAdventureMode.UI;
using Terraria;
using Terraria.UI;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace ActualAdventureMode
{
    public class ActualAdventureMode : Mod
    {
        private UserInterface customInterface;
        internal CustomUI CustomUI;

        public override void Load()
        {
            // Only run the below code if we're not loading on a server
            if (!Main.dedServ)
            {
                // Custom UI
                CustomUI = new CustomUI();
                CustomUI.Activate();
                customInterface = new UserInterface();
                customInterface.SetState(CustomUI);
            }
        }

        // Boilerplate necessary to run custom mod interface
        public override void UpdateUI(GameTime gameTime)
        {
            customInterface?.Update(gameTime);
        }

        // Boilerplate necessary to run custom mod interface
        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            int inventoryIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Inventory"));
            if (inventoryIndex != -1)
            {
                layers.Insert(inventoryIndex, new LegacyGameInterfaceLayer(
                    "Actual Adventure Mode: Crafting UI remover",
                    delegate
                    {
                        customInterface.Draw(Main.spriteBatch, new GameTime());
                        return true;
                    },
                    InterfaceScaleType.UI)
                );
            }
        }
        }
}