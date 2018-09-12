using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Tiles.Crafting
{
    public class PhilAlchCircle : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Alchemic Circle: Philosopher's Stone");
            Tooltip.SetDefault("Can be used to make Philosopher's Stone's, though this is very dark alchemy..." +
			"\nSTILL WIP!");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
		    item.value = 0;
            item.rare = 6;
        }

        public override void AddRecipes()
        {

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SoulWelder"), 1);
			recipe.AddIngredient(mod.GetItem("SoulSplitter"), 1);
			recipe.AddIngredient(ItemID.PhilosophersStone, 4);
			recipe.AddIngredient(mod.GetItem("MobSoulT5"), 16);
			recipe.AddIngredient(mod.GetItem("BossSoul"), 8);
			recipe.AddTile(TileID.MythrilAnvil);
			//recipe.AddTile(TileID.SoulWelder);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
// ORDER: Weaker - Weak - Average - Medium - Strong - High - Uber - Insane - Galactic - Cosmic