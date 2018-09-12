using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Weapons.Heavy
{
	public class HTinSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heavy Tin Broadsword");
			Tooltip.SetDefault("Very heavy, probably because of all that extra metal");
		}
		public override void SetDefaults()
		{
			item.damage = 18;
			item.crit = 6;
			item.melee = true;
			item.width = 50;
			item.height = 60;
			item.useTime = 30;
			item.useAnimation = 25;
			item.useStyle = 1;
			item.knockBack = 8;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;	
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBroadsword, 1);
			recipe.AddIngredient(mod.GetItem("HTinBar"), 4);
			recipe.AddIngredient(ItemID.Wood, 3);
			recipe.anyWood = true;
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
