using AuroraMod.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Weapons
{
	public class UberYoyo : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A Yoyo made of YoYos?! IMPOSSIBRU!");

			// These are all related to gamepad controls and don't seem to affect anything else
			ItemID.Sets.Yoyo[item.type] = true;
			ItemID.Sets.GamepadExtraRange[item.type] = 15;
			ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.width = 24;
			item.height = 24;
			item.useAnimation = 25;
			item.useTime = 20;
			item.shootSpeed = 16f;
			item.knockBack = 1.0f;
			item.damage = 55;
			item.crit = 4;
			item.rare = 4;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(gold: 5);
			item.shoot = mod.ProjectileType<UberYoyoProjectile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodYoyo, 1);
			recipe.AddIngredient(ItemID.Rally, 1);
			recipe.AddIngredient(ItemID.CorruptYoyo, 1);
			recipe.AddIngredient(ItemID.JungleYoyo, 1);
			recipe.AddIngredient(ItemID.Code1, 1);
			recipe.AddIngredient(ItemID.Valor, 1);
			recipe.AddIngredient(ItemID.Cascade, 1);
			recipe.AddIngredient(ItemID.CrystalShard, 3);
			recipe.AddIngredient(ItemID.Gel, 16);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
			
			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WoodYoyo, 1);
			recipe.AddIngredient(ItemID.Rally, 1);
			recipe.AddIngredient(ItemID.CrimsonYoyo, 1);
			recipe.AddIngredient(ItemID.JungleYoyo, 1);
			recipe.AddIngredient(ItemID.Code1, 1);
			recipe.AddIngredient(ItemID.Valor, 1);
			recipe.AddIngredient(ItemID.Cascade, 1);
			recipe.AddIngredient(ItemID.CrystalShard, 3);
			recipe.AddIngredient(ItemID.Gel, 16);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
