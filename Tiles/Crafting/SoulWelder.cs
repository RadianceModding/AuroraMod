using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Tiles.Crafting
{
    public class SoulWelder : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Soul Welder");
            Tooltip.SetDefault("Used to empower and combine Souls" +
			"\nSTILL WIP!");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
		    item.value = 0;
            item.rare = 1;
        }

        public override void AddRecipes()
        {

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 8);
			recipe.AddIngredient(mod.GetItem("MobSoulT2"), 4);
			recipe.AddIngredient(mod.GetItem("SoulWelderHead"), 1);
			recipe.AddIngredient(ItemID.IronAnvil, 1);
			recipe.AddIngredient(ItemID.Furnace, 1);
			recipe.AddIngredient(ItemID.Wood, 16);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 8);
			recipe.AddIngredient(mod.GetItem("MobSoulT2"), 4);
			recipe.AddIngredient(mod.GetItem("SoulWelderHead"), 1);
			recipe.AddIngredient(ItemID.LeadAnvil, 1);
			recipe.AddIngredient(ItemID.Furnace, 1);
			recipe.AddIngredient(ItemID.Wood, 16);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
// ORDER: Weaker - Weak - Average - Medium - Strong - High - Uber - Insane - Galactic - Cosmic