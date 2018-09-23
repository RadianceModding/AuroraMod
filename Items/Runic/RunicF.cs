using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Runic
{
    public class RunicF : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Runic Letter");
            Tooltip.SetDefault("A rune written in stone that might be a letter.\nYou're not sure how you made it, you just knew how...\nPossibly translates to 'F'");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
            item.rare = 1;

        }

        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RuneInscriber"), 1);
			recipe.AddIngredient(ItemID.StoneBlock, 6);
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.RunicInscriber);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}