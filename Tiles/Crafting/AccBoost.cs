using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Tiles.Crafting
{
    public class AccBoost : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Essence Booster");
            Tooltip.SetDefault("Can empower Essences with extra energy" +
			"\nDiamonds, Silver and Souls seem to let you cut through whatever material Souls are made from.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 1;
		    item.value = 0;
            item.rare = 2;
        }

        public override void AddRecipes()
        {

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ruby, 3);
			recipe.AddIngredient(mod.GetItem("MobSoulT2"), 4);
			recipe.AddIngredient(mod.GetItem("SoulWelder"), 1);
			recipe.AddIngredient(mod.GetItem("SoulSplitter"), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
// ORDER: Weaker - Weak - Average - Medium - Strong - High - Uber - Insane - Galactic - Cosmic