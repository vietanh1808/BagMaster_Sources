using System.Collections.Generic;

namespace Game.Combat
{
	public interface IHasTags
	{
		int Id { get; }

		List<string> Tags { get; }
	}
}
