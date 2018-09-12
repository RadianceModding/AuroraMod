/*
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AuroraMod.Items.Accessories
{
    public class ThrowerEssence : ModItem
    {
       public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Weaker Assassins's Essence");
            Tooltip.SetDefault("The concentrated essence of an Assassins." +
			"\nIncreases Throwing damage by 4%" +
			"\nIncreases Throwing crit chance by 3%"");
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
            player.thrownDamage += 0.04f;
            player.thrownCrit += 3;
        }
    }
}
// ORDER: Weaker - Weak - Average - Medium - Strong - High - Uber - Insane - Galactic - Cosmic
*/