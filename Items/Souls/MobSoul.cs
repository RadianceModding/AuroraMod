using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Souls
{
    public class MobSoul : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Weak Monster Soul");
            Tooltip.SetDefault("The soul of a once living creature." +
			"\nIt seems you can combine it with various materials and a special stones to make items..." +
			"\nYou're not sure how you're holding it.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
		    item.value = 0;
            item.rare = 0;
        }

        public override void AddRecipes()
        {

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("BossSoul"), 1);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this, 16);
			recipe.AddRecipe();
        }
    }
}
// ORDER: Weaker - Weak - Average - Medium - Strong - High - Uber - Insane - Galactic - Cosmic