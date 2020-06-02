using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items
{
    public class ConMoon : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Concentrated Moonbeams");
            Tooltip.SetDefault("You think this was a bad idea...");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
		    item.value = Item.sellPrice(0, 0, 50, 0);
            item.rare = 3;

        }

        public override void AddRecipes()
        {

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}