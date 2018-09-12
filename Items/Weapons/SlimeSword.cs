using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Weapons
{
	public class SlimeSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gel Sword");
			Tooltip.SetDefault("Somehow, moonbeams make Gel super durable!" +
			"\nWho knew?");
		}
		public override void SetDefaults()
		{
			item.damage = 250;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 15;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = Item.sellPrice(0, 0, 0, 64);
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;	
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SlimeBrick"), 50);
			recipe.AddIngredient(mod.GetItem("ConMoon"), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
