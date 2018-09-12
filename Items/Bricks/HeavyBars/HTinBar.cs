using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Bricks.HeavyBars
{
    public class HTinBar : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Heavy Tin Bar");
            Tooltip.SetDefault("The First Tier of Heavy Bars" + 
			"\nYou've figured out how to compress tin bars into a more condensed version");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
		    item.value = Item.sellPrice(0, 0, 6, 0);
            item.rare = 1;

        }

        public override void AddRecipes()
        {
			
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBar, 4);
			recipe.AddIngredient(mod.GetItem("SlimeBrick"), 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}