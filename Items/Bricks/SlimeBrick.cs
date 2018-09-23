using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Bricks
{
    public class SlimeBrick : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Slimy Brick");
            Tooltip.SetDefault("The Third tier of brick" + 
			"\nIt's oozing everywhere..." +
			"\nYou think it can be used as glue");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
			item.value = Item.sellPrice(0, 0, 0, 4);
            item.rare = 0;

        }

        public override void AddRecipes()
        {

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 4);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PinkGel, 2);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SlimeBlock, 4);
			recipe.SetResult(this, 2);
	     	recipe.AddTile(TileID.Solidifier);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FrozenSlimeBlock, 4);
			recipe.SetResult(this, 3);
	     	recipe.AddTile(TileID.Solidifier);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PinkSlimeBlock, 4);
			recipe.SetResult(this, 4);
	     	recipe.AddTile(TileID.Solidifier);
			recipe.AddRecipe();
        }
    }
}