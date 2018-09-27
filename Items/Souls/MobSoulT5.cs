using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Souls
{
    public class MobSoulT5 : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Strong Monster Soul");
            Tooltip.SetDefault("The soul of a once living creature." +
			"\nYou're not sure how you're holding it.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
		    item.value = 0;
            item.rare = 3;
        }

        public override void AddRecipes()
        {

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoulT4"), 8);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
// ORDER: Weaker - Weak - Average - Medium - Strong - High - Uber - Insane - Galactic - Cosmic