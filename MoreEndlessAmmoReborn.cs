using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;

namespace MoreEndlessAmmoReborn
{
    public class MoreEndlessAmmoReborn : Mod
    {
	    internal static MoreEndlessAmmoReborn Instance;

		public MoreEndlessAmmoReborn()
		{
			/*Properties/* tModPorter Note: Removed. Instead, assign the properties directly (ContentAutoloadingEnabled, GoreAutoloadingEnabled, MusicAutoloadingEnabled, and BackgroundAutoloadingEnabled)  = new ModProperties()
			{
				/*Autoload = true,
				AutoloadBackgrounds = true,
				AutoloadGores = true,
				AutoloadSounds = true
			}*/
		}

	    public override void Load()
	    {
		    Instance = this;
	    }
    }
}