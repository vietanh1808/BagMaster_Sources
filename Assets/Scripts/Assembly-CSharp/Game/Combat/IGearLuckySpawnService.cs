using System;

namespace Game.Combat
{
	public interface IGearLuckySpawnService
	{
		event Action<Gear> OnGearReceveidLuck;
	}
}
