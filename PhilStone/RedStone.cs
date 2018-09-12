using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.PhilStone
{
    public class RedStone : ModItem
    {
        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Red Stone");
            Tooltip.SetDefault("Can be used for Alchemic purposes" +
			"\nNot as powerful as a Philosopher's Stone, but might be able to do something." +
			"\nIt seems familiar...");
        }
		
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 999;
			item.value = 0;
            item.rare = 2;
        }

        public override void AddRecipes()
        {
			// RECIPE
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 100);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(TileID.SoulWelder);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
			
			
			// USES BELOW
			// Depth Meter
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RedStone"), 1);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 1);
			recipe.AddIngredient(ItemID.Chain, 1);
			recipe.AddIngredient(ItemID.SilverCoin, 25);
			recipe.AddIngredient(ItemID.SilverBar, 4);
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.SoulWelder);
			recipe.SetResult(ItemID.DepthMeter);
			recipe.AddRecipe();
			
			// FISHERMAN'S POCKET GUIDE
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RedStone"), 2);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 4);
			recipe.AddIngredient(ItemID.Silk, 1);
			recipe.AddIngredient(ItemID.GoldCoin, 1);
			recipe.AddIngredient(ItemID.SilverCoin, 4);
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.SoulWelder);
			recipe.SetResult(ItemID.FishermansGuide);
			recipe.AddRecipe();
			
			// WEATHER RADIO
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RedStone"), 2);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 4);
			recipe.AddIngredient(ItemID.IronBar, 4);
			recipe.AddIngredient(ItemID.GoldCoin, 1);
			recipe.AddIngredient(ItemID.SilverCoin, 4);
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.SoulWelder);
			recipe.SetResult(ItemID.WeatherRadio);
			recipe.AddRecipe();
			
			// SEXTANT
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RedStone"), 2);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 4);
			recipe.AddIngredient(ItemID.GoldBar, 4);
			recipe.AddIngredient(ItemID.GoldCoin, 1);
			recipe.AddIngredient(ItemID.SilverCoin, 4);
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.SoulWelder);
			recipe.SetResult(ItemID.Sextant);
			recipe.AddRecipe();
        }
    }
}
// ORDER: Weak (Vanilla) - Mudane - Average - Above-Average - Strong - Augmented - Galactic - Cosmic
// Temp until I can figure out how to make it not use the item each time (if possible)
// RARITIES: Vanilla one is 4 (Light Red), this one is 5, total is: 4 (Vanilla) - 5 - 5 - 6 - 6 - 7 - 8 - 9
// Red Stone (this one) is lowest though, for pre-HM