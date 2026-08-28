using System.Collections.Generic;

namespace Game.Combat
{
	public interface IHasBuffDpsMod
	{
		List<float> Mods { get; }
	}
}
