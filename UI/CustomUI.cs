using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.UI;

namespace ActualAdventureMode.UI {

    internal class CustomUI : UIState
    {
        protected override void DrawSelf(SpriteBatch spriteBatch)
        {
            base.DrawSelf(spriteBatch);

            // Allows mod to hide crafting menu, thanks to this recent update https://github.com/tModLoader/tModLoader/issues/476
            Main.HidePlayerCraftingMenu = true;
        }
    }
}