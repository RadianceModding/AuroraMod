using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Tiles.Parts
{
    public class SoulWelderHead : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Welder Head");
            Tooltip.SetDefault("Used to make a Soul Welder");
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
			recipe.AddIngredient(ItemID.IronBar, 4);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar, 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
        }
    }
}
// ORDER: Weaker - Weak - Average - Medium - Strong - High - Uber - Insane - Galactic - Cosmic