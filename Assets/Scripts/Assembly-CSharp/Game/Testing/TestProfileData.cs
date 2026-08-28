using System;
using System.Collections.Generic;
using Game.Combat;

namespace Game.Testing
{
	[Serializable]
	public class TestProfileData
	{
		[Serializable]
		public class Sub
		{
			public int Type;

			public CombatSaveData CombatSaveData;
		}

		public const int TYPE_MAIN_CAMPAIGN = 0;

		public const int TYPE_DUNGEON = 1;

		public List<Sub> SaveDatas;
	}
}
