using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Bricks
{
    public class StoneBrick : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Stone Brick");
            Tooltip.SetDefault("The Fourth Tier of bricks" + 
			"\nYou've figured out how to compress stone into a brick" + 
			 "\nimpressive too, since all you had was a bench");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
		    item.value = Item.sellPrice(0, 0, 0, 0);
            item.rare = 0;

        }

        public override void AddRecipes()
        {

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StoneBlock, 4);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}