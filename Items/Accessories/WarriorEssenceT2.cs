using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Accessories
{
    public class WarriorEssenceT2 : ModItem
    {
       public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Weak Warrior's Essence");
            Tooltip.SetDefault("The concentrated essence of a Warrior." +
			"\nIncreases Melee damage by 4%" +
			"\nIncreases Melee crit chance by 6%" +
			"\nIncreases Melee speed by 10%");
        }

        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 14;
            item.value = 0;
            item.rare = 1;
            item.accessory = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("WarriorEssence"), 1);
            recipe.AddIngredient(mod.GetItem("MobSoulT2"), 4);
			recipe.AddTile(TileID.WorkBenches);
			//recipe.AddTile(TileID.AccBoost);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.meleeDamage += 0.04f;
			player.meleeSpeed += 0.10f;
            player.meleeCrit += 6;
        }
    }
}
// ORDER: Weaker - Weak - Average - Medium - Strong - High - Uber - Insane