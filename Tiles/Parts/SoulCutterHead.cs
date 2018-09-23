using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Tiles.Parts
{
    public class SoulCutterHead : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Soul Splitter Head");
            Tooltip.SetDefault("Used to make a Soul Splitter" +
			"\nDiamonds, Silver and Souls seem to let you cut through whatever material Souls are made from.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
		    item.value = 0;
            item.rare = -1;
        }

        public override void AddRecipes()
        {

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SilverBar, 4);
			recipe.AddIngredient(ItemID.Diamond, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TungstenBar, 4);
			recipe.AddIngredient(ItemID.Diamond, 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
// ORDER: Weaker - Weak - Average - Medium - Strong - High - Uber - Insane - Galactic - Cosmic