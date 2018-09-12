using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Tiles.Crafting
{
    public class AlchCircleItems : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Alchemic Circle: Alchemy");
            Tooltip.SetDefault("Can be used to make various items using alchemy" +
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
			recipe.AddIngredient(mod.GetItem("MobSoulT2"), 10);
			recipe.AddIngredient(mod.GetItem("RedStone"), 8);
			recipe.AddIngredient(mod.GetItem("SoulCutterHead"), 1);
			recipe.AddIngredient(mod.GetItem("SoulWelderHead"), 1);
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.SoulWelder);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			/* HARDMODE RECIPE (STILL WIP, BUT WILL UPGRADE IT)
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("AlchCircleItems"), 1);
			recipe.AddIngredient(mod.GetItem("SoulWelderHead"), 1);
			recipe.AddIngredient(ItemID.PhilosophersStone, 4);
			recipe.AddTile(TileID.MythrilAnvil);
			//recipe.AddTile(TileID.PhilAlchCircle);
			recipe.SetResult(this);
			recipe.AddRecipe();
			*/
        }
    }
}
// ORDER: Weaker - Weak - Average - Medium - Strong - High - Uber - Insane - Galactic - Cosmic