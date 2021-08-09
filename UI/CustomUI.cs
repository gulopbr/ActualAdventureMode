using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.UI;

namespace ActualAdventureMode.UI {

    internal class CustomUI : UIState
    {
        public static bool visible = true;
        protected override void DrawSelf(SpriteBatch spriteBatch)
        {
            base.DrawSelf(spriteBatch);

            Main.HidePlayerCraftingMenu = true;
        
        
        }
    }
}