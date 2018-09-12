using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Bricks
{
    public class WoodBrick : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Wood Brick");
            Tooltip.SetDefault("The Second Tier of bricks" + 
			"\nYou've figured out how to compress wood into more wood" + 
			 "\nwait a minute...");
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
			recipe.AddIngredient(ItemID.Wood, 4);
			recipe.anyWood = true;
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}