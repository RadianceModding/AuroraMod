/*
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Accessories
{
    public class RangerEssence : ModItem
    {
       public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Weaker Sniper's Essence");
            Tooltip.SetDefault("The concentrated essence of a Sniper." +
			"\nIncreases Ranged damage by 5%" +
			"\nIncreases Ranged crit chance by 3%"");
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
            player.rangedDamage += 0.05f;
            player.rangedCrit += 3;
        }
    }
}
// ORDER: Weaker - Weak - Average - Medium - Strong - High - Uber - Insane - Galactic - Cosmic
*/