using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Accessories
{
    public class WarriorEssenceT3 : ModItem
    {
       public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Average Warrior's Essence");
            Tooltip.SetDefault("The concentrated essence of a Warrior." +
			"\nIncreases Melee damage by 8%" +
			"\nIncreases Melee crit chance by 12%" +
			"\nIncreases Melee speed by 20%");
        }

        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 14;
            item.value = 0;
            item.rare = 2;
            item.accessory = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("WarriorEssenceT2"), 1);
            recipe.AddIngredient(mod.GetItem("MobSoulT3"), 4);
			recipe.AddTile(TileID.Anvils);
			//recipe.AddTile(TileID.AccBoost);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.meleeDamage += 0.08f;
			player.meleeSpeed += 0.20f;
            player.meleeCrit += 12;
        }
    }
}
// ORDER: Weaker - Weak - Average - Medium - Strong - High - Uber - Insane