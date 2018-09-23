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
			// CRAFTING RECIPE
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 100);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(TileID.PhilAlchCircle);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
			
			
			// USES BELOW
			// Depth Meter
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RedStone"), 5);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 4);
			recipe.AddIngredient(ItemID.IronBar, 4);
			recipe.AddIngredient(ItemID.Chain, 2);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.AlchCircle);
			recipe.SetResult(ItemID.DepthMeter);
			recipe.AddRecipe();
			
			// FISHERMAN'S POCKET GUIDE
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RedStone"), 5);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 4);
			recipe.AddIngredient(ItemID.Silk, 8);
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.AlchCircle);
			recipe.SetResult(ItemID.FishermansGuide);
			recipe.AddRecipe();
			
			// WEATHER RADIO
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RedStone"), 5);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 4);
			recipe.AddIngredient(ItemID.IronBar, 8);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.AlchCircle);
			recipe.SetResult(ItemID.WeatherRadio);
			recipe.AddRecipe();
			
			// SEXTANT
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RedStone"), 5);
			recipe.AddIngredient(mod.GetItem("MobSoul"), 4);
			recipe.AddRecipeGroup("AuroraMod:GoldBar", 4);
			//recipe.AddIngredient(ItemID.GoldBar, 4);
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.AlchCircle);
			recipe.SetResult(ItemID.Sextant);
			recipe.AddRecipe();
			
			// METAL DETECTOR
		    recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RedStone"), 10);
			recipe.AddIngredient(mod.GetItem("MobSoulT2"), 4);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.AlchCircle);
			recipe.SetResult(ItemID.MetalDetector);
			recipe.AddRecipe();
			
			// RADAR
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RedStone"), 10);
			recipe.AddIngredient(mod.GetItem("MobSoulT2"), 4);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.AlchCircle);
			recipe.SetResult(ItemID.Radar);
			recipe.AddRecipe();
        }
    }
}