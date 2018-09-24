using Terraria.ModLoader;

namespace AuroraMod
{
	   /* public override void AddRecipeGroups()
    {
    	RecipeGroup group = new RecipeGroup(() => Lang.misc[37] + "GoldBar", new int[]
    	{
    		ItemID.PlatinumBar,
    		ItemID.GoldBar
    	});
    	RecipeGroup.RegisterGroup("AuroraMod:GoldBar", group);
    } */
	class AuroraMod : Mod
	{
		public AuroraMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}