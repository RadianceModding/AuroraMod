using Terraria.ModLoader;

namespace AuroraMod
{
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
