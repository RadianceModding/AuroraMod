using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Accessories
{
    public class WarriorEssence : ModItem
    {
       public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Weaker Warrior's Essence");
            Tooltip.SetDefault("The concentrated essence of a Warrior." +
			"\nIncreases Melee damage by 2%" +
			"\nIncreases Melee crit chance by 3%" +
			"\nIncreases Melee speed by 5%");
        }

        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 14;
            item.value = 0;
            item.rare = 0;
            item.accessory = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("MobSoul"), 4);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.meleeDamage += 0.02f;
			player.meleeSpeed += 0.05f;
            player.meleeCrit += 3;
        }
    }
}
// ORDER: Weaker - Weak - Average - Medium - Strong - High - Uber - Insane - Galactic - Cosmic