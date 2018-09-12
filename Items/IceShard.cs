using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items
{
    public class IceShard : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Icy Shard");
            Tooltip.SetDefault("A shard of Ice" +
			"\nRecipe will be changed to NPC drops soon-ish");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
		    item.value = Item.sellPrice(0, 0, 0, 0);
            item.rare = 2;

        }

        public override void AddRecipes()
        {

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 4);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}