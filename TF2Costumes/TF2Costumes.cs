using Terraria;
using Terraria.ModLoader;

namespace TF2Costumes
{
	public class TF2Costumes : Mod
	{
		public override void Load(){
    	{

				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/RocketWaltz"), ItemType("RocketWaltz"), TileType("RocketWaltz"));    	}
		}
	}
}