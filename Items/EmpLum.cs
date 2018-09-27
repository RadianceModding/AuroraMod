using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items
{
    public class EmpLum : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Empowered Luminite");
            Tooltip.SetDefault("This was a terrible idea.\nWill most definitly backfire.");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
		    item.value = Item.sellPrice(0, 25, 0, 0);
            item.rare = 11;

        }

        public override void AddRecipes()
        {

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LunarBar, 4);
			recipe.AddIngredient(ItemID.SoulofFlight, 4);
			recipe.AddIngredient(ItemID.SoulofLight, 4);
			recipe.AddIngredient(ItemID.SoulofNight, 4);
			recipe.AddIngredient(ItemID.SoulofSight, 4);
			recipe.AddIngredient(ItemID.SoulofMight, 4);
			recipe.AddIngredient(ItemID.SoulofFright, 4);
			recipe.AddIngredient(ItemID.FragmentSolar, 4);
			recipe.AddIngredient(ItemID.FragmentVortex, 4);
			recipe.AddIngredient(ItemID.FragmentNebula, 4);
			recipe.AddIngredient(ItemID.FragmentStardust, 4);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this, 8);
			recipe.AddRecipe();
        }
    }
}