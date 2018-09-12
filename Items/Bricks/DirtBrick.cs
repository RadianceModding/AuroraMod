using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Bricks
{
    public class DirtBrick : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Dirt Brick");
            Tooltip.SetDefault("The Worst [-1] brick of all!" + 
			"\nit's really, REALLY dirty..." +
			"\nit's more of a mound than a brick...");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
		    item.value = Item.sellPrice(0, 0, 0, 0);
            item.rare = -1;

        }

        public override void AddRecipes()
        {

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 4);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}