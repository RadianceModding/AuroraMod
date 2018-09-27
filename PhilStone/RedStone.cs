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
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
			
			// FISHERMAN'S POCKET GUIDE
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RedStone"), 20);
			recipe.AddIngredient(ItemID.Silk, 8);
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.AlchCircle);
			recipe.SetResult(ItemID.FishermansGuide);
			recipe.AddRecipe();
			
			// WEATHER RADIO
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RedStone"), 20);
			recipe.AddIngredient(ItemID.IronBar, 8);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.AlchCircle);
			recipe.SetResult(ItemID.WeatherRadio);
			recipe.AddRecipe();
			
			// SEXTANT
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RedStone"), 20);
			//recipe.AddRecipeGroup("AuroraMod:GoldBar", 4);
			recipe.AddIngredient(ItemID.GoldBar, 4);
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.AlchCircle);
			recipe.SetResult(ItemID.Sextant);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RedStone"), 20);
			//recipe.AddRecipeGroup("AuroraMod:GoldBar", 4);
			recipe.AddIngredient(ItemID.PlatinumBar, 4);
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.AlchCircle);
			recipe.SetResult(ItemID.Sextant);
			recipe.AddRecipe();
			
			// METAL DETECTOR
		    recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RedStone"), 16);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.AlchCircle);
			recipe.SetResult(ItemID.MetalDetector);
			recipe.AddRecipe();
		 
			// RADAR
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RedStone"), 8);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.AlchCircle);
			recipe.SetResult(ItemID.Radar);
			recipe.AddRecipe();
			
			// DEPTH METER
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RedStone"), 12);
			recipe.AddIngredient(ItemID.IronBar, 4);
			recipe.AddIngredient(ItemID.Chain, 2);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.AlchCircle);
			recipe.SetResult(ItemID.DepthMeter);
			recipe.AddRecipe();
			
			// COMPASS
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RedStone"), 12);
			recipe.AddIngredient(ItemID.IronBar, 4);
			recipe.AddIngredient(ItemID.GoldBar, 2);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.AlchCircle);
			recipe.SetResult(ItemID.Compass);
			recipe.AddRecipe();
			
			// TALLY COUNTER
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RedStone"), 12);
			recipe.AddIngredient(ItemID.IronBar, 16);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.AlchCircle);
			recipe.SetResult(ItemID.TallyCounter);
			recipe.AddRecipe();
			
			// STOPWATCH
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RedStone"), 50);
			recipe.AddIngredient(ItemID.IronBar, 8);
			recipe.AddIngredient(ItemID.SilverBar, 8);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.AlchCircle);
			recipe.SetResult(ItemID.Stopwatch);
			recipe.AddRecipe();
			
			// DPS METER
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RedStone"), 50);
			recipe.AddIngredient(ItemID.SilverBar, 8);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.AlchCircle);
			recipe.SetResult(ItemID.DPSMeter);
			recipe.AddRecipe();
			
			// LIFEFORM ANALYZER
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RedStone"), 50);
			recipe.AddIngredient(ItemID.IronBar, 12);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.AlchCircle);
			recipe.SetResult(ItemID.LifeformAnalyzer);
			recipe.AddRecipe();
        }
    }
}
// Red Stone Costs: 8 for looted (Like Radar), 12 for dropped (Like Depth Meter), 20 for Fishing (Given by the angler), 50 for Travelling Merchant ones
// Metal Detector is the exception though as it's rare, so it costs 16 Souls
// Can't craft the crafted/bought ones as you can already obtain them fairly easily