using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Weapons
{
	public class EmpLumSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Empowered Luminite Sword");
			Tooltip.SetDefault("Forged from the very soul of the Moon Lord, this weapon holds immense power." +
			"\nBut it is definitely cursed.");
		}
		public override void SetDefaults()
		{
			item.damage = 2500;
			item.crit = 86;
			item.melee = true;
			item.width = 60;
			item.height = 90;
			item.useTime = 10;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 20;
			item.value = Item.sellPrice(0, 50, 0, 0);
			item.rare = 11;
			item.expert = true;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PortalGun, 1);
			recipe.AddIngredient(ItemID.Meowmere, 1);
			recipe.AddIngredient(ItemID.StarWrath, 1);
			recipe.AddIngredient(ItemID.Terrarian, 1);
			recipe.AddIngredient(ItemID.GravityGlobe, 1);
			recipe.AddIngredient(ItemID.LunarBar, 25);
			recipe.AddIngredient(mod.GetItem("ComFrag"), 4);
			recipe.AddIngredient(mod.GetItem("EmpLum"), 8);
			recipe.AddIngredient(mod.GetItem("ConMoon"), 8);
			recipe.AddIngredient(ItemID.GravitationPotion, 30);	
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
