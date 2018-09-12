using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.PhilStone
{
    public class PhilStoneT2 : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Mudane Philosopher's Stone");
            Tooltip.SetDefault("Can be used for Alchemic purposes" +
			"\nIt seems familiar...");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
			item.value = 0;
            item.rare = 5;
        }

        public override void AddRecipes()
        {

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 250);
			recipe.AddIngredient(ItemID.PhilosophersStone, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			//recipe.AddTile(TileID.PhilAlch);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
        }
    }
}
// ORDER: Weak (Vanilla) - Mudane - Average - Above-Average - Strong - Augmented - Galactic - Cosmic
// Temp until I can figure out how to make it not use the item each time (if possible)
// RARITIES: Vanilla one is 4 (Light Red), this one is 5, total is: 4 (Vanilla) - 5 - 5 - 6 - 6 - 7 - 8 - 9
// Red Stone (this one) is lowest though, for pre-HM