using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Weapons
{
	public class IceSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Icy Sword");
			Tooltip.SetDefault("Forged from a mystical sword of Ice, this blade is enchanted with great power");
		}
		public override void SetDefaults()
		{
			item.damage = 25;
			item.melee = true;
			item.width = 40;
			item.height = 50;
			item.useTime = 16;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = Item.sellPrice(0, 25, 0, 0);
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;	
			//item.shoot = mod.ProjectileType("IceProj");
			//item.pentration = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlade, 1);
			recipe.AddIngredient(mod.GetItem("IceShard"), 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
