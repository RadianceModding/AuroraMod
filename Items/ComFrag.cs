using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items
{
    public class ComFrag : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Compressed Fragments");
            Tooltip.SetDefault("This was a terrible idea...");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
		    item.value = Item.sellPrice(0, 0, 0, 0);
            item.rare = 10;

        }

        public override void AddRecipes()
        {

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar, 4);
			recipe.AddIngredient(ItemID.FragmentVortex, 4);
			recipe.AddIngredient(ItemID.FragmentNebula, 4);
			recipe.AddIngredient(ItemID.FragmentStardust, 4);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
        }
    }
}