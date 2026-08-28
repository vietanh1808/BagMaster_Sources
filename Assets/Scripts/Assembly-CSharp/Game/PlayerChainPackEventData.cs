using System;
using System.Collections.Generic;
using Game.ChainPack;

namespace Game
{
	[Serializable]
	public class PlayerChainPackEventData
	{
		public List<int> Histories;

		public List<ChainPackData> List;
	}
}
