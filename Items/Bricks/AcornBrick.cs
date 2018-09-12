using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Bricks
{
    public class AcornBrick : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Acorn Brick");
            Tooltip.SetDefault("The First Tier of materials" + 
			"\nYou've figured out how to compress acorns into a brick");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
		    item.value = Item.sellPrice(0, 0, 0, 8);
            item.rare = 0;

        }

        public override void AddRecipes()
        {

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Acorn, 4);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}