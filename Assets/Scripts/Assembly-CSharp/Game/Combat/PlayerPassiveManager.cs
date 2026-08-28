using System;
using System.Collections.Generic;

namespace Game.Combat
{
	public class PlayerPassiveManager
	{
		private List<PlayerCombatPassiveData> _passives;

		private List<BuffData> _inGamebuffs;

		public Action OnPassiveUpdatedEvent;

		public IReadOnlyCollection<PlayerCombatPassiveData> Passives => null;

		public IReadOnlyCollection<BuffData> ReceivedBuffs => null;

		public void InitializePassives(List<PlayerSkillData> passives, Unit owner)
		{
		}

		public void LoadSave()
		{
		}

		public void AddPassive(IReadOnlyCollection<SimpleSkill> skills, object source)
		{
		}

		public void RemoveFirstPassiveWithSkillId(int id)
		{
		}

		public void ClearAllCombatBuffs()
		{
		}

		public void ClearAll()
		{
		}
	}
}
