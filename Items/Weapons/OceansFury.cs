using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Weapons
{
	public class OceansFury : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ocean's Fury");
			Tooltip.SetDefault("The power of the Deep Ocean is overwhelming...");
		}

		public override void SetDefaults()
		{
			item.damage = 65;
			item.ranged = true;
			item.width = 40;
			item.height = 20;
			item.useTime = 4;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = Item.sellPrice(0, 40, 0, 0);
			item.rare = 10;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
			//return Main.rand.NextFloat() >= .40f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HallowedBar, 12);
			recipe.AddIngredient(ItemID.SharkFin, 15);
			recipe.AddIngredient(ItemID.SoulofFright, 5);
			recipe.AddIngredient(ItemID.IllegalGunParts, 1);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}