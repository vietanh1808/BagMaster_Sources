using System.Collections.Generic;

namespace Game.Combat
{
	public interface IBuffManager
	{
		int AvailableBuffCount { get; }

		IEnumerable<BuffData> GetRandomBuffs(int buffCount, BuffFilterOptions filterOptions = default(BuffFilterOptions));

		void OnChosenBuff(BuffData buff);

		void OnDoneRolling();
	}
}
