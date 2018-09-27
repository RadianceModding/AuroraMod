using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Runic.Weapons
{
	public class RunicStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Runic Staff");
			Tooltip.SetDefault("A staff of great power, forged from the most ancient of magic");
		}
		public override void SetDefaults()
		{
			item.damage = 30;
			item.crit = 12;
			item.knockBack = 3;
			item.magic = true;
			item.width = 40;
			item.height = 60;
			item.useTime = 15;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.value = 0;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;	
			//item.pentration = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("RunicR"), 1);
			recipe.AddIngredient(mod.GetItem("RunicU"), 1);
			recipe.AddIngredient(mod.GetItem("RunicN"), 1);
	        recipe.AddIngredient(mod.GetItem("RunicI"), 1);
			recipe.AddIngredient(mod.GetItem("RunicC"), 1);
			recipe.AddIngredient(mod.GetItem("RuneInscriber"), 1);
			recipe.AddIngredient(mod.GetItem("RunicS"), 1);
			recipe.AddIngredient(mod.GetItem("RunicT"), 1);
			recipe.AddIngredient(mod.GetItem("RunicA"), 1);
	        recipe.AddIngredient(mod.GetItem("RunicF"), 1);
			recipe.AddIngredient(mod.GetItem("RunicF"), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
