using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Runic
{
    public class RuneInscriber : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Runic Inscriber");
            Tooltip.SetDefault("A tool that can be used to turn Stone Blocks into language.\nInteresting...");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.scale = 1.0F;
			item.rare = 0;
        }

        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 25);
			recipe.anyWood = true;
			recipe.AddIngredient(ItemID.StoneBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
        }
    }
}