using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Weapons
{
	public class HellsWrath : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Satan's Wrath");
			Tooltip.SetDefault("Forged from the fires of Hell, this weapon holds immense power." +
			"\nBut it may be cursed.");
		}
		public override void SetDefaults()
		{
			item.damage = 666;
			item.crit = 62;
			item.melee = true;
			item.width = 40;
			item.height = 75;
			item.useTime = 15;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = Item.sellPrice(0, 25, 0, 0);
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;	
			//item.pentration = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Meowmere, 1);
			recipe.AddIngredient(mod.GetItem("ConMoon"), 1);
			recipe.AddIngredient(ItemID.LunarBar, 15);
			recipe.AddIngredient(ItemID.FragmentSolar, 10);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
