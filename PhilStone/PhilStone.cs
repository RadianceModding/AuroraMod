using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.PhilStone
{
    public class PhilStone : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Philosopher's Stone");
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
			recipe.AddIngredient(mod.GetItem("RedStone"), 25);
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.PhilAlchCircle);
			recipe.SetResult(this, 100);
			recipe.AddRecipe();
        }
    }
}