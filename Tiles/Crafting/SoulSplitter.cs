using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Tiles.Crafting
{
    public class SoulSplitter : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Soul Splitter");
            Tooltip.SetDefault("Lets you split Souls into lower-tier verions" +
			"\nSTILL WIP!");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
		    item.value = 0;
            item.rare = 2;
        }

        public override void AddRecipes()
        {

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoulT2"), 8);
			recipe.AddIngredient(mod.GetItem("MobSoulT3"), 4);
			recipe.AddIngredient(mod.GetItem("SoulCutterHead"), 1);
			recipe.AddIngredient(ItemID.Furnace, 1);
			recipe.AddIngredient(ItemID.Wood, 16);
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.SoulWelder);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
// ORDER: Weaker - Weak - Average - Medium - Strong - High - Uber - Insane - Galactic - Cosmic